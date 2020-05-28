using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
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
        

        public HomeController(IUnitOfWork unitOfWork, ISaveCommentsToDb saveCommentsToDb, ISaveMovies saveMovies, ILemmatization lemmatization, ICommentHanlder commentHanlder )
        {
            _unitOfWork = unitOfWork;
            _saveCommentsToDb = saveCommentsToDb;
            _saveMovies = saveMovies;
            _lemmatization = lemmatization;
            _commentHanlder = commentHanlder;
            
        }

       
       

        public ActionResult Index()
        {

            
            
            Log.Information($"Load controller Home/index{ Environment.NewLine}");
            var movies = _unitOfWork.torrentMove.Where(x => x.commentIndex > 120).OrderByDescending(x => x.commentIndex).AsQueryable();

            return View(movies);
            
        }

        

        public IActionResult SearchFromTitle(string SerchText)
        {
            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(SerchText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.title.Contains(SerchText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromGenre(string GenreText)
        {
            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(GenreText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.genre.Contains(GenreText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromCountry(string CountryText)
        {
            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(CountryText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.country.Contains(CountryText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromEarOfIssue(string EarOfIssueText)
        {
            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(EarOfIssueText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.earOfIssue.Contains(EarOfIssueText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromVideoQuality(string VideoQualityText)
        {
            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(VideoQualityText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.videoQuality.Contains(VideoQualityText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromSize(string SizeText)
        {
            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(SizeText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.size.Contains(SizeText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromIndex(string indexText)
        {
            int index = Convert.ToInt32(indexText);
            IQueryable<TorrentMovie> movies = null;
            movies = _unitOfWork.torrentMove.Where(x => x.commentIndex > index).OrderByDescending(x => x.commentIndex).AsQueryable();
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromDownloads(string DownloadsText)
        {

            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(DownloadsText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.downloads.Contains(DownloadsText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
        }

        public IActionResult SearhFromPathDowLoad(string PathDowLoadText)
        {
            IQueryable<TorrentMovie> movies = null;
            if (!String.IsNullOrEmpty(PathDowLoadText))
            {
                movies = _unitOfWork.torrentMove.AsQueryable();
                movies = movies.Where(s => s.pathDownLoad.Contains(PathDowLoadText)).OrderByDescending(x => x.commentIndex).AsQueryable();
            }
            return PartialView("MoviesContainer", movies);
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
