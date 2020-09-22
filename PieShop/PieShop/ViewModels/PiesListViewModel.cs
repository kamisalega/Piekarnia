using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;

namespace PieShop.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
    }
}