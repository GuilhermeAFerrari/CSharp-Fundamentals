using System.Globalization;
using VehicleRentInheritance.Entities;
using VehicleRentInheritance.Services;

Console.WriteLine("Enter rental data");

Console.Write("Car model: ");
string model = Console.ReadLine();

Console.Write("Pickup (dd/mm/yyyy): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Return (dd/mm/yyyy): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService(2));

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE:");
Console.Write(carRental.Invoice);