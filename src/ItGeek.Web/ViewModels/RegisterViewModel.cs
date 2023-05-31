﻿using System.ComponentModel.DataAnnotations;

namespace ItGeek.Web.ViewModels;

public class RegisterViewModel
{
    [Display(Name = "Почта")]
    [Required(ErrorMessage = "Не указан Email")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Display(Name = "Пароль")]
    [Required(ErrorMessage = "Не указан пароль")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Подтвердите пароль")]
    [Required(ErrorMessage = "Не указана проверка пароля")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
    public string ConfirmPassword { get; set; }
}
