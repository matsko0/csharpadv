using Task04.Domain.Models;

/* Task 4: 
 * Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo(). 
 * Create subclasses Manager and Programmer that extend the Employee class and implement the respective methods to calculate salary and display information for each role. */

Employee manager = new Manager("Jhonny", 101, 5000, 1200);
manager.DisplayInfo();


Employee programmer = new Programmer("Bob", 102, 50, 160);
programmer.DisplayInfo();