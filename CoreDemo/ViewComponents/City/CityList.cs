using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.ViewComponents.City
{
    public class CityList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            List<SelectListItem> cities = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Ankara", Value = "1"},
                new SelectListItem {Text = "Bursa", Value = "2"},
                new SelectListItem {Text = "İzmir", Value = "3"},
                new SelectListItem {Text = "Samsun", Value = "4"},
                new SelectListItem {Text = "Rize", Value = "5"},
            };

            ViewBag.city = cities;
            return View();
        }
    }
}
