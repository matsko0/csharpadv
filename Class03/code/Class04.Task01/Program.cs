/* Task 1
Create class PrintInConsole that will have multiple methods to print in console. 
Print(), PrintCollection(). Make this methods to be valid for more that one type and reuse the implenetation 
(hint: make them generic);
*/

using Class04.Task01.Models;

var printer = new PrintInConsole();
printer.Print("Test test 123");
printer.Print(123);
printer.Print(3.14);

List<string> names = new List<string> { "Petko", "Cvetko", "Bob" };
printer.PrintCollection(names);

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
printer.PrintCollection(numbers);