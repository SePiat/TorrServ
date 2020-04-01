using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AFINNService;
using CommentService;
using Microsoft.AspNetCore.Mvc;
using MoviesDownloader;
using Serilog;
using TorrServ.Data;
using TorrServ.Models;
using TorrServCore;
using TorrServData.Models;
using TorrServRepositories.UoW;

namespace TorrServ.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISaveCommentsToDb _saveCommentsToDb;
        private readonly ISaveMovies _saveMovies; 
        private readonly ILemmatization _lemmatization;
        private readonly ICommentHanlder _commentHanlder;

        public HomeController(IUnitOfWork unitOfWork, ISaveCommentsToDb saveCommentsToDb, ISaveMovies saveMovies, ILemmatization lemmatization, ICommentHanlder commentHanlder)
        {
            _unitOfWork = unitOfWork;
            _saveCommentsToDb = saveCommentsToDb;
            _saveMovies = saveMovies;
            _lemmatization = lemmatization;
            _commentHanlder = commentHanlder;
        }




        //protected readonly ApplicationDbContext _context;







        public ActionResult Index()
        {
           
            //_saveMovies.SaveMov();
            for (int i = 0; i < 1000; i++)
            {
                Log.Information($"step{i}{ Environment.NewLine}");
                System.Diagnostics.Debug.WriteLine($"step{i}{ Environment.NewLine}");
                _commentHanlder.GetCommentIndex();
            }
           
            




            Log.Information($"Load controller Home/index{ Environment.NewLine}");
            return View(_unitOfWork.torrentMove.AsQueryable());
            
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
