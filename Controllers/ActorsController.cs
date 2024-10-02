using eTicketMvcApp.Data;
using eTicketMvcApp.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTicketMvcApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
                _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
