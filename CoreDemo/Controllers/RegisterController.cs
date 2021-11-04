using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        // Metodlar aynı isimde olmak zorunda

        WriterManager vm = new WriterManager(new EfWriterRepository());
        

        [HttpGet]  //sayfa yüklenince

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]  //Sayfada buton tetiklenince

        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);

            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = null;
                vm.TAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
