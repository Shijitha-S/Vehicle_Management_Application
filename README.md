The main objective of "Vehicle Rental Management System" is to design a C# program to manage a fleet of vehicles which are vailable for rent in a rental agency. 
I have utilizesd object-oriented principles such as inheritance, abstraction, and encapsulation to create a individula classes and demostrate the functionality in a main program.

The main Classes of this program is as fllows:

Vehicle:
Represents a any type vehicles (Car, Truck, Motorcycle) available for rent.
The properties of this class includes Model, Manufacturer, Year, and RentalPrice.
I have implmented get and set methods for the vehicle's properties.
Also includes a method named DisplayDetails() to display the vehicle's details.

Car:
Inherits from the Vehicle class.
Included additional properties which are specific for cars, such as Seats, EngineType, Transmission, and Convertible.
Overrides the DisplayDetails() method to display both common vehicle properties and car-specific properties.

Truck:
Inherits from the Vehicle class.
ncluded additional properties which are specific for trucks, such as Capacity, TruckType, and FourWheelDrive.
Overrides the DisplayDetails() method to display both common vehicle properties and truck-specific properties.

Motorcycle:
Inherits from the Vehicle class.
Adds additional properties specific to motorcycles, such as EngineCapacity, FuelType, and HasFairing.
Overrides the DisplayDetails() method to display both common vehicle properties and motorcycle-specific properties.

RentalAgency:
Manages and handles the rental agency's fleet of vehicles.
Includes an array to store instances of vehicles.
Tracks the total revenue earned by the rental agency.
Additinal methods have been included to add vehicles to the fleet, remove vehicles from the fleet, and rent vehicles.

Functionality:

Adding Vehicles: The program allows adding vehicles of different types (Car, Truck, Motorcycle) to the rental agency's fleet.
Removing Vehicles: Vehicles will be removed from the fleet when they are no longer available to rent.
Renting Vehicles: This program designed to rent vehicles for a specified duration, also calculate the rental cost based on the rental price per day.
Displaying Vehicle Details: Each vehicle type has its own method to display its details, providing information about both common properties and type-specific properties.
Tracking Total Revenue: The rental agency keeps track of the total revenue earned from renting vehicles.

Main Program (Program.cs):
The Main method Program.cs demonstrates the functionality of the Vehicle Rental Management System by creating instances of vehicles, adding them to the rental agency's fleet,
and renting them for specific durations. 
It showcases how the classes interact to manage the rental operations effectively.
