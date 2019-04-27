using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Models;


namespace ModulThird.Services
{
    public interface ISpoilerInfoService
    {
        Task<Spoiler> GetById(Guid id);
    }
}
