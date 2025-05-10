/* Task 1
Create class User that will have 3 properties Id, Name, Age. 
Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list). 
Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result. */

using System.Threading.Channels;
using Task01.Models;

Console.WriteLine("--------------call 1===================");
Console.WriteLine("Using the search method for Name");
UserDb.Search(name: "ko").ForEach(Console.WriteLine);

Console.WriteLine("------------------ call 2--------------------");
Console.WriteLine("Using the search method for Age:");
UserDb.Search(age: 24).ForEach(Console.WriteLine);

Console.WriteLine("------------------ call 3--------------------");
Console.WriteLine("Using the search method for Id:");
UserDb.Search(id: 3).ForEach(Console.WriteLine);
