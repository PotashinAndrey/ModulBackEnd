using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Services;
using ModulThird.Models;


namespace ModulThird.BusinessLogic
{
    public class AppendFilmsRequestHandler
    {
        private readonly IFilmAddToService _filmAddToService;

        public AppendFilmsRequestHandler(IFilmAddToService filmAddToService)
        {
            _filmAddToService = filmAddToService;
        }

        public void Handle(Film film)
        {
            _filmAddToService.SetFilm(film);
        }
    }
}
