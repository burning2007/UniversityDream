using System;
using System.Web.Mvc;
using System.Web.Security;
using GloriousFutureWeb.Models;
using Domain = GF.Domain.Context;
using GF.Application.Context.Services;
using GF.Application.Context;

namespace GloriousFutureWeb.Controllers
{
    [Authorize]
    //[InitializeSimpleMembership]
    public class UserController : Controller
    {
        private UserAppService userService;
        private RegionAppService regionService;
        private UniversityAppService universityService;

        public UserController()
        {
            userService = new UserAppService();
            regionService = new RegionAppService();
            universityService = new UniversityAppService();
        }

        //
        // GET: /Account/Login

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid && userService.Login(model.UserName, model.Password))//WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe))
            {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToLocal(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "用户名不存在或者密码不对");
            return View(model);
        }

        //
        // POST: /Account/LogOff

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //WebSecurity.Logout();
            Response.Cookies.Clear();
            FormsAuthentication.SignOut();

            return RedirectToLocal(string.Empty);
        }

        //
        // GET: /Account/Register

        [AllowAnonymous]
        //[OutputCache(Duration = 1200)]
        public ActionResult Register()
        {
            var model = new RegisterModel();
            var provinces = regionService.GetFiltered(r => r.Class == 1);
            ViewBag.Provinces = provinces;
            var id = provinces[0].Id;
            ViewBag.Universities = universityService.GetFiltered(u => u.ProvinceId == id);
            return View(model);
        }

        [AllowAnonymous]
        //[OutputCache(Duration=600, VaryByParam="provinceId")]
        public PartialViewResult SearchUniversity(Guid provinceId)
        {
            var universities = universityService.GetFiltered(u => u.ProvinceId == provinceId);
            return PartialView("_SearchUniversity", universities);
        }

        //
        // POST: /Account/Register

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    //WebSecurity.CreateUserAndAccount(model.AccountName, model.Password);
                    //WebSecurity.Login(model.AccountName, model.Password);
                    //var membershipUser = Membership.CreateUser(model.UserName, model.Password, model.Email);
                    //var user = userService.GetUser(model.UserName); 
                    //userService.ChangeUser(model.UserName, model.QQ, true);
                    var user = new Domain.User(Guid.NewGuid(), model.UserName, model.Password, model.Email, model.QQ);               
                    var role = new Domain.Role();
                    if (model.UniversityId != Guid.Empty)
                    {
                        role = userService.GetRole(Domain.RoleType.企业.ToString());
                        user.UniversityId = model.UniversityId;
                    }
                    else
                        role = userService.GetRole(Domain.RoleType.个人.ToString());

                    user.RoleId = role.Id;

                    userService.Register(user);

                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    
                    return RedirectToAction("Index", "Home");
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                }
            }
            // If we got this far, something failed, redisplay form
            return Register();
        }

        [HttpGet]
        public PartialViewResult ChangePassword()
        {
            return PartialView("_ChangePasswordPartial", new ChangePasswordModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(string oldPassword, string newPassword)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    userService.ChangePassword(User.Identity.Name, oldPassword, newPassword);
                    return RedirectToLocal(string.Empty);
                }
            }
            catch (UserNotExistException)
            {
                ViewBag.StatusMessage = "原密码不正确";              
            }
            return View("_ChangePasswordPartial");
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult ResetPassword()
        {
            return View("_SetPasswordPartial");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult ResetPassword(ResetPasswordModel model)
        {
            try
            {
                userService.ResetPassword(model.UserName, model.Email);
                FormsAuthentication.SignOut();
                return RedirectToLocal(string.Empty);
            }
            catch (UserNotExistException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View("_SetPasswordPartial");
        }


        public ActionResult Manage()
        {
            return View();
        }


        //
        // GET: /Account/Manage

        //public ActionResult Manage(ManageMessageId? message)
        //{
        //    ViewBag.StatusMessage =
        //        message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
        //        : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
        //        : message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
        //        : "";
        //    ViewBag.HasLocalPassword = true;// OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
        //    ViewBag.ReturnUrl = Url.Action("ChangePassword");
        //    return View();
        //}

        //
        // POST: /Account/Manage

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Manage(LocalPasswordModel model)
        //{
            //var hasLocalAccount = User == null ? false : true; //OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
            //ViewBag.HasLocalPassword = hasLocalAccount;
            //ViewBag.ReturnUrl = Url.Action("Manage");
            //if (hasLocalAccount)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        // ChangePassword will throw an exception rather than return false in certain failure scenarios.
            //        bool changePasswordSucceeded;
            //        try
            //        {
            //            changePasswordSucceeded = WebSecurity.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
            //        }
            //        catch (Exception)
            //        {
            //            changePasswordSucceeded = false;
            //        }

            //        if (changePasswordSucceeded)
            //        {
            //            return RedirectToAction("Manage", new { Message = ManageMessageId.ChangePasswordSuccess });
            //        }
            //        else
            //        {
            //            ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
            //        }
            //    }
            //}
            //else
            //{
            //    // User does not have a local password so remove any validation errors caused by a missing
            //    // OldPassword field
            //    ModelState state = ModelState["OldPassword"];
            //    if (state != null)
            //    {
            //        state.Errors.Clear();
            //    }

            //    if (ModelState.IsValid)
            //    {
            //        try
            //        {
            //            WebSecurity.CreateAccount(User.Identity.Name, model.NewPassword);
            //            return RedirectToAction("Manage", new { Message = ManageMessageId.SetPasswordSuccess });
            //        }
            //        catch (Exception e)
            //        {
            //            ModelState.AddModelError("", e);
            //        }
            //    }
            //}

            // If we got this far, something failed, redisplay form
        //    return View(model);
        //}

        #region Helpers
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
        }


        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
