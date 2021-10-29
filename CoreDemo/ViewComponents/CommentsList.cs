using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;

namespace CoreDemo.ViewComponents
{
    public class CommentsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "İrem"
                },
                new UserComment
                {
                    ID = 2,
                    Username = "Aysel"
                },
                new UserComment
                {
                    ID = 3,
                    Username = "İpek"
                }
            };
            return View(commentvalues);
        }
    }
}
