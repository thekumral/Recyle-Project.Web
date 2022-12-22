﻿using System.ComponentModel.DataAnnotations;

namespace Recyle_Project.Web.Models;

public class LoginViewModel
{


    [Required(ErrorMessage = "Username is required.")]
    [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
    public String UserName { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [MinLength(6, ErrorMessage = "Password can be min 6 characters.")]
    [MaxLength(8, ErrorMessage = "Password can be max 8 characters.")]
    public string Password { get; set; }
    public bool KeepLoggedIn { get; set; }
}
