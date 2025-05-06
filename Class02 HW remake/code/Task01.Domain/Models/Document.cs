using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public class Document : ISearchable
    {
        public string Text { get; set; }

        public Document(string text)
        {
            Text = text;
        }
        public bool Search(string word)
        {
            return Text.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
