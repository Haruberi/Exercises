﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Write a program in C# Sharp to
            store elements in an array and print it.
            Test Data:
            Input 10 elements in the array:
            element - 0 : 1
            element - 1 : 1
            element - 2 : 2
.......
            Expected Output :
            Elements in array are: 1 1 2 3 4 5 6 7 8 9
             */

            int[] numbers = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Elements in Array are: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }

            Console.WriteLine();
            /*
             2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Test Data :
            Input the number of elements to store in the array :3
            Input 3 number of elements in the array :
            element - 0 : 2
            element - 1 : 5
            element - 2 : 7
            Expected Output:
            The values store into the array are:
            2 5 7
            The values store into the array in reverse are :
            7 5 2*/

            var threeElements = new int[3] { 2, 5, 7 };
            int[] reversedElements = threeElements;
            Console.Write("The values store into the array are: ");
            Console.WriteLine();
            foreach (var i in threeElements)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Array.Reverse(reversedElements);
            Console.Write("The values store into the array in reverse are: ");
            Console.WriteLine();
            foreach (int i in reversedElements)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            /*
             3. Write a program in C# Sharp to find the 
            sum of all elements of the array.
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 2
            element - 1 : 5
            element - 2 : 8
            Expected Output :
            Sum of all elements stored in the array is : 15
             */
            var sumOfElements = new int[3] { 2, 5, 8 };
            int sum = sumOfElements.Sum();
            Console.Write("Sum of all elements stored in the array is: {0}", sum);

            Console.WriteLine();

            /*
             4. Write a program in C# Sharp to print all 
            unique elements in an array.
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 1
            element - 1 : 5
            element - 2 : 1
            Expected Output :
            The unique elements found in the array are : 5
             */

            int[] uniqueNumbers = { 1, 5, 1 };
            int[] distinctNumbers = uniqueNumbers.Distinct().ToArray();
            Array.ForEach(distinctNumbers, v => Console.WriteLine(v));

            Console.WriteLine();

            /*
             5. Write a program in C# Sharp to count the
            frequency of each element of an array.
                Test Data :
                Input the number of elements to be stored in the array :3
                Input 3 elements in the array :
                element - 0 : 25
                element - 1 : 12
                element - 2 : 43
                Expected Output :
                Frequency of all elements of array :
                25 occurs 1 times
                12 occurs 1 times
                43 occurs 1 times
             */

            int[] freequencyNumbers = { 25, 12, 43 };

            foreach(var item in freequencyNumbers.GroupBy(x => x))
            {
                Console.WriteLine($"{item.Key} occurs {item.Count()} times");
            }
            Console.WriteLine();

            /*
             6. Write a program in C# Sharp to find maximum
            and minimum element in an array.
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 45
            element - 1 : 25
            element - 2 : 21
            Expected Output :
            Maximum element is : 45
            Minimum element is : 21
             */

            int[] maximumMinimumNumbers = { 45, 25, 21 };
            Console.WriteLine("Maximum element is: " + maximumMinimumNumbers.Max());
            Console.WriteLine("Minimum element is: " + maximumMinimumNumbers.Min());

            Console.WriteLine();
        }
    }
}


    
    

        
    
