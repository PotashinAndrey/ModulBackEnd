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

        public FilmsController(GetFilmsInfoRequestHandler getFilmsInfoRequestHandler)
        {
            _getFilmsInfoRequestHandler = getFilmsInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<Film> GetUserInfo(Guid id)
        {
            return _getFilmsInfoRequestHandler.Handle(id);
        }

    }
}