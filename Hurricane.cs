using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        // Prompt the user to enter the wind speed
        Console.WriteLine("Enter the wind speed: ");
        // Read the user input
        string input = Console.ReadLine();
        // Use a regular expression to remove any non-numeric characters from the input
        string numericInput = Regex.Replace(input, "[^0-9.]", "");
        // Try to parse the cleaned input into a double
        if (double.TryParse(numericInput, out double windSpeed))
        {
            // Round the wind speed to the nearest integer
            int windSpeedInt = (int)Math.Round(windSpeed);
            // Determine the hurricane category based on the wind speed
            string category = DetermineHurricaneCategory(windSpeedInt);
            // Display the hurricane category to the user
            if (category != "Not a Hurricane")
            {
                Console.WriteLine($"Category {category} hurricane.");
            }
            else
            {
                Console.WriteLine("Not a Hurricane");
            }
        }
        else
        {
            // Inform the user that the input was invalid
            Console.WriteLine("Invalid input. Please enter a valid numeric value for wind speed.");
        }
    }
     // Method to determine the hurricane category based on the wind speed
    public static string DetermineHurricaneCategory(int windSpeed)
    {
        if (windSpeed >= 157)
        {
            return "Five";
        }
        else if (windSpeed >= 130)
        {
            return "Four";
        }
        else if (windSpeed >= 111)
        {
            return "Three";
        }
        else if (windSpeed >= 96)
        {
            return "Two";
        }
        else if (windSpeed >= 74)
        {
            return "One";
        }
        else
        {
            return "Not a Hurricane";
        }
    }
}
// 2024/6/4_SenShoikot_Exercise 3.2