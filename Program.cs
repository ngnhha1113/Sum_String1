using System;
using System.Collections.Generic;

// Class definition
public class MyBigNumber
{
    // Field to store the value
    private string value;

    // Constructor initializes the MyBigNumber object with a string representation of a number
    public MyBigNumber(string _str)
    {
        value = _str;
    }

    // Static method to add two large numbers represented as strings
    public static string String_Sum(string stn1, string stn2)
    {
        // Initialize an empty list to store the result
        List<char> result = new List<char>();
        // Initialize the carry to 0
        int carry = 0;
        // Find the maximum length among the two input numbers
        int maxLen = Math.Max(stn2.Length, stn1.Length);

        // Iterate through each digit from the right to the left
        for (int i = 1; i <= maxLen; i++)
        {
            // Initialize the digitSum with the carry
            int digitSum = carry;

            if (i <= stn2.Length)
                digitSum += int.Parse(stn2[^i].ToString());
            if (i <= stn1.Length)
                digitSum += int.Parse(stn1[^i].ToString());

            // Insert the current digit to the left of the result list
            result.Insert(0, (char)('0' + digitSum % 10));
            // Update the carry for the next iteration
            carry = digitSum / 10;
        }

        // If there is a carry after the loop, insert it at the beginning of the result
        if (carry > 0)
            result.Insert(0, (char)('0' + carry));

        // Return the result as a string
        return new string(result.ToArray());
    }
}

// Main class
class Program
{
    // Main method
    static void Main()
    {
        // Loop to allow the user to input numbers and perform calculations repeatedly
        string loop = "y";
        while (loop.ToLower() == "y")
        {
            // Input two numbers as strings and create MyBigNumber objects
            Console.Write("Please input 1st number: ");
            string stn1 = Console.ReadLine();

            Console.Write("Please input 2nd number: ");
            string stn2 = Console.ReadLine();

            // Call the String_Sum method to add the two numbers and get the result
            string res = MyBigNumber.String_Sum(stn1, stn2);

            // Log the result
            Console.WriteLine($"\nThe result of sum two large numbers is: {res}");

            // Ask the user if they want to try again
            Console.Write("Do you want to try again? (y/n): ");
            loop = Console.ReadLine();
        }
    }
}
