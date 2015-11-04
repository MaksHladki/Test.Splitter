﻿using System.ComponentModel.DataAnnotations;

namespace Shared.Model
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]
        [DataType(DataType.Text)]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}