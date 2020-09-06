using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ripley.legal.repository;

namespace ripley.legal.web.Controllers
{
    public class ClaimsController : Controller
    {
        protected readonly DbContextApp _context;

        public ClaimsController(DbContextApp context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        #region AjaxRequests
        public async Task<IActionResult> GetLawFirms()
        {
            var lawFirms = await _context.LawFirms.ToListAsync();
            return new JsonResult(lawFirms);
        }

        public async Task<IActionResult> GetCities()
        {
            var cities = await _context.Cities.ToListAsync();
            return new JsonResult(cities);
        }
        #endregion
    }
}
