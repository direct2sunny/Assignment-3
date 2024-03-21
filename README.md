**Objective**

The objective of designing and implementing a Vehicle Rental Management System with an object-oriented approach serves multiple educational and practical purposes. By working on this project, you will gain hands-on experience with key object-oriented programming (OOP) principles such as inheritance, abstraction, and encapsulation, which are fundamental to developing well-structured, reusable, and scalable software.

**Vehicle Class**

The Vehicle class presented in your code is an abstract class designed to model the essential characteristics and behaviors of a vehicle within the context of a rental system. Being an abstract class means it cannot be instantiated on its own but can serve as a base class for more specific types of vehicles (such as cars, bikes, or trucks). Here are the key components and their purposes:

**(A) Field:** The class has four private fields: model (vehicle model), manufacturer (vehicle maker), year (manufacture year), and rentalPrice (rental cost).

**(B) Properties:** Each private field has a public property (Model, Manufacturer, Year, RentalPrice) with get and set accessors, enabling controlled access and encapsulation.

**(C) Constructor:** The constructor initializes a Vehicle instance with specified values for model, manufacturer, year, and rental price, ensuring complete information upon creation.

**(D) Method:** DisplayDetails() is a virtual method that prints vehicle details and can be overridden for customized behavior in derived classes.

**Car Class**

The Car class extends the Vehicle base class, adding properties relevant to cars such as Seats, EngineType, Transmission, and Convertible. Its constructor initializes both inherited and car-specific properties. It overrides the DisplayDetails() method to display vehicle details alongside car-specific attributes, demonstrating enhanced functionality and polymorphism.

**Truck Class**

The provided C# code defines a Truck class that inherits from a Vehicle class, adding truck-specific properties such as Capacity, TruckType, and FourWheelDrive. It includes a constructor that initializes these properties along with those inherited from Vehicle. The DisplayDetails method is overridden to include truck-specific details when displaying the vehicle's information. This implementation demonstrates key object-oriented programming concepts like inheritance, polymorphism, and encapsulation.

**Motorcycle Class**

The provided C# code defines a Motorcycle class as a subclass of Vehicle, adding motorcycle-specific properties: EngineCapacity, FuelType, and HasFairing. The constructor initializes these properties alongside inherited ones. The DisplayDetails method extends the base functionality to include motorcycle-specific details like engine capacity, fuel type, and fairing presence, showcasing polymorphism by overriding the base class's method.
