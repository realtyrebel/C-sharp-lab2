using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2{
    class Program{
        static void Main(string[] arr){

            do
            {
                //initialize variables
                bool continueInput = true;
                List<int> list = new List<int>();//blank list

                Console.WriteLine("Please input numbers to run analysis ...");
                Console.WriteLine("Press 'Enter' when finished inputting your numbers.");
                Console.WriteLine("");

                do
                {
                    //initialize variables
                    int inputNumber;

                    //read and display numbers
                    //Console.Write("Enter an Integer: ");
                    string inputString = Console.ReadLine();

                    //check for input
                    if (!string.IsNullOrEmpty(inputString))//if not null, process integer values
                    {
                        //check if input is valid integer
                        if (int.TryParse(inputString, out inputNumber))
                        {
                            //Console.WriteLine("{0} is a valid number.", inputString);

                            //add integer to list of all integers
                            list.Add(inputNumber);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                    else//if null or empty
                    {
                        if (list.Count < 0)
                        {
                            Console.WriteLine("You did not enter any integer.");
                            
                        }
                        //enter button was pressed
                        continueInput = false;
                    }
                } while (continueInput);

                if (list.Count() > 0)
                {
                    int listLength = list.Count();
                    //Console.WriteLine("You have inputted " + listLength + " integers.");

                    //min value
                    list.Sort();
                    int minInteger = list[0];
                    Console.WriteLine("Minimum value of all integers is '" + minInteger + "'.");

                    //max value
                    int maxInteger = list[listLength - 1];
                    Console.WriteLine("Maximum value of all integers is '" + maxInteger + "'.");

                    //initialize odd and even number lists
                    List<int> oddNumbers = new List<int>();
                    List<int> evenNumbers = new List<int>();

                    foreach (int element in list)
                    {
                        //determine if odd or even
                        if (element % 2 == 0)//is even
                        {
                            //add integer to list of all even integers
                            evenNumbers.Add(element);
                        }
                        else//is odd
                        {
                            //add integer to list of all odd integers
                            oddNumbers.Add(element);
                        }
                    }

                    //check if there are any even numbers
                    if (evenNumbers.Count > 0)
                    {
                        Console.WriteLine("-----------------------------------------------------");

                        //total number of all even integers
                        int countEvenIntegers = evenNumbers.Count();
                        Console.WriteLine("There are " + countEvenIntegers + " even integers in total.");

                        //sum of all even integers
                        int sumEvenIntegers = 0;
                        foreach (int evenNumber in evenNumbers)
                        {
                            sumEvenIntegers += evenNumber;
                        }
                        Console.WriteLine("The sum of all even integers is " + sumEvenIntegers + ".");

                        //average of all even integers
                        double avgEvenIntegers = countEvenIntegers > 0 ? evenNumbers.Average() : 0.0;
                        Console.WriteLine("The average of all even integers is " + avgEvenIntegers + ".");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("No even numbers entered.");
                    }

                    //check if there are any odd numbers
                    if (oddNumbers.Count > 0)
                    {
                        Console.WriteLine("-----------------------------------------------------");

                        //total number of odd integers
                        int countOddIntegers = oddNumbers.Count();
                        Console.WriteLine("There are " + countOddIntegers + " odd integers in total.");

                        //sum of all odd-numbered integers
                        int sumOddIntegers = 0;
                        foreach (int oddNumber in oddNumbers)
                        {
                            sumOddIntegers += oddNumber;
                        }
                        Console.WriteLine("The sum of all odd integers is " + sumOddIntegers + ".");

                        //average of all odd-numbered integers
                        double avgOddIntegers = countOddIntegers > 0 ? oddNumbers.Average() : 0.0;
                        Console.WriteLine("The average of all odd integers is " + avgOddIntegers + ".");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("No odd numbers entered.");
                    }

                    Console.WriteLine("-----------------------------------------------------");
                }
            } while (reload());

            Console.WriteLine("Thanks for coming out!");
            Console.ReadLine();
        }

        private static bool reload()
        {
            Console.Write("Play again (Y)?  ");
            string userResponse = Console.ReadLine().ToUpper();
            if(userResponse == "Y")
            {
                Console.WriteLine("-----------------------------------------------------");
            }
            return userResponse == "Y";
        }
    }
}
