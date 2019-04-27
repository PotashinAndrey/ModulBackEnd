using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Services;
using ModulThird.Models;

namespace ModulThird.BusinessLogic
{
    public class GetSpoilersInfoRequestHandler
    {
        private readonly ISpoilerInfoService _spoilerInfoService;

        public GetSpoilersInfoRequestHandler(ISpoilerInfoService spoilerInfoService)
        {
            _spoilerInfoService = spoilerInfoService;
        }

        public Task<Spoiler> Handle(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор филма", nameof(id));
            }

            return _spoilerInfoService.GetById(id);
        }
    }
}
