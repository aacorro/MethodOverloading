using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Add(5, 5));
            Console.WriteLine();
            Console.WriteLine(Add(5.25m, 10.25m));
            Console.WriteLine();
            Console.WriteLine(Add(2, 4, true));
            Console.WriteLine();
        }

        //Create a method named Add, that accepts two integers and returns the sum of those two integers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //Create an overload of the Add method to account for being able to add two decimals together
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //Create an overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        public static string Add(int num1, int num2, bool inputCheck) 
        {
            var sumTotal = num1 + num2;
            if(inputCheck == true && sumTotal > 1) 
            {
                return $"{sumTotal} dollars";
            }
            else if(inputCheck == true && sumTotal == 1)
            {
                return $"{sumTotal} dollar";
            }
            else if(inputCheck == true && sumTotal < 1)
            {
                return $"{sumTotal} dollars";
            }
            else
            {
                return sumTotal.ToString();
            }
        }


            
        }
    }


