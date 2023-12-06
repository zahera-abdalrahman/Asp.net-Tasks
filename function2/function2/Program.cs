﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1
            DateTime date1 = new DateTime(2023, 6, 14);
            DateTime date2 = new DateTime(2023, 6, 20);

            int daysDifference = date(date1, date2);
            Console.WriteLine(Math.Abs(daysDifference));


            //Task2
            Console.WriteLine("Enter the size of the array: ");
            int numArray = Convert.ToInt32(Console.ReadLine());

            string[] arrayNumbers = new string[numArray];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbersInStrings(arrayNumbers)));

            //Task3
            Console.Write("Enter a string: ");
            string String = Console.ReadLine();

            string reversedString = reverseOdd(String);

            Console.WriteLine($"Reversed String: {reversedString}");

            //Task4
            Console.WriteLine(isPandigital(98140723568910)); // true
            Console.WriteLine(isPandigital(90864523148909)); // false
            Console.WriteLine(isPandigital(112233445566778899)); // false


        }

        static int date(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan difference = firstDate - secondDate;
            return difference.Days;
        }

        static string[] numbersInStrings(string[] inputArray)
        {
            List<string> result = new List<string>();

            foreach (string str in inputArray)
            {
                if (ContainsNumber(str))
                {
                    result.Add(str);
                }
            }

            return result.ToArray();
        }

        static bool ContainsNumber(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }

            return false;
        }

        public static string reverseOdd(string input)
        {
            string emptyString = "";
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] charArr = words[i].ToCharArray();
                    for (int j = charArr.Length - 1; j >= 0; j--)
                    {
                        emptyString += charArr[j];
                    }

                }
                else
                {
                    emptyString += words[i];
                }

                emptyString += " ";
            }
            return emptyString;
        }
        static bool isPandigital(long number)
        {
            string numberStr = number.ToString();

            bool[] digitPresence = new bool[10];

            foreach (char digitChar in numberStr)
            {
                int digit = digitChar - '0';

                if (digit >= 0 && digit <= 9)
                {
                    digitPresence[digit] = true;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (!digitPresence[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
