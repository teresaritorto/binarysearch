using System;
using System.Linq;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            do
            {

                int arrayCount = CaptureInput("Enter number of items in the array:");
                var array = Enumerable.Range(0, arrayCount).ToArray();
                int searchItem = CaptureInput("Enter search item:");                
                var index = array.BinarySearch(searchItem);

                if (index == -1)
                {
                    Console.WriteLine("The item is was not found.");
                }
                else
                {
                    Console.WriteLine("The item is found at index {0}", index);
                }

                Console.WriteLine("");
                Console.WriteLine("Try again? Press y to continue or any other key to quit....");
                input = Console.ReadLine();
                Console.WriteLine();

            } while (input != null && input.ToLower() == "y");

        }

         private static int CaptureInput(string msg) 
         { 
             int output; 
             string input; 
             do 
             { 
                 Console.WriteLine(msg); 
                 input = Console.ReadLine(); 
             } while (!int.TryParse(input, out output));  
 
             return output; 
         } 
    }
}
