namespace Act1Num4;
class Program
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            Console.WriteLine("User is a Minor");
        }
        else
        {
            Console.WriteLine("");
        }
    }
}

