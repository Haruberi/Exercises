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

            int[] numbers = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }
        }
    }
}
