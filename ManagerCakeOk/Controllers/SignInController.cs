using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerCakeOk.Controllers
{
    public class SignInController : Controller
    {
        // TODO: PAGE LOGIN
        [HttpGet]
        public IActionResult PageLogin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PageLogOut()
        {
            return View();
        }
    }
}
