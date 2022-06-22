using MongoDB.Bson;
using MongoDB.Driver;
using MongoRespository.IMongoRespository;
using MongoRespository.MongoDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoRespository.MongoRespository
{
    public class UserMongoRepository : BaseMongoRepository<UserMgEntity>, IUserMongoRepository
    {
        public UserMongoRepository(IAppMongoDbContext appMongoDbContext) : base(appMongoDbContext)
        {

        }

        public async Task<UserMgEntity> GetByUserName(string uname)
        {
            return await _collection.FindSync(a => a.UserName == uname).FirstOrDefaultAsync();
        }
    }
}
