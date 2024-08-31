using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to check if it belongs to the Fibonacci sequence: ");
        
        // Read the user input and convert it to an integer
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Calculating the Fibonacci sequence
            if (IsInFibonacciSequence(number))
            {
                Console.WriteLine($"The number {number} belongs to the Fibonacci sequence.");
            }
            else
            {
                Console.WriteLine($"The number {number} does NOT belong to the Fibonacci sequence.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static bool IsInFibonacciSequence(int num)
    {
        // 0 and 1 are part of the Fibonacci sequence
        if (num == 0 || num == 1)
            return true;

        // Variables to store the first two Fibonacci numbers and the current one
        int fib1 = 0;
        int fib2 = 1;
        int currentFib = 0;

        // Generate Fibonacci numbers until the current number is greater than or equal to 'num'
        while (currentFib < num)
        {
            currentFib = fib1 + fib2;
            fib1 = fib2;
            fib2 = currentFib;

            // If the current Fibonacci number matches 'num', return true
            if (currentFib == num)
                return true;
        }

        // If no match was found, return false
        return false;
    }
}
