using Task02.Domain.Models;

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