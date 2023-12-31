﻿namespace SkyTracker.Web.ViewModels.User;

using System.ComponentModel.DataAnnotations;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; } = null!;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
}