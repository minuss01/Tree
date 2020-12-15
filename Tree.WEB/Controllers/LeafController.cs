using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree.WEB.Controllers
{
    public class LeafController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
