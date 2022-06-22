using System;
using System.Collections.Generic;
using System.Text;

namespace MongoRespository.MongoDomain
{
    public class UserMgEntity : BaseMgEntity
    {
        public new static string CollectionName { get; } = "User";
        public string UserName { get; set; }
    }
}
