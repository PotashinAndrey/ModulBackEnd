using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Models;

namespace ModulThird.Services
{
    /// <summary>
    /// Services
    /// </summary>
    public interface IUserInfoService
    {
        Task<User> GetById(Guid id);
    }

}
