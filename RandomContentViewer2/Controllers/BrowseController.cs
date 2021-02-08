using Microsoft.AspNetCore.Mvc;
using RandomContentViewer2.Interfaces;
using RandomContentViewer2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomContentViewer2.Controllers
{
    public class BrowseController : Controller
    {
        private IDataContext _context;

        public BrowseController(IDataContext context)
        {
            _context = context;
        }

        public IActionResult Browse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Browse(User person, string refreshPerson, string refreshNumber)
        {
            Random rnd = new Random();
            List<User> users = _context.GetUsers();

            if (!string.IsNullOrWhiteSpace(refreshPerson))
            {
                if (!users.Any())
                    return View(new User("N/A"));
                else
                    return View(users.ElementAt(rnd.Next(users.Count)));
            }

            else if (!string.IsNullOrWhiteSpace(refreshNumber))
                ViewData["GetRandomNumber"] = rnd.Next(100);

            return View();
        }
    }
}
