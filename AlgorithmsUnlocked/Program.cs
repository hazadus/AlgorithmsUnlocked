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
        static void Main(string[] args)
        {
            // Declare variables and constants
            int[] testArray = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            const int ValueToSearch = 8;
            int answer;

            // Start the program
            Console.WriteLine("Algorithms Unlocked.");
            
            // TEST LinearSearch
            answer = LinearSearch(testArray, testArray.Length, ValueToSearch);

            if (answer == (int)Errors.ValueNotFound)
            {
                Console.WriteLine("Error: value not found in array");
            }
            else if (answer == (int)Errors.OutOfRange)
            {
                Console.WriteLine("Error: out of range");
            }
            else
            {
                Console.WriteLine("Value " + ValueToSearch + " found at index: " + answer);
            }
        }
    }   
}