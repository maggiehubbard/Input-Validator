using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //because I want to use regex to validate

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string option;
            string name, email, phone, date, html;


            Menu();
            option = Console.ReadLine();

            while (option != "9")
            {
                switch (option)
                {
                    case "1": //NAME
                        //user inputs name
                        Console.Write("Enter a valid name (First): ");
                        name = Console.ReadLine();
                        while (!nameValidate(name))
                        {
                            Console.Write("\nSorry " + name + " is not valid! \nPlease enter a valid name: ");
                            name = Console.ReadLine();
                        }
                        Console.WriteLine("Name is valid! \n");
                        Menu();
                        option = Console.ReadLine();

                        break;
                    case "2": //EMAIL
                        //user inputs email
                        Console.Write("\nEnter a valid email: ");
                        email = Console.ReadLine();

                        //calls method to validate email
                        while (!validateEmail(email))
                        {
                            Console.WriteLine("\nEmail is invalid. Please try again. ");
                            Console.Write("Enter a valid email: ");
                            email = Console.ReadLine();

                        }
                        Console.WriteLine("Email is valid! \n");
                        Menu();
                        option = Console.ReadLine();
                        break;
                    case "3": //PHONE NUMBER
                        //user inputs phone number
                        Console.Write("\nEnter a valid phone number (xxx-xxx-xxxx): ");
                        phone = Console.ReadLine();

                        //calls method to validate phone number
                        while (!validatePhone(phone))
                        {
                            Console.WriteLine("\nPhone number is invalid. Please try again. ");
                            Console.Write("Enter a valid phone number  (xxx-xxx-xxxx): ");
                            phone = Console.ReadLine();

                        }
                        Console.WriteLine("Phone number is valid! \n");
                        Menu();
                        option = Console.ReadLine();
                        break;
                    case "4"://DATE
                        //user inputs date
                        Console.Write("\nEnter a valid date date (mm/dd/yyyy): ");
                        date = Console.ReadLine();
                        //calls method to validate a date
                        while (!validateDate(date))
                        {
                            Console.WriteLine("\nDate is invalid. Please try again. ");
                            Console.Write("Enter a valid date date (mm/dd/yyyy): ");
                            date = Console.ReadLine();

                        }
                        Console.WriteLine("Date is valid! \n");
                        Menu();
                        option = Console.ReadLine();
                        break;
                    case "5": //BONUS HTML
                        //User Input
                        Console.WriteLine("\nEnter a valid HTML Element (i.e <p> </p>)");
                        html = Console.ReadLine();
                        //Method to validate
                        while (!validateHTML(html))
                        {
                            Console.WriteLine("\nElement is invalid. Please try again. ");
                            Console.Write("\nEnter a valid HTML Element (i.e <p> </p>)");
                            date = Console.ReadLine();

                        }
                        Console.WriteLine("Element is valid! \n");
                        Menu();
                        option = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Please try again");
                        Menu();
                        option = Console.ReadLine();
                        break;
                }
            }

            //Pause before closing
            Console.WriteLine("\n\nPress any key to exit. .");
            Console.ReadKey();
        }
        //method that calls the menu
        static void Menu()
        {
            Console.WriteLine("Welcome to the Validator");
            Console.WriteLine("============================\n");
            Console.WriteLine("1 - Enter your name");
            Console.WriteLine("2 - Enter your email address");
            Console.WriteLine("3 - Enter your phone numer");
            Console.WriteLine("4 - Enter your date");
            Console.WriteLine("5 - BONUS: Enter an HTML element");

            Console.WriteLine("9 - Quit");
        }

        //method that validates name
        static bool nameValidate(string n)
        {

            return Regex.IsMatch(n, @"^[A-Z][a-z]{1,29}$");
        }
        //METHOD TO VALIDATE EMAIL ADDRESS     
        static bool validateEmail(string email)
        {
            return Regex.IsMatch(email, (@"^([\w\.]{5,30}@\w{5,10}.\w{2,3})$"));
        }
        //METHOD TO VALIDATE PHONE NUMBERS
        static bool validatePhone(string number)
        {
            return Regex.IsMatch(number, (@"^([\d]{3}\-[\d]{3}\-[\d]{4})$"));

        }
        //METHOD TO VALIDATE DATES
        static bool validateDate(string date)
        {
            return Regex.IsMatch(date, (@"^([0-1][\d]\/[0-3][\d]\/[\d]{4})$"));

        }
        //METHOD TO VALIDATE HTML
        static bool validateHTML(string html)
        {
            return Regex.IsMatch(html, @"^([<][a-z][>]\s[<]\/[a-z][>])|([<][a-z][>][<]\/[a-z][>])$");
        }


    }
}
