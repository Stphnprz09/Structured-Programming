namespace Assignment1;
class Program
{
    static void Main(string[] args)
    {

        string timeIn, timeOut;

        Console.WriteLine("Time in: ");
        timeIn = Console.ReadLine();
        Console.WriteLine("Time out: ");
        timeOut = Console.ReadLine();

        TimeSpan WorkedHrs = DateTime.Parse(timeOut).Subtract(DateTime.Parse(timeIn));

        Console.WriteLine("Time in: " + timeIn);
        Console.WriteLine("Time out: " + timeOut);
        Console.WriteLine("Worked Hours: " + WorkedHrs);

    }
}

