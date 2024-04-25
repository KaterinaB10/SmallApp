using System;

namespace project {

class Program
{
    static void Main()
    {

    //   Console.Write("Write down your age");
    //   double userInput;
    //   userInput = Convert.ToDouble(Console.ReadLine());
    //   Console.WriteLine("My age is " + userInput);

    
    //   Console.Write("Enter your role");
    //   string? role;
    //   role = Console.ReadLine();


    //   if (role == "admin" && userInput > 18) {
    //     Console.WriteLine("Hello, admin");
    //   } else if  (role == "admin" && userInput < 18) {
    //     Console.WriteLine("Hello, you are not admin");
    //   } else Console.WriteLine("You don't have access");

    short[] numbers = new short[10];
    Random randomNum = new Random();

    for(byte i = 0; i < numbers.Length; i++) {
        numbers[i] = Convert.ToInt16(randomNum.Next(2,15));
        Console.WriteLine("Element: " + numbers[i]);
    }

    }
}

}