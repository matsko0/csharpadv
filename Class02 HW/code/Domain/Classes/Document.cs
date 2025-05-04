using Domain.Interfaces;

namespace Domain.Classes
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
