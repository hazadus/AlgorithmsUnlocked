﻿//
// "Algorithms Unlocked" book
//
// Algorithm implementations
//
// - Linear search (p.28)
//

namespace AlgorithmsUnlocked
{
    class Program
    {
        enum Errors
        {
            OutOfRange = -1,
            ValueNotFound = -2
        }
        
        static int LinearSearch(int[] array, int numberOfElements, int searchValue)
        {
            int answer;

            if (array.Length < numberOfElements)
            {
                answer = (int)Errors.OutOfRange;
            }
            else
            {
                answer = (int)Errors.ValueNotFound;
                
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (array[i] == searchValue) answer = i;
                }
            }
            
            return answer;
        }

        static void PrintSearchResult(int answer, int searchValue)
        {
            // Save current console color
            ConsoleColor lastColor = Console.ForegroundColor;
            
            if (answer == (int)Errors.ValueNotFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: value " + searchValue + " not found in array!");
            }
            else if (answer == (int)Errors.OutOfRange)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: out of range!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Value " + searchValue + " found at index: " + answer);
            }
            
            // Reset console color
            Console.ForegroundColor = lastColor;
        }
        
        static void Main(string[] args)
        {
            // Declare variables and constants
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] valuesToSearch = { 8, 10, 6 };
            int answer;

            // Start the program
            Console.WriteLine("Algorithms Unlocked. Linear Search tests:");
            
            // TEST LinearSearch
            for (int i = 0; i < valuesToSearch.Length; i++)
            {
                answer = LinearSearch(testArray, testArray.Length, valuesToSearch[i]);
                PrintSearchResult(answer, valuesToSearch[i]);
            }
        }
    }   
}