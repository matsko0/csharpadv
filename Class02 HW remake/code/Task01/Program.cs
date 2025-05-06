using Task01.Domain.Interfaces;
using Task01.Domain.Models;

/* Task 1
Write a program to create an interface Searchable with a method Search(string word) 
that searches for a given keyword in a text document. Create two classes Document and 
WebPage that implement the Searchable interface and provide their own implementations of the Search() method.*/

ISearchable doc = new Document("This is a Csharp tutorial.");
ISearchable page = new WebPage("Learn C# programming online with Qinshift.");

Console.WriteLine($"Searching C# in Document: {doc.Search("C#")}");
Console.WriteLine($"Searching 'programming' in Document: {page.Search("programming")}");