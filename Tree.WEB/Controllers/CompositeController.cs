using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tree.WEB.Services.Abstract;
using Tree.WEB.ViewModels;

namespace Tree.WEB.Controllers
{
    public class CompositeController : Controller
    {
        private readonly IService _service;

        public CompositeController(IService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<List<CompositeViewModel>> GetTree()
        {
            var result = await _service.GetAllCompositesAsync();

            return result;
        }
    }
}
