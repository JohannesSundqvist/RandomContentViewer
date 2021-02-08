using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomContentViewer2.Interfaces;
using RandomContentViewer2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RandomContentViewer2.Controllers
{
    public class MainController : Controller
    {
        private IDataContext _context;

        public MainController(IDataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
