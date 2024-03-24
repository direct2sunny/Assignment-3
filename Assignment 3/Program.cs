class Program
{
    static void Main(string[] args)
    {
        RentalAgency rentalAgency = new RentalAgency();

        Car car = new Car("Model S", "Tesla", 2020, 100m, 5, "Electric", "Automatic", true);
        Truck truck = new Truck("F-150", "Ford", 2019, 120m, 1.5, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2018, 80m, 650, "Petrol", true);

        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        rentalAgency.DisplayFleet();

        rentalAgency.RentVehicle(car, car.RentalPrice);

        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue}");
    }
}
