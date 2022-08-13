using System;
using System.Linq;

using var db = new CarContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new car");
db.Add(new Car { CarName = "Mazda" });
db.SaveChanges();

Console.WriteLine("Inserting a new car 6536532");
db.Add(new Car { CarName = "Mazda3399" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a Car");
var Car = db.Cars
    .OrderBy(b => b.CarId)
    .First();
Console.WriteLine(Car);

// Update
Console.WriteLine("Updating the Car and adding a Part");
Car.CarName = "https://devblogs.microsoft.com/dotnet";
Car.Parts.Add(
    new Part { Title = "Hello World", Content = "I wrote an app using EF Core!" });
db.SaveChanges();
