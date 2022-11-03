using MongoDB.Driver;

namespace BlazorApp2.Data
{
    public class MonDb
    {
        public static List<Unit> GetUnits()
        {
            List<Unit> units = new List<Unit>();
            var client = new MongoClient();
            var database = client.GetDatabase("Redactor");
            var collection = database.GetCollection<Unit>("Heroes");
            var list = collection.Find(x => true).ToList();
            foreach(var item in list)
            {
                units.Add(item);
            }
            return units;
        }
    }
}
