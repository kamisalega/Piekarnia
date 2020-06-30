using Microsoft.AspNetCore.Mvc.Rendering;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ViewModels
{
    public class PieEditViewModel
    {
        public Pie Pie { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public Category Category { get; set; }
    }
}
