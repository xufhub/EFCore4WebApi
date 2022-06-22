using AppDenpendency;
using AppRespository;
using MongoRespository.MongoDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService
{
    public interface IUserService: IAppDenpendency
    {
        public UserEntity GetUserById(int id);
        public Task<UserMgEntity> GetUserByName(string uname);
        public Task BatchInsertUser();
        public Task BatchUpdateUser();
    }
}
