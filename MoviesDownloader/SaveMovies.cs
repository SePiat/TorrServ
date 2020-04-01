using HtmlAgilityPack;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TorrServCore;
using TorrServData.Models;

namespace MoviesDownloader
{
    public class SaveMovies : ISaveMovies
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMoviesGetterService<TorrentMovie> _moviesGetterService;
        
        public SaveMovies(IUnitOfWork unitOfWork, IMoviesGetterService<TorrentMovie> moviesGetterService)
        {
            _unitOfWork = unitOfWork;
            _moviesGetterService = moviesGetterService;
        }

        public async Task<bool> SaveMov()
        {
            try
            {
                _unitOfWork.torrentMove.AddRange(_moviesGetterService.GetMovies());
                _unitOfWork.Save();
                Log.Information($"(MoviesDownloader.SaveMovies.SaveMov){Environment.NewLine}  New movies have been uploaded and saved to DB  at {DateTime.Now}{Environment.NewLine}");
                return true;                
            }
            catch (Exception ex)
            {
                Log.Error($"(MoviesDownloader.SaveMovies.SaveMov){Environment.NewLine}Get and Save movies was fail with exception:at {DateTime.Now}{Environment.NewLine}{ex.Message}");
                return false;
            }
        }
    }
}