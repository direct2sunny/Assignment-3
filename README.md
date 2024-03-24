**Objective**

The objective of designing and implementing a Vehicle Rental Management System with an object-oriented approach serves multiple educational and practical purposes. By working on this project, you will gain hands-on experience with key object-oriented programming (OOP) principles such as inheritance, abstraction, and encapsulation, which are fundamental to developing well-structured, reusable, and scalable software.

**Demonstrate the functionality of the classes**

This C# code snippet is designed for a simple vehicle rental agency system. It outlines the creation and management of a fleet of vehicles, including cars, trucks, and motorcycles. Let's break down the components and functionalities of the program:

**RentalAgency Class:**

This class is assumed to manage a collection of vehicles (such as cars, trucks, and motorcycles) available for rent. It likely contains methods for adding vehicles to the agency's fleet, renting out vehicles, and displaying the current fleet. It also tracks the total revenue generated from renting vehicles.

**Vehicle Classes (Car, Truck, Motorcycle)**

These classes represent different types of vehicles available for rent. Each class contains specific properties relevant to its type:

**Car Class**

The Car class extends the Vehicle base class, adding properties relevant to cars such as Seats, EngineType, Transmission, and Convertible. Its constructor initializes both inherited and car-specific properties. It overrides the DisplayDetails() method to display vehicle details alongside car-specific attributes, demonstrating enhanced functionality and polymorphism.


**Truck Class**

The provided C# code defines a Truck class that inherits from a Vehicle class, adding truck-specific properties such as Capacity, TruckType, and FourWheelDrive. It includes a constructor that initializes these properties along with those inherited from Vehicle. The DisplayDetails method is overridden to include truck-specific details when displaying the vehicle's information. This implementation demonstrates key object-oriented programming concepts like inheritance, polymorphism, and encapsulation.

**Motorcycle Class**

The provided C# code defines a Motorcycle class as a subclass of Vehicle, adding motorcycle-specific properties: EngineCapacity, FuelType, and HasFairing. The constructor initializes these properties alongside inherited ones. The DisplayDetails method extends the base functionality to include motorcycle-specific details like engine capacity, fuel type, and fairing presence, showcasing polymorphism by overriding the base class's method.

**Main Method Workflow:**

Instantiates a RentalAgency object.
Creates one of each vehicle type (Car, Truck, Motorcycle) with specific attributes.
Adds these vehicles to the rental agency's fleet using the AddVehicle method.
Calls the DisplayFleet method to list all vehicles currently available for rent.
Rents out the Car object to a customer, which involves removing it from the available fleet and adding its rental price to the total revenue.
Prints the total revenue generated from the vehicle rentals to the console.
The main focus of this code snippet is to demonstrate basic object-oriented programming concepts such as class inheritance (assuming Car, Truck, and Motorcycle inherit from a common Vehicle class), encapsulation, and polymorphism. It shows how to manage a collection of objects (vehicles) through various operations like adding to a list, iterating over a list to display details, and modifying object properties (e.g., marking a vehicle as rented and updating revenue).


**Screenshot**

![Screenshot (10)](https://github.com/direct2sunny/Assignment-3/assets/156108180/6dccb609-07f7-4c58-9b9a-a9a619fe2a7c)




