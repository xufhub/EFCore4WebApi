using System;
using System.Collections.Generic;
using System.Text;
using Common;
using MongoDB.Driver;

namespace MongoRespository
{
    public class AppMongoDbContext : IAppMongoDbContext
    {
        public MongoClient AppMongoClient { get; set; }
        public IMongoDatabase AppMongoDatabase { get; set; }

        private static string _Constr;
        private static string ConStr
        {
            get
            {
                if (string.IsNullOrEmpty(_Constr))
                {
                    _Constr = AppSetting.Configuration["Db:Mongo:ConnectionString"];
                }
                return _Constr;
            }
        }

        private static string _DbName;
        private static string DbName
        {
            get
            {
                if (string.IsNullOrEmpty(_DbName))
                {
                    _DbName = AppSetting.Configuration["Db:Mongo:DbName"];
                }
                return _DbName;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public AppMongoDbContext()
        {
            AppMongoClient = new MongoClient(ConStr);
            if (AppMongoClient != null)
            {
                AppMongoDatabase = AppMongoClient.GetDatabase(DbName);
            }
        }
    }
}
