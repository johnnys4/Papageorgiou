using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Papageorgiou.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Code404()
        {
            return View();
        }
    }
}