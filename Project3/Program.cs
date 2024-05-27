using System;
using System.Runtime.InteropServices;

class Program
{
    // Import the C++ DLL function
    [DllImport("Dll.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Multiply(int a, int b);

    static void Main(string[] args)
    {
        try
        {
            // Get two integers from the user
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            // Call the Multiply function from the DLL
            int result = Multiply(num1, num2);

            // Display the result
            Console.WriteLine($"The result of multiplying {num1} and {num2} is {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
