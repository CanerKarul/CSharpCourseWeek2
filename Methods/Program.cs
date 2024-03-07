using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20, 30);
            Console.WriteLine(result);

            Console.WriteLine(Add3(1,2,3,4,5,6));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
            
            // return number1 + number2;
        }

        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
