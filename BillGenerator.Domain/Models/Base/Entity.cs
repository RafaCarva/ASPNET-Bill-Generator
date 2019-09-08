using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BillGenerator.Domain.Models.Base
{
    public abstract class Entity : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
    }
}
