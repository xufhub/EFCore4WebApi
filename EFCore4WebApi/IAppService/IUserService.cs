﻿using AppDenpendency;
using AppRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore4WebApi
{
    public interface IUserService: IAppDenpendency
    {
        public UserEntity GetUserById(int id);
    }
}
