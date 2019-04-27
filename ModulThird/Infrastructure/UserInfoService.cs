using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Models;
using ModulThird.Services;

namespace ModulThird.Infrastructure
{
    /// <summary>
    /// Infrastructure
    /// </summary>
    public class UserInfoService : IUserInfoService
    {
        public async Task<User> GetById(Guid id)
        {
            User user = new User {
                Email = "asdf@asdfg.asdf",
                Id = id,
                Nickname = "qwe",
                Phone = "123123123"
            };
            return await Task.FromResult<User>(user);
        }
    }

}
