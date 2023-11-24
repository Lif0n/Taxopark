using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Taxopark.Models;
using Taxopark.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AspNetCore;

namespace Taxopark.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly MainContext _context;

        public OrdersController(ILogger<OrdersController> logger, MainContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ActionResult Index()
        {
            OrderViewModel OVM = new OrderViewModel
            {
                Orders = _context.Orders
                .Include(x=>x.Transport)
                .ThenInclude(x=>x.Driver)
                .Include(x=> x.OrderType)
                .OrderBy(x=> x.OrderStatus)
                .ToList(),
                OrderTypes = new SelectList(_context.OrderTypes.ToList(), "Id","Name"),
                Cars = new SelectList( _context.Transports.ToList(), "Id","Mark"),
            };
            return View(OVM);
        }
        //https://professorweb.ru/my/ASP_NET/sites/level5/5_4.php
        //ajax
        [HttpPost]
        public void Index(string clientName, string clientNumber, Transport car, OrderType type, string adresFrom, string adresTo, double price)
        {
            if (!String.IsNullOrEmpty(clientName) && !String.IsNullOrEmpty(clientNumber) && !String.IsNullOrEmpty(adresFrom) && !String.IsNullOrEmpty(adresTo) && price > 0)
            {

            }
            else;
                
        }
    }
}
