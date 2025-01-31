using AM.ApplicationCore.Domain;

//Plane plane1 = new Plane();
//plane1.Capacity = 100;
//plane1.ManufactureDate = new DateTime(2024, 05, 23);
//plane1.PlaneId = 1;
//plane1.PlaneType = PlaneType.Boeing;
//Console.WriteLine(plane1.ToString());
//Plane plane2 = new Plane(PlaneType.Airbus, 200, DateTime.Now);
//Console.WriteLine(plane2.ToString());

Plane plane3 = new Plane
{
    Capacity = 300,
    ManufactureDate = DateTime.Now,
    PlaneId = 3,
    PlaneType = PlaneType.Airbus
};
Plane plane4 = new Plane { };
Console.WriteLine(plane3.ToString());
Console.WriteLine(plane4.ToString());

Passenger passenger = new Passenger
{
    FirstName = "Seif",
    LastName = "Znati",
    EmailAddress = "seifeddine.znati@esprit.tn"
};
Console.WriteLine(passenger.ToString());
Console.WriteLine(passenger.CheckProfile("Seif", "Znati"));
Console.WriteLine(passenger.CheckProfile("Ons", "Znati"));
Console.WriteLine(passenger.CheckProfile("Seif", "Znati","seifeddine.znati@esprit.tn"));
Console.WriteLine(passenger.CheckProfile("Seif", "Znati", "znatiseif@gmail.com"));
passenger.PassengerType();
Staff staff = new Staff {
    FirstName = "StaffFName",
    LastName = "StaffLN"
};
Traveller traveller = new Traveller {
    Nationality = "Tunisian",
    FirstName = "FNTraveller"
};
staff.PassengerType();
traveller.PassengerType();