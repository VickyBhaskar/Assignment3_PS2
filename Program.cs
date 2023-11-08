// See https://aka.ms/new-console-template for more information
using System;
namespace Assignment3_PS2
{
    internal class Program
    {
        static void Main(string[]args)
        {
            //  Convert a string to an integer using TryParse
            Console.WriteLine(" Convert a string to an integer using TryParse");
            Console.Write("Enter an integer as a string: ");
            string intStr = Console.ReadLine();

            if (int.TryParse(intStr, out int intValue))
            {
                int multipliedValue = intValue * 5;
                Console.WriteLine("Result after multiplying by 5:"+ multipliedValue);
            }
            else
            {
                Console.WriteLine("Failed to convert to an integer. Please enter a valid integer.");
            }

            //  Convert a string to a DateTime using Convert
            Console.WriteLine("\n Convert a string to a DateTime using Convert");
            Console.Write("Enter a date as a string: ");
            string dateStr = Console.ReadLine();

            try
            {
                DateTime dateTimeValue = Convert.ToDateTime(dateStr);
                DateTime oneMonthAgo = dateTimeValue.AddMonths(-1);
                Console.WriteLine("One month ago from the provided date: " + oneMonthAgo);
            }
            catch (FormatException)
            {
                Console.WriteLine("Failed to convert to a DateTime. Invalid date format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: {ex.Message}");
            }

            //  Convert a string to a TimeSpan using Parse
            Console.WriteLine("\n Convert a string to a TimeSpan using Parse");
            Console.Write("Enter a time duration as a string (e.g., '2:30:00'): ");
            string timeStr = Console.ReadLine();

            try
            {
                TimeSpan timeSpanValue = TimeSpan.Parse(timeStr);
                TimeSpan addedTwoHours = timeSpanValue.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine("Result after adding 2 hours: "+ addedTwoHours);
            }
            catch (FormatException)
            {
                Console.WriteLine("Failed to parse as a TimeSpan. Invalid time format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: {ex.Message}");
            }
        }
    }
}
