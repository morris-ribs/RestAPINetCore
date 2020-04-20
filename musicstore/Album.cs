using System;
using Newtonsoft.Json;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Musicstore
{
    public class Album
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        [JsonProperty("id")]
        public string Id { get; set; }

        [BsonElement("title")]
        [JsonProperty("title")]
        public string Title { get; set; }

        [BsonElement("artist")]
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [BsonElement("year")]        
        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
