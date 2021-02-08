using Microsoft.AspNetCore.Mvc;
using RandomContentViewer2.Interfaces;
using RandomContentViewer2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomContentViewer2.Controllers
{
    public class UploadController : Controller
    {
        private IDataContext _context;

        public UploadController()
        {
            _context = new DataContext();
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(User user)
        {
            if (!string.IsNullOrWhiteSpace(user.Username))
                ViewData["Message"] = _context.AddPerson(user) + " was added";
            else
                ViewData["Message"] = "The person needs a name!";

            return View();
        }
    }
}
