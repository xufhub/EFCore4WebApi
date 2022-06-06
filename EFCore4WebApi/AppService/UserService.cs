using AppRespository;
using AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore4WebApi
{
    public class UserService : IUserService
    {
        readonly IUserRespositoryService _userRespositoryService;
        public UserService(IUserRespositoryService userRespositoryService)
        {
            _userRespositoryService = userRespositoryService;
        }
        public UserEntity GetUserById(int id)
        {
           return _userRespositoryService.GetUserById(id);
        }
    }
}
