using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class Employee
    {
        [Key]

        public int IdEmployee { get; set; }
        public int Cin { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Nom")]
        public string Nom { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Prenom")]
        public string Prenom { get; set; }

        [DataType(DataType.Date)]

        public DateTime DateNaissance { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Email")]
        public string Email { get; set; }
        public int Telephone { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Adresse")]
        public string Adresse { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Sexe")]
        public string Sexe { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEmbauché { get; set; }
      
        public int  SoldeCongé { get; set; }

        public string UserID { get; set; }

        public User User { get; set; }
    }
}
