using EmployeeApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeApplication.Securirty
{
    public class AuthService : IAuthentificationService
    {
        private readonly UserManager<User> _UserManager;
        private readonly RoleManager<IdentityRole> _RoleManger;
        static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _Context;

        public AuthService(UserManager<User> UserManager, RoleManager<IdentityRole> RoleManger, IConfiguration configuration, AppDbContext context)
        {
            _UserManager = UserManager;
            _RoleManger = RoleManger;
            _configuration = configuration;
            _Context = context;
        }
        public async Task<SignInEmployeeResponse> SignInEmployee(SignInDTO signInDTO)
        {
            JwtSecurityToken token = null;
            User account = null;
            Employee employee = null;
            account = await FindAccountWithIdentifyAndPassword(signInDTO.Identify, signInDTO.Password);
            if (account != null)
                employee = _Context.Employees.Where(e => e.UserID == account.Id).FirstOrDefault();
                token = GenerateToken(account, "Client");
            return new SignInEmployeeResponse()
            {
                employee = employee,
                token = new JwtSecurityTokenHandler().WriteToken(token)
            };
        }
        private JwtSecurityToken GenerateToken(User user, string role)
        {
            List<Claim> authClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim("Role",role)
            };
            var signInKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            JwtSecurityToken token = new JwtSecurityToken
                (
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(signInKey, SecurityAlgorithms.HmacSha256)


                );
            return token;
        }

        private async Task<User> FindAccountWithIdentifyAndPassword(string Identify, string password)
        {
            User User;
            bool checkPassword;
            if (string.IsNullOrEmpty(Identify))
                throw new Exception("Identify is required");

            User = await _UserManager.FindByEmailAsync(Identify);
            if (User == null)
                User = await _UserManager.FindByNameAsync(Identify);
            if (User == null)
                User = _UserManager.Users.Where(U => U.Email == Identify).FirstOrDefault();
            if (User == null)
                throw new Exception("Identity Or Password are invalid");
            checkPassword = await _UserManager.CheckPasswordAsync(User, password);
            if (!checkPassword)
                throw new Exception("Identity Or Password are invalid");
            return User;

        }

        public Task<User> SignUpEmployee(Employee employee)
        {
            return CreateUser(employee, "Employee");
        }


        private async Task<User> CreateUser(Employee employee, string role)
        {
            bool emailExist;
            bool phoneExist;
            User newUser;
            if (employee == null)
                throw new Exception("Employee Details Null ");
            emailExist = await VerifyUniqueEmailAsync(employee.Email);
            if (emailExist)
                throw new Exception("Email Is Already Used");
            //phoneExist = VerifyUniquePhoneAsync(employee.Telephone.ToString());
            //if (phoneExist)
            //    throw new Exception("Phone Is Already Used");
            //Add Unique Identity Test
            newUser = new User()
            {
                UserName = employee.Email,
                Email = employee.Email,
                PhoneNumber = employee.Telephone.ToString(),

            };
            string password = GeneratePassword();


            IdentityResult result = await _UserManager.CreateAsync(newUser, password);
            SendEmail(employee.Email, password);
            if (result.Succeeded)
            {
                _ = AddRoleToUser(newUser, role);

                return newUser;
            }

            return null;
        }


        public void SendEmail(string to,string newpassword)
        {
            try { 
             string smtpAddress = "smtp.gmail.com";
             int portNumber = 587;
             bool enableSSL = true;
             string emailFromAddress = "rhapplication40@gmail.com"; //Sender Email Address  
             string password = "Abd0Nj4h1234!"; //Sender Password  
             string emailToAddress = to; //Receiver Email Address  
             string subject = "Bienvenue dans notre platform";
             string body = "chere employee bienvenue vous pouvez utiliser cette mots de passe pour acceder au platforme de societe: "+ newpassword;
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
            }catch(Exception Ex) { }
        }

private async Task<bool> VerifyUniqueEmailAsync(string email)
        {
            User User = await _UserManager.FindByEmailAsync(email);
            return User != null;
        }
        private bool VerifyUniquePhoneAsync(string phoneNumber)
        {
            bool phoneUsed = _UserManager.Users.Where(user => user.PhoneNumber == phoneNumber).Any();
            return phoneUsed;
        }

        private async Task AddRoleToUser(User newUser, string role)
        {
            if (!await _RoleManger.RoleExistsAsync(role))
                await _RoleManger.CreateAsync(new IdentityRole(role));
            await _UserManager.AddToRoleAsync(newUser, role);
        }

        private string GeneratePassword()
        {
            
            string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "0123456789";
            string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
            string AllChar = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

            StringBuilder sb = new StringBuilder();
            for (int n = 0; n < 10; n++)
            {
                sb = sb.Append(GenerateChar(AllChar));
            }
            return sb.ToString();

        }

        private static char GenerateChar(string availableChars)
        {
            var byteArray = new byte[1];
            char c;
            do
            {
                provider.GetBytes(byteArray);
                c = (char)byteArray[0];

            } while (!availableChars.Any(x => x == c));

            return c;
        }
    }
}
