using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> fleet = new List<Vehicle>();
    private decimal totalRevenue;

    public decimal TotalRevenue { get => totalRevenue; private set => totalRevenue = value; }

    public void AddVehicle(Vehicle vehicle)
    {
        fleet.Add(vehicle);
    }

    public bool RemoveVehicle(Vehicle vehicle)
    {
        return fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle, decimal rentalPrice)
    {
        if (fleet.Contains(vehicle))
        {
            TotalRevenue += rentalPrice;
            RemoveVehicle(vehicle);
            Console.WriteLine($"{vehicle.GetType().Name} rented for {rentalPrice}");
        }
        else
        {
            Console.WriteLine("Vehicle not available.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine("---------------------");
        }
    }
}
