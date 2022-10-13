using System.Linq.Expressions;
using System.Linq;
using Calculator.App;
namespace InitialTraining.Calculator.App
{
    static class Program
    {
        static void Main(string[] args)
        {
            string[] ValidOperators = { "add", "subtract", "multiply", "divide" };
            Console.WriteLine("Please enter operation followed by two numbers.");

            string[] response = Console.ReadLine().Split(" ");

            int num1;
            int num2;

            if (!int.TryParse(response[1], out num1) || !int.TryParse(response[2], out num2) || !ValidOperators.Contains(response[0]))
            {
                Console.WriteLine("Invalid entry.");
                return;
            }

            Calculate calculate = new Calculate();

            switch (response[0])
            {
                case "add":
                    Console.WriteLine(calculate.Add(num1, num2));
                    break;
                case "subtract":
                    Console.WriteLine(calculate.Subtract(num1, num2));
                    break;
                case "multiply":
                    Console.WriteLine(calculate.Multiply(num1, num2));
                    break;
                case "divide":
                    if (num1 != 0 && num2 != 0)
                    {
                        Console.WriteLine(calculate.Divide(num1, num2));
                        break;
                    }
                    Console.WriteLine("Please enter a number greater than zero.");
                    break;
            }
        }
    }
}