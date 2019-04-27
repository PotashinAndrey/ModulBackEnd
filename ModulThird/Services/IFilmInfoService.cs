using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Models;


namespace ModulThird.Services
{
    public interface IFilmInfoService
    {
        Task<Film> GetById(Guid id);
    }
}
