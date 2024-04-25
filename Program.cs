using System;

namespace project {

class Program
{
    static void Main()
    {

      Console.Write("Write down your age");
      double userInput;
      userInput = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("My age is " + userInput);

    
      Console.Write("Enter your role");
      string? role;
      role = Console.ReadLine();


      if (role == "admin" && userInput > 18) {
        Console.WriteLine("Hello, admin");
      } else if  (role == "admin" && userInput < 18) {
        Console.WriteLine("Hello, you are not admin");
      } else Console.WriteLine("You don't have access");

   

    }
}

}