using System;

public class RentalAgency
{
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
        TotalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == null)
            {
                Fleet[i] = vehicle;
                break;
            }
        }
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == vehicle)
            {
                Fleet[i] = null;
                break;
            }
        }
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (vehicle != null)
        {
            double rentalCost = vehicle.RentalPrice * days;
            TotalRevenue += rentalCost;
            Console.WriteLine($"Rented: {vehicle.Model}, Rental Price: {rentalCost}");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }
}
