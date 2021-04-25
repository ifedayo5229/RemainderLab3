using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
         {
            Console.WriteLine("Please Input the first number");
            var entry1 = Console.ReadLine();

            Console.WriteLine("Please Input the Second number");
            var entry2 = Console.ReadLine();

            Remainder(entry1, entry2);
        }
        public static void Remainder(string num1, string num2)
        {
            
            try
            {
                var number1 = Convert.ToInt32(num1);
                var number2 = Convert.ToInt32(num2);
                var result = number1 % number2;
                Console.WriteLine(" The remainder of " +number1+ " divided " + number2 + " is " +result);
            }
            catch
            {
                Console.WriteLine("The value you passed in was not able to process. Please provide another number");
            }

          

        


        }
    }
}
