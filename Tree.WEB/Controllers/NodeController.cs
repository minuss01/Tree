using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Tree.WEB.Services.Abstract;
using Tree.WEB.ViewModels;

namespace Tree.WEB.Controllers
{
    public class NodeController : Controller
    {
        private readonly IService _service;

        public NodeController(IService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<List<NodeViewModel>> GetTree()
        {
            var result = await _service.GetAllNodesAsync();

            return result;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
