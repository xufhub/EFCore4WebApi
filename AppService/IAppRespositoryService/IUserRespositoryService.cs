using AppRespository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService
{
    public interface IUserRespositoryService
    {
        public UserEntity GetUserById(int id);
    }
}
