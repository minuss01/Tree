using Tree.WEB.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree.WEB.Controllers
{
    public class CompositeController : Controller
    {

        public CompositeController()
        {
            
        }

        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
