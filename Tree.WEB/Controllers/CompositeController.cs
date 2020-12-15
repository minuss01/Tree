using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tree.WEB.Services.Abstract;

namespace Tree.WEB.Controllers
{
    public class CompositeController : Controller
    {
        private readonly IService _service;

        public CompositeController(IService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllCompositesAsync();
            return View(result);
        }
    }
}
