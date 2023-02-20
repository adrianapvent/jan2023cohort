// Vehicle honda = new Vehicle("Honda", 5, "Red", true);
// Vehicle chevy = new Vehicle("Chevy", "Black");

// Vehicle bug = new Vehicle("VW Bug", 4, "White", true);
// Vehicle jeep = new Vehicle("Jeep", "Blue");


// jeep.ShowInfo();

// jeep.Travel(10);

// bug.Travel(100);

// List<Vehicle> theVehicles = new List<Vehicle>();
// theVehicles.Add(jeep);
// theVehicles.Add(honda);
// theVehicles.Add(chevy);
// theVehicles.Add(bug);

// foreach(Vehicle item in theVehicles) {
//     item.ShowInfo();
// }

// Above comment code was for part 1 before interface (RideMake Assignment) below is after interface for FuelUP assignment.

Car sedan = new Car("Sedan", "White", "Gas");
sedan.ShowInfo();

sedan.GiveFuel(10);

Horse mrEd = new Horse("Mr Ed", "Brown", "Hay");
mrEd.ShowInfo();
mrEd.GiveFuel(2);