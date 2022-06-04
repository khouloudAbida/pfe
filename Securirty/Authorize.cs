using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EmployeeApplication.Securirty
{
    //public class SageAdminAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    //{
    //    public AuthorizeAttribute2(params string[] claim) : base(typeof(AuthorizeFilter))
    //    {
    //        Arguments = new object[] { claim };
    //    }
    //}

    public class EmployeeAuth : AuthorizeAttribute, IAuthorizationFilter
    {
        

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var IsAuthenticated = context.HttpContext.User.Identity.IsAuthenticated;
            var claimsIndentity = context.HttpContext.User.Identity as ClaimsIdentity;
            bool flagClaim = false;
            if (IsAuthenticated)
            {
                
                
                    if (context.HttpContext.User.HasClaim("Role", "Employee"))
                        flagClaim = true;
                
                if (!flagClaim)
                {
                    
                        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized; //Set HTTP 401   
                    
                        context.Result = new RedirectResult("~/Home/Error");
                }
            }
            else
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                context.Result = new RedirectResult("~/Home/Error");
                
                
                    //Set HTTP 403 -   
                
            }
            return;
        }
    }



    public class RhAuth : AuthorizeAttribute, IAuthorizationFilter
    {
        readonly string[] _claim;

        public RhAuth(params string[] claim)
        {
            _claim = claim;

        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var IsAuthenticated = context.HttpContext.User.Identity.IsAuthenticated;
            var claimsIndentity = context.HttpContext.User.Identity as ClaimsIdentity;
            bool flagClaim = false;
            if (IsAuthenticated)
            {


                if (context.HttpContext.User.HasClaim("Role", "RH"))
                    flagClaim = true;

                if (!flagClaim)
                {

                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized; //Set HTTP 401   

                    context.Result = new RedirectResult("~/Login/Index");
                }
            }
            else
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                context.Result = new RedirectResult("~/Login/Index");


                //Set HTTP 403 -   

            }
            return;
        }
    }
}
