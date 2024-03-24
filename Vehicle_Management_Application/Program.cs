using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car
        {
            Model = "Civic",
            Manufacturer = "Honda",
            Year = 2019,
            RentalPrice = 150.0,
            Seats = 5,
            EngineType = "V2",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Xenon",
            Manufacturer = "Tata",
            Year = 2021,
            RentalPrice = 250.0,
            Capacity = 2000,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Duke-390",
            Manufacturer = "KTM",
            Year = 2018,
            RentalPrice = 80.0,
            EngineCapacity = 390,
            FuelType = "Gasoline",
            HasFairing = false
        };

        RentalAgency rentalAgency = new RentalAgency(10);
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        rentalAgency.RentVehicle(car, 3);
        rentalAgency.RentVehicle(truck, 5);
        rentalAgency.RentVehicle(motorcycle, 2);
    }
}
