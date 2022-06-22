using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoRespository
{
    public interface IAppMongoDbContext
    {
        public MongoClient AppMongoClient { get; set; }
        public IMongoDatabase AppMongoDatabase { get; set; }
    }
}
