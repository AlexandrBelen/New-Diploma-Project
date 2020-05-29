using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models.Account
{
    public class RegisterModel
    {
        [Required]
        [DataType("Email")]
        public string Email { get; set; }
        [Required]
        [DataType("Password")]
        public string Password { get; set; }
        [Required]
        [DataType("Password")]
        public string ConfirmPassword { get; set; }
    }
}