﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Services;
using ModulThird.Models;

namespace ModulThird.BusinessLogic
{
    public class GetUsersInfoRequestHandler
    {
        private readonly IUserInfoService _userInfoService;

        public GetUsersInfoRequestHandler(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public Task<User> Handle(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(id));
            }

            return _userInfoService.GetById(id);
        }
    }

}
