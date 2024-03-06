namespace Fizzbuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                switch (i)
                {
                    case int number when (number % 3 == 0 && number % 5 == 0):
                        Console.WriteLine("FizzBuzz");
                        break;
                    case int number when (number % 3 == 0):
                        Console.WriteLine("Fizz");
                        break;
                    case int number when (number % 5 == 0):
                        Console.WriteLine("Buzz");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }
    }
}
