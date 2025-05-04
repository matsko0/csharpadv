using Domain.Classes;
using Domain.Interfaces;
/* Task 1
Write a program to create an interface Searchable with a method Search(string word) 
that searches for a given keyword in a text document. Create two classes Document and 
WebPage that implement the Searchable interface and provide their own implementations of the Search() method.*/

ISearchable doc = new Document("This is a C# tutorial.");
ISearchable page = new WebPage("<html><body>Learn C# programming online.</body></html>");

Console.WriteLine("Searching 'C#' in Document: " + doc.Search("C#"));
Console.WriteLine("Searching 'C#' in Document: " + page.Search("C#"));

/*Task 2
Write a program to create an interface Shape with the GetArea() method. 
Create three classes Rectangle, Circle, and Triangle that implement the Shape interface. 
Implement the GetArea() method for each of the three classes.*/

IShape rectangle = new Rectangle(5, 10);
IShape circle = new Circle(7);
IShape triangle = new Triangle(4, 8);

Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
Console.WriteLine("Circle Area: " + circle.GetArea());
Console.WriteLine("Triangle Area: " + triangle.GetArea());

/* Task 3:
Write a program to create an abstract class Shape with abstract methods CalculateArea() and CalculatePerimeter(). 
Create subclasses Circle and Triangle that extend the Shape class and implement the respective methods to calculate the area and perimeter of each shape. */

Shape circleTask3 = new CircleTask3(5.0);
Console.WriteLine("Circle Area: " + circleTask3.CalculateArea());
Console.WriteLine("Circle Perimeter: " + circleTask3.CalculatePerimeter());

Shape triangleTask3 = new TriangleTask3(3.0, 4.0, 5.0);
Console.WriteLine("Triangle Area: " + triangleTask3.CalculateArea());
Console.WriteLine("Triangle Perimeter: " + triangleTask3.CalculatePerimeter());

/* Task 4: 
 * Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo(). 
 * Create subclasses Manager and Programmer that extend the Employee class and implement the respective methods to calculate salary and display information for each role. */

Employee manager = new Manager("Jhonny", 101, 5000, 1200);
manager.DisplayInfo();


Employee programmer = new Programmer("Bob", 102, 50, 160);
programmer.DisplayInfo();