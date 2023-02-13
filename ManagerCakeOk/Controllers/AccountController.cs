﻿using Library.ServiceAdmin.ServiceAdminInjection.Account;
using Library.ViewModel.Admin.V_Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerCakeOk.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccount _context;
        public AccountController(IAccount context)
        {
            _context = context;
        }

        //page staff or chef
        [HttpGet]
        public IActionResult PageStaffOrChef()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllStaffOrChef()
        {
            var result = _context.GetAllStaffOrChef();
            return new JsonResult(result);
        }

        //create staff or chef
        [HttpPost]
        public IActionResult CreateStaffOrChef(string Name)
        {
            var result = _context.CreateStaffOrChef(Name, true);
            return new JsonResult(result);
        }

        //page account
        [HttpGet]
        public IActionResult PageAccount()
        {
            return View();
        }

        //Get All Account Staff
        [HttpGet]
        public IActionResult GetAllAccountStaff(int Index, int Size)
        {
            var Pading = new PadingAccount();
            var result = _context.GetAllAccount();
            Pading.L_Account = result.Skip((Index - 1) * Size).Take(Size).ToList();
            Pading.Total = result.Count();
            return new JsonResult(Pading);
        }

        //Create account staff
        [HttpGet]
        public IActionResult PageCreateAccount()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAccountGet()
        {
            var result = _context.GetInfoCreateAccount();
            return new JsonResult(result);
        }

        
    }
}