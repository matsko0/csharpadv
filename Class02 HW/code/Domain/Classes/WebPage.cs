using Domain.Interfaces;

namespace Domain.Classes
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
