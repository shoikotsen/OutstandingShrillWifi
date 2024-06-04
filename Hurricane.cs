using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the wind speed: ");
        string input = Console.ReadLine();
        string numericInput = Regex.Replace(input, "[^0-9.]", "");

        if (double.TryParse(numericInput, out double windSpeed))
        {
            int windSpeedInt = (int)Math.Round(windSpeed);
            string category = DetermineHurricaneCategory(windSpeedInt);
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
            Console.WriteLine("Invalid input. Please enter a valid numeric value for wind speed.");
        }
    }

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