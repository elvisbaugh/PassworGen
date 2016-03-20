using PasswordGeneratorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer.PasswordGenerator;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Interfaces;

namespace PasswordGeneratorApp.Controllers
{
    public class PasswordController : Controller
    {
        private IValidatePassword validate;

        public PasswordController (IValidatePassword validate)
        {
            this.validate = validate;
        }

        public PasswordController()
        {
            this.validate = new ValidatePasswordWithID();
        }


        // GET: Password
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(string identificationNumber)
        {
            if (ModelState.IsValid)
            {
                PasswordsAndIds viewPassword = validate.ValidatePassword(identificationNumber);


                ViewPasswordAndId viewPasswordAndId = new ViewPasswordAndId();

                viewPasswordAndId.ViewGeneratedPassword = viewPassword.Password;
                viewPasswordAndId.ViewID = viewPassword.ID;

                TempData["iDNumber"] = viewPasswordAndId.ViewID;
                TempData["password"] = viewPasswordAndId.ViewGeneratedPassword;

                return RedirectToAction("DisplayIdAndPassword");

            }
            return View();
        }

        public ActionResult DisplayIdAndPassword()
        {
            ViewPasswordAndId isPasswordExpire = new ViewPasswordAndId();

            isPasswordExpire.ViewID = Convert.ToString(TempData["iDNumber"]);
            isPasswordExpire.ViewGeneratedPassword = Convert.ToString(TempData["password"]);

            if (Session["EndDate"] == null)
            {
                Session["EndDate"] = DateTime.Now.AddSeconds(30).ToString("dd-MM-yyyy h:mm:ss tt");
            }

            ViewBag.EndDate = Session["EndDate"];
            return View(isPasswordExpire);
        }
    }
}