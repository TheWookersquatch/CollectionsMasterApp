
using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        private static void Populater(int[] numbers)
        {
          
          
            for (int i =0; i< numbers.Length; i++)
            {
                
                Random rng = new Random();
               int num = rng.Next(50);
                numbers[i] = num;
                
            }
               
        }
        private static void NumberPrinter(int[] array , List<int> list)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            while (array != null)
            {
                while (array != null)
                foreach (int num in array)
                {
                        
                    Console.WriteLine(num);
                } 
               
            }
            while (list != null)
            {
                foreach (int num in list)
                {
                    Console.WriteLine(num);
                }

            }
        }
        private static void ReverseCustom(int[] array)
        {
            int[] reverseArray1 = new int[array.Length];
            int value = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                
                reverseArray1[i] = array[value];
                value--;
            }
            foreach (int num in reverseArray1)
            {
                Console.WriteLine(num);
            }


        }
        private static void ThreeKiller(int[] numbers)
        {
           
            
                for (int i = 0; i < numbers.Length; i++)
                {
                   
                    if (numbers[i] % 3 == 0)
                    {
                        numbers[i] = 0;
                        Console.WriteLine(numbers[i]);
                    }
                    else
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
                
            
        }
        private static void ListPopulater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                
                Random rng = new Random();
                int num = rng.Next(50);
                numberList.Add(num);

            }
        }
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == searchNumber)
                {
                    Console.WriteLine($"{searchNumber} is in the list");
                    break;
                }
                else if (searchNumber < 0 || searchNumber > 50)
                {
                    Console.WriteLine("Please choose a number between 0 and 50");
                    searchNumber = int.Parse(Console.ReadLine());
                }
            }

        }
        private static List<int> OddKiller(List<int> numberList, List<int> evens)
        {
            
            for (int i = 0; i < numberList.Count; i++)
            {

                if (numberList[i] % 2 == 1)
                {
                    numberList.Remove(numberList[i]);
                }
                else
                {
                    evens.Add(numberList[i]);
                    Console.WriteLine(numberList[i]);
                }
            }
           

            return evens ;
            
        }
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
           

            int[] numbers = new int[50];

          
            Populater(numbers);

            Console.WriteLine("Random Number Generated Array");
           
            Console.WriteLine(numbers[0]);
                       
            Console.WriteLine(numbers[numbers.Length - 1]);
            Console.WriteLine("All Numbers Original");
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");
            

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------REVERSE CUSTOM------------");
            
            ReverseCustom(numbers);
           

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numberList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"Capacity of numberList is {numberList.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            ListPopulater(numberList);
            //Print the new capacity
            foreach (int num in numberList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int searchNumber = int.Parse(Console.ReadLine());
            NumberChecker(numberList, searchNumber);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            var evens = new List<int>();
            OddKiller(numberList, evens);
            
            Console.WriteLine("------------------");
            
            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            evens.Sort();
            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable

            var listToArray = evens.ToArray();
            //Clear the list
            numberList.Clear();
            evens.Clear();

            #endregion
        }

    
        

        

        
       

      

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
