using AppDenpendency;
using AppRespository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService
{
    public interface IUserRespositoryService: IAppDenpendency
    {
        public UserEntity GetUserById(int id);
    }
}
