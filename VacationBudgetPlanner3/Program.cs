using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace VacationBudgetPlanner3
{
    class Program
    {
        static void Main(string[] args)
        {

            string pass = "Password";
            string attempt;
            string id = "";
            //password check
            int n = 1;
            string reset = "";
            bool accessGranted = false;

            do
            {
                //Console.Write("Please enter password: ");
                //attempt = Console.ReadLine();

                 //Type your username and press enter
                 Console.WriteLine("Enter username:");

                 //Create a string variable and get user input from the keyboard and store it in the variable
                 string userName = Console.ReadLine();

                // Print the value of the variable (userName), which will display the input value
                 Console.WriteLine("Username is: " + userName);

                Console.Write("Please enter password: ");
                attempt = Console.ReadLine();

                if (attempt == pass || id == userName)
                {
                    Console.WriteLine("Access granted.");
                    accessGranted = true;
                    break;
                }
                else if (attempt != pass || id != userName)
                {
                    Console.WriteLine("Access denied.");
                }

                else if (reset == "456" || pass == "Password")        //if else conditional statement with || ( 'OR' ) operator
                 {
                    Console.WriteLine("hello {0}", id); // Inside statement run , When only one Statement is True            
                 }

                if (n == 3)
                {
                    if (!accessGranted)
                    {
                        // if access is NOT granted, then exit from the program.
                        Console.WriteLine("Reset your username and password?");
                        Console.WriteLine("Enter your new username");
                        id = Console.ReadLine();

                        Console.Write("Enter your new password");
                        pass = Console.ReadLine();

                        // we have to rest the count of n so that n start from 1 after the password has been reset.
                        n = -1;
                    }
                }
                n++;
            } while (n <= 3);

              
            
            //{
                bool correct = true;

                while (correct)
                {


                    // Type your username and press enter
                   // Console.WriteLine("Enter username:");

                    // Create a string variable and get user input from the keyboard and store it in the variable
                   // string userName = Console.ReadLine();

                    // Print the value of the variable (userName), which will display the input value
                   // Console.WriteLine("Username is: " + userName);

                    Console.WriteLine("Welcome to the vacation budget planner");
                    Console.WriteLine("What is your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Hello" + " " + name + " " + "Choose a place to travel:");
                    Console.WriteLine("Choose Mexico or Jamaica");
                    string place1 = Console.ReadLine();

                    switch (place1.ToLower())
                    {

                        case "jamaica":
                            Console.WriteLine(place1);
                            Console.WriteLine("Great! Jamaica sounds like an amazing trip!");
                            Console.WriteLine("********");
                            Console.WriteLine("How many days do you want to spend in Jamaica:");
                            int days = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("How much in USD to you plan to spend on the trip:");
                            double moneyAmount = Convert.ToDouble(Console.ReadLine());
                            int hours = days * 24;
                            int minutes = hours * 60;
                            Console.WriteLine("The total time in Jamaica is" + " " + hours + " " + "hours");
                            Console.WriteLine("The total minutes in Jamaica is" + " " + minutes + " " + "minutes");
                            double dayAverage = moneyAmount / days;
                            double dayJMD = moneyAmount * 138.05;
                            double jmdAverage = dayAverage / days;

                            moneyAmount.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your total expenditures of " + moneyAmount.ToString("C", CultureInfo.CurrentCulture));

                            dayAverage.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your daily average amount is " + dayAverage.ToString("C", CultureInfo.CurrentCulture) + " " + " each day");

                            dayJMD.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your JMD daily amount is" + " " + dayJMD.ToString("C", CultureInfo.CurrentCulture));

                            jmdAverage.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your JMD average amount is" + " " + jmdAverage.ToString("C", CultureInfo.CurrentCulture));

                            Console.WriteLine("Enjoy your trip");
                            //correct = false;
                            break;



                        case "mexico":
                            Console.WriteLine(place1);
                            Console.WriteLine("Great! Mexico sounds like an amazing trip!");
                            Console.WriteLine("********");
                            Console.WriteLine("How many days do you want to spend in Mexico:");
                            int days1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("How much in USD to you plan to spend on the trip:");
                            double moneyAmount1 = Convert.ToDouble(Console.ReadLine());
                            int hours1 = days1 * 24;
                            int minutes1 = hours1 * 60;
                            Console.WriteLine("The total time in Mexico is" + " " + hours1 + " " + "hours");
                            Console.WriteLine("The total minutes in Mexico is" + " " + minutes1 + " " + "minutes");
                            double dayAverage1 = moneyAmount1 / days1;
                            double dayPeso = moneyAmount1 * 23.68;
                            double pesoAverage = dayAverage1 / days1;

                            moneyAmount1.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your total expenditures of " + moneyAmount1.ToString("C", CultureInfo.CurrentCulture));

                            dayAverage1.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your daily average amount is " + dayAverage1.ToString("C", CultureInfo.CurrentCulture) + " " + " each day");

                            dayPeso.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your peso daily amount is " + " " + dayPeso.ToString("C", CultureInfo.CurrentCulture) + " " + " each day");

                            pesoAverage.ToString("C", CultureInfo.CurrentCulture);
                            Console.WriteLine("Your peso average amount is " + " " + pesoAverage.ToString("C", CultureInfo.CurrentCulture));

                            Console.WriteLine("Enjoy your trip");
                            //correct = false;
                            break;
                        default:

                            Console.WriteLine("Enter valid option");
                            //correct = false;
                            break;



                    }

                    //correct = false;


                    Console.WriteLine("Do you want to continue? Y/N");
                    string userSelection = Console.ReadLine();
                    if (userSelection.Equals("N") || userSelection.Equals("n"))
                    {
                        correct = false;
                    }
                }



            //}
        }
    }
}
