using AutoMapper;
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
        private readonly IMapper _mapper;

        public NodeController(
            IService service,
            IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
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

        [HttpGet]
        public async Task<List<LabelValueViewModel>> GetSelectValues()
        {
            var result = await _service.GetSelectValuesAsync();

            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] NodeAddFormViewModel request)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.AddNodeAsync(request);

                if (!result.IsSuccess)
                {
                    return BadRequest();
                }

                return Ok(result.Message);
            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _service.RemoveNodeAsync(id);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> Edit([FromRoute] int id)
        {
            var result = await _service.GetNodeByIdAsync(id);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            var model = _mapper.Map<NodePostFormViewModel>(result);

            return Json(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromBody] NodePostFormViewModel request)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.UpdateNodeAsync(request);

                if (!result.IsSuccess)
                {
                    return BadRequest(result.Message);
                }
                return Ok(result.Message);
            }

            return BadRequest();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
