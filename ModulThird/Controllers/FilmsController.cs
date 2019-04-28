using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModulThird.BusinessLogic;
using ModulThird.Models;

namespace ModulThird.Controllers
{
    [Route("api/films")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly GetFilmsInfoRequestHandler _getFilmsInfoRequestHandler;
        private readonly AppendFilmsRequestHandler _appendFilmsRequestHandler;

        public FilmsController(GetFilmsInfoRequestHandler getFilmsInfoRequestHandler, AppendFilmsRequestHandler appendFilmsRequestHandler)
        {
            _getFilmsInfoRequestHandler = getFilmsInfoRequestHandler;
            _appendFilmsRequestHandler = appendFilmsRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<Film> GetUserInfo(Guid id)
        {
            return _getFilmsInfoRequestHandler.Handle(id);
        }

        [HttpPost("append")]
        public Task<Film> PostData(Film film)
        {
            Guid id = Guid.NewGuid();   
            film.Id = id;
            _appendFilmsRequestHandler.Handle(film);
            return Task.FromResult<Film>(film);
        }

    }
}