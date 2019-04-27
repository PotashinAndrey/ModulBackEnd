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
    [Route("api/spoilers")]
    [ApiController]
    public class SpoilersController : ControllerBase
    {
        private readonly GetSpoilersInfoRequestHandler _getSpoilersInfoRequestHandler;

        public SpoilersController(GetSpoilersInfoRequestHandler getSpoilersInfoRequestHandler)
        {
            _getSpoilersInfoRequestHandler = getSpoilersInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<Spoiler> GetUserInfo(Guid id)
        {
            return _getSpoilersInfoRequestHandler.Handle(id);
        }
    }
}