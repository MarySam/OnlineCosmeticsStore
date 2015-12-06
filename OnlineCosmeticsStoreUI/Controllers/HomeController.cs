﻿using OnlineCosmeticsStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCosmeticsStoreUI.Controllers
{
    public class HomeController : Controller
    {
        //This is the default method.  The Index is the entry point similar to the main method. 
        public ActionResult Index()
        {
            //This is the html front end.  What displays to the user.
            return View();
        }
        //The ActionResult is a return TYPE. 
        //SignIn is the method name.
        //FormCollection collection is the parameter.
        public ActionResult SignIn(FormCollection collection)
        {
            //This is going to call the index.cshtml and find the textbox called "txtEmail"
            var email = collection["txtEmail"];
            
                var accounts = CustomerInformation.GetAllCustomerInformationByEmail(email);
                //Prints out the all accounts in the html.
                return View(accounts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            //Get.
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerInformation account)
        {
            var newAccount = CustomerInformation.CreateCustomerInformation(account.EmailAddress, account.CustomerName, account.Address);
            if (newAccount != null)
            {
                return RedirectToAction("Detail", new { id = newAccount.EmailAddress});
            }
            return View();
        }

        public ActionResult Detail(string id)
        {
            var account = CustomerInformation.GetAllCustomerInformationByEmail(id);
            return View(account);
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}