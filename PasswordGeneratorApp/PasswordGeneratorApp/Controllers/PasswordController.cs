using PasswordGeneratorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer.PasswordGenerator;
using BusinessLogicLayer.Models;

namespace PasswordGeneratorApp.Controllers
{
    public class PasswordController : Controller
    {
        // GET: Password
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        
        [HttpPost]
         public ActionResult Index(string generator)
        {
            PasswordsAndIds isPasswordExpire = new PasswordsAndIds();
            
            ValidatePasswordWithID validate = new ValidatePasswordWithID();
            List<PasswordsAndIds> viewPassword = validate.ValidatePassword(generator);

            Session["VerificationCode"] = isPasswordExpire.Password;
            Session["VerificationTime"] = DateTime.Now;

            if (Convert.ToDateTime(Session["VerificationTime"]).AddSeconds(30) < DateTime.Now)
                {
                ModelState.AddModelError("VerificationCode", "Verification Code Expired!");
                viewPassword = validate.ValidatePassword(generator);
                return View(viewPassword);
            }
           
                List<PasswordsAndIds> generarePassword = validate.ValidatePassword(generator);
                return View(viewPassword);
            
        }
    }
}