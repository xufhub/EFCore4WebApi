using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// mongo bson attribute
/// https://mongodb.github.io/mongo-csharp-driver/2.5/apidocs/html/N_MongoDB_Bson_Serialization_Attributes.htm
/// </summary>
namespace MongoRespository.MongoDomain
{
    public abstract class BaseMgEntity
    {
        public static string CollectionName { get; } = "default";
        [BsonId]
        public string id { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime cts { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime uts { get; set; }
    }
}
