using System;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will display the division tables of 1 to 12 bases on the number input");
            Console.WriteLine("Please input a number less than 50");
            var userChoice = double.Parse(Console.ReadLine());
            Console.WriteLine(userChoice);
            
            Console.WriteLine($"{userChoice} * 1 = {""}"); //Forgot how to display anwser
            

        }
    }
}
