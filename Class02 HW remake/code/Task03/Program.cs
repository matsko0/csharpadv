using Task03.Domain.Models;

/* Task 3:
Write a program to create an abstract class Shape with abstract methods CalculateArea() and CalculatePerimeter(). 
Create subclasses Circle and Triangle that extend the Shape class and implement the respective methods to calculate the area and perimeter of each shape. */

Shape circle = new Circle(5.0);
Console.WriteLine("Circle Area: " + circle.CalculateArea());
Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());

Shape triangleTask3 = new Triangle(3.0, 4.0, 5.0);
Console.WriteLine("Triangle Area: " + triangleTask3.CalculateArea());
Console.WriteLine("Triangle Perimeter: " + triangleTask3.CalculatePerimeter());