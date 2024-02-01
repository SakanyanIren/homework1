// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        // 1. Conditional Statements        // Weather Conditions
        Console.Write("Enter temperature: "); int temperature = int.Parse(Console.ReadLine());
        if (temperature < 0) Console.WriteLine("Freezing weather.");
        else if (temperature >= 0 && temperature <= 10) Console.WriteLine("Cold weather.");
        else if (temperature > 10 && temperature <= 20) Console.WriteLine("Moderate weather.");
        else Console.WriteLine("Warm weather.");
        // Age Group Categorization
        Console.Write("Enter age: "); int age = int.Parse(Console.ReadLine());
        if (age < 13) Console.WriteLine("Child");
        else if (age >= 13 && age <= 19) Console.WriteLine("Teenager");
        else Console.WriteLine("Adult");

        // Temperature Conversion        Console.Write("Enter temperature: ");
        double tempValue = double.Parse(Console.ReadLine()); Console.Write("Enter conversion direction (F to C or C to F): ");
        char conversionDirection = char.Parse(Console.ReadLine()); if (conversionDirection == 'F' || conversionDirection == 'f')
            Console.WriteLine($"Converted temperature: {(tempValue - 32) * 5 / 9}°C");
        else if (conversionDirection == 'C' || conversionDirection == 'c')
            Console.WriteLine($"Converted temperature: {tempValue * 9 / 5 + 32}°F");
        // 2. Array Manipulations        // Find Max and Min
        int[] numbers = { 4, 2, 8, 1, 6 }; Console.WriteLine($"Max: {numbers.Max()}, Min: {numbers.Min()}");
        // Reverse Array
        Array.Reverse(numbers); Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));
        // Find Second Largest
        Array.Sort(numbers); Console.WriteLine("Second Largest: " + numbers[numbers.Length - 2]);
        // Sum of Corresponding Elements
        int[] array1 = { 1, 2, 3 }; int[] array2 = { 4, 5, 6 };
        int[] sumArray = new int[array1.Length]; for (int i = 0; i < array1.Length; i++)
            sumArray[i] = array1[i] + array2[i]; Console.WriteLine("Sum of Corresponding Elements: " + string.Join(", ", sumArray));
    }
}

