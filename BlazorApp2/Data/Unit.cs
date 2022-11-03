using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace BlazorApp2.Data
{
    public class Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string name { get; set; }

        public int health { get; set; }
        public int damage { get; set; }
        public int armor { get; set; }
        public int mane { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelegence { get; set; }
        public int lvl { get; set; }
        public string skill { get; set; }
    }
}
