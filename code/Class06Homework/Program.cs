using Class06Homework;
using Class06Homework.Domain;
using Class06Homework.Domain.Models;

////Filter all cars that have origin from Europe and print them in console.
Console.WriteLine("Filtering all cars that have origin from Europe and print them in console. \n Press enter to see output! ");
Console.ReadLine();
Console.WriteLine("Printing cars with Origin from Europe from the list:");
Thread.Sleep(2000);
Console.WriteLine($"Cars from Europe:");
List<Car> carsOriginEurope = CarsData.Cars.Where(car => car.Origin == "Europe").ToList();
carsOriginEurope.PrintSimple();


//Filter all cars that have more that 6 Cylinders not including 6 after that
//Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0.
//Join them in one result and print them in console.

Console.WriteLine("===========================================================================================");
Console.WriteLine("Filtering all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. \n Press enter to see output!...");
Console.ReadLine();
Console.WriteLine("Printing cars with more than 6 cylinders and cars with exactly 4 cylinders and HorsePower more than 110.0 from the list: ");
Thread.Sleep(3000);
List<Car> carsMoreThan6Cylinders = CarsData.Cars.Where(car => car.Cylinders > 6).ToList();
List<Car> carsExactly4Cylinders = CarsData.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110.0).ToList();
List<Car> carsCombined = carsMoreThan6Cylinders.Concat(carsExactly4Cylinders).ToList();
carsCombined.PrintSimple();


//Count all cars based on their Origin and print the result in console. Example outpur "US 10 models\n Eu 15 Models";
Console.WriteLine("===========================================================================================");
Console.WriteLine("Counting all cars based on their Origin and printing the result in console. \n Press enter to see output!...");
var carsGroupedByOrigin = CarsData.Cars.GroupBy(car => car.Origin)
    .Select(group => new { Origin = group.Key, Count = group.Count() })
    .ToList();
Console.ReadLine();
Thread.Sleep(2000);
carsGroupedByOrigin.ForEach(group => Console.WriteLine($"{group.Origin} {group.Count} models"));

//Filter all cars that have more then 200 HorsePower and Find out how much is the lowest,highes and average Miles per galon and print them in console;

Console.WriteLine("===========================================================================================");
Console.WriteLine("Filtering all cars that have more than 200 HorsePower and finding the lowest, highest and average Miles per galon: \n Press enter to see output!");
Console.ReadLine();
Thread.Sleep(3000);
List<Car> carsMoreThan200HorsePower = CarsData.Cars.Where(car => car.HorsePower > 200).ToList();
double lowestMilesPerGalon = carsMoreThan200HorsePower.Min(car => car.MilesPerGalon);
double highestMilesPerGalon = carsMoreThan200HorsePower.Max(car => car.MilesPerGalon);
double averageMilesPerGalon = carsMoreThan200HorsePower.Average(car => car.MilesPerGalon);
Console.WriteLine($"Lowest Miles per galon: {lowestMilesPerGalon}");
Console.WriteLine($"Highest Miles per galon: {highestMilesPerGalon}");
Console.WriteLine($"Average Miles per galon: {averageMilesPerGalon}");


//extra examples
//Filtering most efficient japanese cars
Console.WriteLine("===========================================================================================");
Console.WriteLine("Filtering most efficient Japanese cars by Descending order: \n Press enter to see output!");
Console.ReadLine();
Thread.Sleep(2000);
List<Car> efficientJapaneseCars = CarsData.Cars
    .Where(car => car.Origin == "Japan")
    .OrderByDescending(car => car.MilesPerGalon)
    .ToList();
efficientJapaneseCars.PrintSimple();


//Fastest Accelerating Cars (Lowest AccelerationTime)
Console.WriteLine("===========================================================================================");
Console.WriteLine("Filtering fastest accelerating cars (Lowest AccelerationTime): \n Press enter to see output!");
Console.ReadLine();
Thread.Sleep(2000);
List<Car> fastestAcceleratingCars = CarsData.Cars
    .OrderBy(car => car.AccelerationTime)
    .ToList();
Console.WriteLine("Fastest accelerating cars by Ascending order are:");
fastestAcceleratingCars.PrintSimple();


//Cars with missing horsepowr info
Console.WriteLine("===========================================================================================");
Console.WriteLine("Filtering cars with missing HorsePower info: \n Press enter to see output!");
Console.ReadLine();
Thread.Sleep(2000);
List<Car> carsWithMissingHorsePower = CarsData.Cars
    .Where(car => car.HorsePower == 0)
    .ToList();
Console.WriteLine("Cars with missing HorsePower info are:");
carsWithMissingHorsePower.PrintSimple();
