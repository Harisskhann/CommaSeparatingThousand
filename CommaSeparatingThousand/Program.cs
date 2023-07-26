using System;


public class Program
{
    public static string FormatNum(int number)
    {
        string numString = number.ToString();
        int length = numString.Length;
        string formattedNumber = "";

        for (int i = 0; i < length; i++)
        {
            formattedNumber += numString[i];

            int remainingDigits = length - i - 1;
            if (remainingDigits > 0 && remainingDigits % 3 == 0)
            {
                formattedNumber += ",";
            }
        }

        return formattedNumber;

    }
    public static void Main()
    {
        int num;
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());
        string value= FormatNum(num);
        Console.WriteLine(value);
        Console.ReadLine();
    }
}