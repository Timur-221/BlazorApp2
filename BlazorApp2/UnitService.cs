using BlazorApp2.Data;

namespace BlazorApp4.Data
{
    public class UnitService
    {
        public List<Unit> Redactors = new List<Unit>();

        public List<Unit> GetUnits()
        {
            return Redactors;
        }

        //public List<Unit> SetUnits()
        //{
        //    Redactors = MongoDB.GetUnits;
        //}
    }
}
