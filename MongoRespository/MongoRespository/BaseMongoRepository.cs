using MongoDB.Driver;
using MongoRespository.MongoDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoRespository.MongoRespository
{
    public class BaseMongoRepository<TEntity> where TEntity : BaseMgEntity
    {
        protected readonly IAppMongoDbContext _appMongoDbContext;
        protected readonly IMongoCollection<TEntity> _collection;
        public BaseMongoRepository(IAppMongoDbContext appMongoDbContext)
        {
            _appMongoDbContext = appMongoDbContext;
            var collectionName = typeof(TEntity).GetProperty("CollectionName").GetValue(null).ToString();
            _collection = _appMongoDbContext.AppMongoDatabase.GetCollection<TEntity>(collectionName);
        }

    }
}
