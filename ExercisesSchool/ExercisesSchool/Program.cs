using System;

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

            /*int[] numbers = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }*/

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
            foreach(var i in threeElements)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Array.Reverse(reversedElements);
            Console.Write("The values store into the array in reverse are: ");
            Console.WriteLine();
            foreach(int i in reversedElements)
            {
                Console.Write(" " + i);
            }
            }
        }
    }

        
    
