using Task01.Interface;

namespace Task01.Models
{
    public static class SearchHelper
    {
        public static List<T> Search<T>(List<T> list, int? id = null, string name = null, int? age = null)
            where T : ISearchable
        {
            return list.Where(item =>
            (!id.HasValue || item.Id == id.Value) &&
            (string.IsNullOrEmpty(name) || item.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
            (!age.HasValue || item.Age == age.Value)
        ).ToList();
        }
    }
}
