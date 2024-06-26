﻿using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Threes();
            var equal = IsEqual(1, 2);
            EvenOrOdd(5);
            var positive = IsPositive(-1);
            var isOfVotingAge = OfVotingAge(25);
            var isTenRange = IsTenRange(25);
            Display(5);
        }

        //Write a method that will print to the console all numbers 1000 through -1000.
         public static void PrintRange(int ceiling, int floor)
         {
            for (int i = ceiling; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

         }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static bool IsEqual(int a, int b)
        {
            //how do i determine if two numbers are the same?
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to check whether a given number is even or odd.

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"that's even");
            }
            else
            {
                Console.WriteLine($"definitely odd");
            }


        }
        //need to determine if its negative or positive
        public static bool IsPositive(int num1)
        {

            if (num1 > 0)
            {
                return true;
            }

            return false;

        }

        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes they are of voting age");
                return true;
            }
            else
            {
                Console.WriteLine($"Too young to vote by {18 - age} years");
                return false;
            }

        }
        //Write a method to check if an integer (from the user) is in the range -10 to 10
        public static bool IsTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }

            return false;
        }
        // Change this number to display multiplication table of a different integer
        public static void Display(int number)
        {
            DisplayMultiplicationTable(number);
        }

        public static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
      
    }
}
    

