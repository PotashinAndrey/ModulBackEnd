using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModulThird.Models;


namespace ModulThird.Services
{
    public interface IFilmAddToService
    {
        Task<IActionResult> SetFilm(Film film);
    }

}
