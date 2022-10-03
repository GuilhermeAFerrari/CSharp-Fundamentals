using CustomException.Entities;
using CustomException.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int roomNumber = int.Parse(Console.ReadLine());

    Console.Write("Check in date (dd/mm/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check out date (dd/mm/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());


    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
    Console.WriteLine("Reservation" + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");

    Console.Write("Check in date (dd/mm/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check out date (dd/mm/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);

    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException ex)
{
    Console.WriteLine("Error in reservation. " + ex.Message);
}
catch(FormatException ex)
{
    Console.WriteLine("Format error " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Unexpected error " + ex.Message);
}
