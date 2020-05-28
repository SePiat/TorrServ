using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TorrServ.ViewModels;
using TorrServ.Views.Models;
using TorrServCore;
using TorrServData.Models;

namespace TorrServ.Controllers
{
   

    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISaveMovies _saveMovies;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserViewModel userViewModel;

        



        public AdminController(ISaveMovies saveMovies, IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _roleManager = roleManager;
            _saveMovies = saveMovies;
            
        }
        [Authorize(Roles = "admin")]
        public IActionResult Index() => View();
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateDatabase()
        {
            await Task.Run(() => _saveMovies.SaveMov());
            return RedirectToAction("Index");

        }

        
    }
}
