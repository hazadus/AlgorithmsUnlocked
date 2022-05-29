//
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

        static int[] CreateTestArray(int arraySize)
        {
            int[] testArray = new int[arraySize];
            Random rnd = new Random();

            for (int i = 0; i < arraySize; i++)
            {   
                testArray[i] = rnd.Next(11); // generate rnd int in 0...10 range
            }

            return testArray;
        }

        static void PrintArray(int[] arrayToPrint, string nameOfArray)
        {
            Console.Write(nameOfArray + ": ");
            foreach (var value in arrayToPrint)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n");
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
            // Declare constants
            const int TestArraySize = 64;
            const int ValuesToSearchCount = 5;

            // Start the program
            Console.WriteLine("* * * Algorithms Unlocked. Linear Search tests * * *");
            
            // TEST LinearSearch
            int[] testArray = CreateTestArray(TestArraySize);
            int[] valuesToSearch = CreateTestArray(ValuesToSearchCount);
            
            PrintArray(testArray, nameof(testArray));
            PrintArray(valuesToSearch, nameof(valuesToSearch));
            
            // track time
            for (int i = 0; i < valuesToSearch.Length; i++)
            {
                PrintSearchResult(LinearSearch(testArray, testArray.Length, valuesToSearch[i]), 
                    valuesToSearch[i]);
            }
            // print tracked time
        }
    }   
}