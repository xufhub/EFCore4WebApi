using AppDenpendency;
using MongoRespository.MongoDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoRespository.IMongoRespository
{
    public interface IUserMongoRepository: IAppDenpendency
    {
        public Task<UserMgEntity> GetByUserName(string uname);
    }
}
