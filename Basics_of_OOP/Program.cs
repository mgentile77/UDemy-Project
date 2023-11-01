
using System.Drawing;

var rectangle1 = new Rectangle(5,10);

Console.WriteLine("Width is:" + rectangle1.Width);
Console.WriteLine("Height is:" + rectangle1.Height);
Console.WriteLine("Circumference is: " + rectangle1.CalculateCircumference());
Console.WriteLine("Area is: " + rectangle1.CalculateArea());
Console.WriteLine();
Console.WriteLine();
var rectangle2 = new Rectangle(7, 5);

Console.WriteLine("Width is: " + rectangle2.Width);
Console.WriteLine("Height is: " + rectangle2.Height);
Console.WriteLine("Circumference is: " + rectangle2.CalculateCircumference());
Console.WriteLine("Area is: " + rectangle2.CalculateArea());

DateOnly bookDate = new DateOnly(2023, 11, 10);
var visitor = "Wilma Eastbrook";
var stay = 14;

var guest = new HotelBooking(visitor,bookDate,stay);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{guest.GuestName} will check in {guest.StartDate} and leave on {guest.EndDate}");


Console.ReadKey();



class Rectangle
{
    public int Width = 3;
    public int Height = 4;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int CalculateCircumference()
    {
        return 2 * Width + 2 * Height;
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
}



public class HotelBooking
{
    public string GuestName;
    public DateOnly StartDate;
    public DateOnly EndDate;

    public HotelBooking(string guestname, DateOnly startdate, int lengthOfStay)
    {
        GuestName = guestname;
        StartDate = startdate;
        EndDate = StartDate.AddDays(lengthOfStay);
    }
}

