using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.net_Core_Project.Data;
using Asp.net_Core_Project.Models;
using Asp.net_Core_Project.Services;
using Asp.net_Core_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_Core_Project.Controllers
{
    public class BarsController : Controller
    {
        private ApplicationDbContext db;
        private readonly IBarsService barsService;
        private readonly UserManager<IdentityUser> userManager;

        public BarsController(IBarsService barsService,
            UserManager<IdentityUser> userManager,
            ApplicationDbContext db)
        {
            this.db = db;
            this.barsService = barsService;
            this.userManager = userManager;
        }
        public IActionResult Bars()
        {
            var bars = this.db.Bars.ToList();
            var barModel = new BarsViewModel
            {
                Bars = bars
            };
            return View(barModel);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddBarInputModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);          
            await this.barsService.Create(user.Id,input.Name,input.Town, input.Address, input.ImageURL);           
            return RedirectToAction("Bars");
        }
    }
}