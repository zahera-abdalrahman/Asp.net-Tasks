﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(seconds(minutes) + " Seconds");

            //Task2
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(incrementNumber(number));

            //Task3
            Console.WriteLine("Enter number: ");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arrLength];
            Console.WriteLine(firstElementInArr(numbers));

            //Task4
            Console.WriteLine("Enter the base of the triangle: ");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle: ");
            double heightTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Triangle(baseTriangle, heightTriangle));


            //Task5

            Console.WriteLine("Enter number: ");
            int arrLength2 = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[arrLength2];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = evenNumberEvenIndex(nums);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }




            //Task6
            Console.WriteLine("Enter number: ");
            int stringLength = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[stringLength];
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Console.ReadLine();
            }
            string[] stringOdd = evenIndexOddLength(strings);

            foreach (var item in stringOdd)
            {
                Console.WriteLine(item);
            }


            //Task7
            Console.WriteLine("Enter number: ");
            int arrLength3 = Convert.ToInt32(Console.ReadLine());
            int[] numsPower = new int[arrLength3];
            for (int i = 0; i < numsPower.Length; i++)
            {
                numsPower[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result1 = powerElementIndex(numsPower);

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }


            //Task8
            Console.WriteLine("Enter number one:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberOne + "*" + numberTwo + "=" + multiplication2(numberOne, numberTwo));

            //9) Create a function called muti2
            //that take two parameter
            //and will return the multiplication
            //from the first number to the second number
            //Ex: muti2(4, 5); => 4 * 5 => 20
            //Ex: muti2(3, 6); => 3 * 4 * 5 * 6 => 360
            Console.WriteLine("Enter number one:");
            int One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int Two = Convert.ToInt32(Console.ReadLine());
            int finalResult = 1;
            finalResult = muti2(One, Two) * finalResult;
            finalResult=muti2(One, Two) * finalResult;
            Console.WriteLine(finalResult);


            //Task10
            Console.WriteLine("Enter number: ");
            int arrLength4 = Convert.ToInt32(Console.ReadLine());
            int[] avgArray = new int[arrLength4];
            for (int i = 0; i < avgArray.Length; i++)
            {
                avgArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(aveArray(avgArray));
        }

        static int seconds(int minutes)
        {
            return minutes * 60;
        }

        static int incrementNumber(int number)
        {
            return number+1;
        }
        static int firstElementInArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine("Enter a number in the array:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array[0];
        }
        static double Triangle(double baseTriangle,double heightTriangle)
        {
            return (baseTriangle * heightTriangle) / 2;
        }


        static int[] evenNumberEvenIndex(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result.Add(nums[i]);
                }
            }

            return result.ToArray();
        }


        static string[] evenIndexOddLength(string[] strings)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < strings.Length; i ++)
            {
                if (i %2==0 && strings[i].Length % 2 != 0)
                {
                    result.Add(strings[i]);
                }
            }

            return result.ToArray();
        }

        static int[] powerElementIndex(int[] numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int poweredValue = (int)Math.Pow(numbers[i], i);
                result.Add(poweredValue);
            }

            return result.ToArray();
        }

        static int multiplication2(int num1,int num2)
        {
            return num1 * num2;
        }
        static int muti2(int num1,int num2)
        {
            int result = num1*num2;
            return result;
        }
        static double aveArray(int[] array)
        {


            int sum = 0;
            double avg;
            foreach (int i in array)
            {
                sum+= i;
            }
            avg = sum/array.Length;
            return avg;
        }

    }
}
