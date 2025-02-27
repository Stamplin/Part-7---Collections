//import list
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
namespace Part_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1 - List on integers
            List<int> numbers = new List<int>();

            //number generator between 10 and 20
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                int num = random.Next(10, (20 + 1));
                //add to the list
                numbers.Add(num);
            }

            //methods to print the list
            static void PrintList(List<int> list)
            {
                //print all of it out in a line separated by commas and last number will not have a comma
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == list.Count - 1)
                    {
                        Console.Write(list[i]);
                    }
                    else
                    {
                        Console.Write(list[i] + ", ");
                    }
                }     
            }

            //fake loading screen
            static void Loading()
            {
                Console.WriteLine("Loading");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Loading.");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Loading..");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(1000);
                Console.Clear();
            }


            bool menuActive = true;
            while (menuActive)
            {
                Console.WriteLine("Your current numbers are: ");

                PrintList(numbers);

                Console.WriteLine();
                Console.WriteLine();
                //menu
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Sort the list");
                Console.WriteLine("2. Regenerate the list");
                Console.WriteLine("3. Remove number (by value)");
                //make it enter a number and all of the number with the same value will be removed
                Console.WriteLine("4. Add a value to the list");
                Console.WriteLine("5. Count all a specified value");
                Console.WriteLine("6. Print the largest number");
                Console.WriteLine("7. Print the smallest number");
                Console.WriteLine("8. Exit");

                //do maybe
                //Console.WriteLine("Print sum and average of numbers in the list");
                //Console.WriteLine("Find the most common number in the list");

                //get input
                string input = Console.ReadLine();

                //sort
                if (input == "1")
                {
                    Console.Clear();
                    numbers.Sort();
                    Console.WriteLine("Please, wait your numbers is being sorted!");
                    Thread.Sleep(1500);
                    Loading();
                    Console.Clear();

                }
                //regenerate
                else if (input == "2")
                {
                    Console.Clear();
                    numbers.Clear();
                    for (int i = 0; i < 25; i++)
                    {
                        int num = random.Next(10, (20 + 1));
                        //add to the list
                        numbers.Add(num);
                    }
                    Console.WriteLine("Please, wait your numbers are being generated!");
                    Thread.Sleep(1500);
                    Loading();
                    Console.Clear();
                }
                //remove number
                else if (input == "3")
                {
                    Console.WriteLine("What number would you like to remove?");
                    int num = Convert.ToInt32(Console.ReadLine());
                    numbers.RemoveAll(x => x == num);
                    Console.Clear();
                    Console.WriteLine("Please, wait your numbers are being removed!");
                    Thread.Sleep(1500);
                    Loading();
                    Console.Clear();
                }

            }
        }
        
    }
}
