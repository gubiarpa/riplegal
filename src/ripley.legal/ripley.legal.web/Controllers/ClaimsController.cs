using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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
            var lawFirms = await _context.LawFirms.OrderBy(x => x.Description).ToListAsync();
            return new JsonResult(lawFirms);
        }

        public async Task<IActionResult> GetAgencies()
        {
            try
            {
                var agencies = await _context.Agencies.OrderBy(x => x.Description).ToListAsync();
                return new JsonResult(agencies);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> GetCities()
        {
            var cities = await _context.Cities.OrderBy(x => x.Description).ToListAsync();
            return new JsonResult(cities);
        }

        public async Task<IActionResult> GetProcessTypes()
        {
            var processTypes = await _context.ProcessTypes.ToListAsync();
            return new JsonResult(processTypes);
        }

        public async Task<IActionResult> GetClaimers()
        {
            var claimers = await _context.Claimers.ToListAsync();
            return new JsonResult(claimers);
        }

        public async Task<IActionResult> GetDefendants()
        {
            var defendants = await _context.Defendants.ToListAsync();
            return new JsonResult(defendants);
        }

        public async Task<IActionResult> GetTypologies()
        {
            var typologies = await _context.Typologies.ToListAsync();
            return new JsonResult(typologies);
        }

        public async Task<IActionResult> GetLegalPositions()
        {
            var legalPositions = await _context.LegalPositions.ToListAsync();
            return new JsonResult(legalPositions);
        }

        public async Task<IActionResult> GetDefenseAssessments()
        {
            var defenseAssessments = await _context.DefenseAssessments.ToListAsync();
            return new JsonResult(defenseAssessments);
        }
        #endregion
    }
}
