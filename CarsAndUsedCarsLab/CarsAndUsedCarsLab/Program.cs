using CarsAndUsedCarsLab;

Car cars = new Car();

Car objectCarOne = new Car("Nikolai", "Model S", 2017, (decimal)54999.90);
Car objectCarTwo = new Car("Ford", "Escapade", 2017, (decimal)31999.90);
Car objectCarThree = new Car("Chewie", "Vette", 2017, (decimal)44989.95);
UsedCar objectCarFour = new UsedCar("Hyonda", "Prior", 2015, (decimal)14795.50, 35987.6);
UsedCar objectCarFive = new UsedCar("GC", "Chirpus", 2013, (decimal)8500.00, 12345.0);
UsedCar objectCarSix = new UsedCar("GC", "Witherell", 2016, (decimal)14450.00, 3500.3);

cars.listOfCars.Add(objectCarOne);
cars.listOfCars.Add(objectCarTwo);
cars.listOfCars.Add(objectCarThree);
cars.listOfCars.Add(objectCarFour);
cars.listOfCars.Add(objectCarFive);
cars.listOfCars.Add(objectCarSix);

Console.WriteLine("Welcome to Grant Chirpus Used Car Emporium!");

Console.WriteLine();

cars.ListCars();

Console.WriteLine();

Console.WriteLine("Which car would you like?");
int carIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You chose the following car: {cars.listOfCars[carIndex - 1]}");

Console.WriteLine();

cars.Remove(carIndex);

Console.WriteLine("Remaining cars are the following");
cars.ListCars();

Console.WriteLine("Goodbye!");