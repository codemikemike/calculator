﻿namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine(num1 + num2);
        

        Console.ReadLine();
    }
}