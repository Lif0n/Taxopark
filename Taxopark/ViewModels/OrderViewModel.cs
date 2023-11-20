using Microsoft.AspNetCore.Mvc.Rendering;
using Taxopark.Models;

namespace Taxopark.ViewModels
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public SelectList OrderTypes { get; set;}
        public SelectList Cars { get; set; }
    }
}
