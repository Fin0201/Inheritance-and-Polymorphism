using Inheritance_and_Polymorphism;

Car car = new Car(1, 2, "Purple", "Citreon", "DS3", true);
Motorbike motorbike = new Motorbike(1, 2, "Purple", "Citreon", "DS3");

Console.WriteLine(car);
Console.WriteLine(motorbike);

List<Vehicle> Cars = new List<Vehicle>();

Cars.Add(car);

Cars.Add(motorbike);