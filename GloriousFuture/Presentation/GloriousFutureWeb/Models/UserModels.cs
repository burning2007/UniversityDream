using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Objects.DataClasses;
using System.Text.RegularExpressions;

namespace GloriousFutureWeb.Models
{

    public class RegisterModel 
    {
        [Required(ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_UserNameEmpty")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [RegularExpression("[a-zA-Z0-9]{6,12}", ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_Password")]
        [StringLength(12, MinimumLength = 6, ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_Password")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [RegularExpression("[a-zA-Z0-9]{6,12}", ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_Password")]
        [StringLength(12, MinimumLength = 6, ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_Password")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_ConfirmedPassword")]
        public string ConfirmedPassword { get; set; }

        [Required(ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_Email")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Display(Name = "邮件")]
        public string Email { get; set; }

        public string QQ { get; set; }

        [Required(ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_University")]
        public Guid UniversityId { get; set; }

        [Required(ErrorMessageResourceType = typeof(UserResources), ErrorMessageResourceName = "er_University")]
        [Display(Name = "大学")]
        public string UniversityName { get; set; }

    }


    public class LoginModel
    {
        [Required(ErrorMessage = "用户名不能为空")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "记住我?")]
        public bool RememberMe { get; set; }
    }


    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "当前密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "当前密码")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "当前密码不能为空")]
        [RegularExpression("[a-zA-Z0-9]{6,12}", ErrorMessage = "密码只能是6到12位的字母和数字")]
        [DataType(DataType.Password)]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "当前密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "新密码确认")]
        [RegularExpression("[a-zA-Z0-9]{6,12}", ErrorMessage = "密码只能是6到12位的字母和数字")]
        [Compare("NewPassword", ErrorMessage = "确认密码必须和密码相同")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "用户名不能为空")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "邮件不能为空")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Display(Name = "邮件")]
        public string Email { get; set; }
    }


    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("ApplicationContext")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

}
