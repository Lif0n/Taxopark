using Microsoft.AspNetCore.Mvc;

namespace Taxopark.Controllers
{
    public class DriversController : Controller
    {
        private readonly ILogger<DriversController> _logger;

        public DriversController(ILogger<DriversController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
