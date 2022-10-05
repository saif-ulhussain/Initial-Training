using System;
namespace Calculator.App
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
    }
    public class Calculate : ICalculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            int result = 0;
            for (int i = 0; i < num2; i++)
            {
                result += num1;
            }
            return result;
        }

        public int Divide(int num1, int num2)
        {
            int result = 0;
            int number = num1;
            while (number >= 0)
            {
                if ((number - num2) >= 0)
                {
                    result++;
                    number -= num2;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}

