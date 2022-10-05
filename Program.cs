using System.Linq.Expressions;
using Calculator.App;
namespace InitialTraining.Calculator.App
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter operation followed by two numbers.");

            string[] response = Console.ReadLine().Split(" ");

            string operation = response[0];
            int num1 = Int32.Parse(response[1]);
            int num2 = Int32.Parse(response[2]);


            Calculate calculate = new Calculate();

            switch (operation)
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
                    Console.WriteLine(calculate.Divide(num1, num2));
                    break;
            }
        }
    }
}