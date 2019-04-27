using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Services;
using ModulThird.Models;

namespace ModulThird.BusinessLogic
{
    public class GetFilmsInfoRequestHandler
    {
        private readonly IFilmInfoService _filmInfoService;

        public GetFilmsInfoRequestHandler(IFilmInfoService filmInfoService)
        {
            _filmInfoService = filmInfoService;
        }

        public Task<Film> Handle(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор филма", nameof(id));
            }

            return _filmInfoService.GetById(id);
        }
    }
}
