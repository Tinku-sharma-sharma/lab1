using System;
using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Function for print any Array
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            //QUESTION 1
            //Imagine you are developing a basic calculator for a financial application.
            //You need to calculate the total sum of all the transactions recorded in a day.
            //Write a C# program to find the sum of all elements in an integer array using a loop.

            int[] transactions = { 200, -150, 340, 500, -100 };
            int sum = 0;
            for (int i = 0; i < transactions.Length; i++)
            {
                sum += transactions[i];
            }
            Console.WriteLine("Total sum of all transaction : " + sum);

            // QUESTION 2
            //You are working on an analytics tool that needs to find the average score of a class from a list of floating-point numbers.
            //Create a C# program that calculates the average of values in a floating-point array using a loop.

            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float total = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            float Average = total / scores.Length;
            Console.WriteLine("Average : " + Average);

            // QUESTION 3
            //Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.

            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int max = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] > max)
                {
                    max = prices[i];
                }
            }
            Console.WriteLine("Max Value : " + max);

            //QUESTION 4
            //Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.(Even for male and Odd for female)

            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int even = 0;
            int odd = 0;
            for (int i = 0; i < participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Total Male Person : " + even);
            Console.WriteLine("Toatl Female : " + odd);

            //QUESTION 5
            //Implement a C# program that reverses the elements of an integer array using a loop.

            int[] searchHistory = { 101, 202, 303, 404, 505 };
            Console.Write("Orginal Element : ");
            PrintArray(searchHistory);
            Console.Write("Reverse Element : ");
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.Write(searchHistory[i] + " ");
            }
            Console.WriteLine();

            //QUESTION 6
            //Create a C# program that multiplies each element in an integer array by a specified factor using a loop.

            int[] measurements = { 2, 4, 6, 8 };
            Console.Write("Before Multiplies by factor : ");
            PrintArray(measurements);
            int factor = 3;
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] *= factor;
            }
            Console.Write("After Multiplies by factor : ");
            PrintArray(measurements);

            //QUESTION 7
            //Write a C# program that searches for a specific value in an integer array using a loop and return its index if found.

            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            int idx(int[] arr, int num)
            {
                for (int i = 0; i < bookCodes.Length; i++)
                {
                    if (bookCodes[i] == searchCode)
                    {
                        return i;
                    }
                }
                return -1;
            }
            Console.WriteLine("Index of search element : " + idx(bookCodes, searchCode));

            //QUESTION 8
            //Develop a C# program that finds the second smallest element in an integer array using loops and sorting techniques.

            int[] grades = { 56, 78, 89, 45, 67 };
            for (int i = 0; i < grades.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < grades.Length; j++)
                {
                    if (grades[smallest] > grades[j])
                    {
                        smallest = j;
                    }
                }
                int temp = grades[smallest];
                grades[smallest] = grades[i];
                grades[i] = temp;
            }
            Console.WriteLine("Second smalles element :" + grades[1]);

            //QUESTION 9
            //Create a C# program that removes all duplicates from an integer array using loops and additional data structures.

            int[] ids = { 102, 215, 102, 324, 215 };
            List<int> list = new List<int>();
            for (int i = 0; i < ids.Length - 1; i++)
            {
                if (!list.Contains(ids[i]))
                {
                    list.Add(ids[i]);
                }
            }
            Console.Write("Unique data : ");
            foreach (int data in list)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();

            //QUESTION 10
            //Write a C# program that finds the common elements between two integer arrays using loops.

            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            List<int> l = new List<int>();
            for (int i = 0; i < dataset1.Length; i++)
            {
                for (int j = 0; j < dataset2.Length; j++)
                {
                    if (dataset1[i] == dataset2[j] && !l.Contains(dataset1[i]))
                    {
                        l.Add(dataset1[i]);
                        break;
                    }
                }
            }
            Console.Write("Comman Data : ");
            foreach (int data in l)
            {
                Console.Write(data + " ");
            }
        }
    }
}