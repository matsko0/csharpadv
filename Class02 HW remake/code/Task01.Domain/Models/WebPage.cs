using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public class WebPage : ISearchable
    {
        public string HtmlContent { get; set; }

        public WebPage(string htmlContent)
        {
            HtmlContent = htmlContent;
        }
        public bool Search(string word)
        {
            return HtmlContent.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
