using System;
// for dinamic arrays:
using System.Collections.Generic;
// for information in files:
using System.IO;

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

    // short[] numbers = new short[10];
    // Random randomNum = new Random();

    // for(byte i = 0; i < numbers.Length; i++) {
    //     numbers[i] = Convert.ToInt16(randomNum.Next(2,15));
    //     Console.WriteLine("Element: " + numbers[i]);
    // }

    // dinamic arrays:

    // List<int> numbers = new List<int>(){
    //     4, 6, 7
    // };

    // numbers.Add(40);
    // numbers.Add(100);

    // numbers.Remove(40);
    // numbers.Sort();
    // numbers.Reverse();

    // foreach(int el in numbers){
    //     System.Console.WriteLine("El: " + el);
    // };

    // NewFunction("Hello");

    // Summa(7,3);   
    // int x = 10, y = 2;
    // Summa(x, y);

    // int resultReturnFunction = ReturnFunction (26, 5);
    // NewFunction(resultReturnFunction.ToString());


    // // default parameter
    // CountryMethod();
    // System.Console.WriteLine ("Write text: ");
    // string? text = Console.ReadLine() ?? "";

    // using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)){
    //     byte[] array = System.Text.Encoding.Default.GetBytes(text);

    //     stream.Write(array, 0, array.Length);
    // }

    // using(FileStream stream1 = File.OpenRead("info.txt")) {
    //     byte[] array =  new byte[stream1.Length];
    //     stream1.Read(array, 0, array.Length);

    //     string textFromFile = System.Text.Encoding.Default.GetString(array);
    //     System.Console.WriteLine(textFromFile);
    // }


    // for robot:
    // Robot bot = new Robot("Robot", 180, new byte[] {0, 0, 0});
    // bot.printValues();

    // MainRobot mainBot = new MainRobot("Main Robot", 100000, new byte[] {30, 0, 15});
    // mainBot.printValues();
    // mainBot.Health = 100;
    // System.Console.WriteLine("Health level: " + mainBot.Health);
    // MainRobot.Count();

    // Robot List ------------------------

    List<Robot> robots = new List<Robot>();
    robots.Add(new Robot("Alex", 200, new byte[] {30, 0, 15}));
    robots.Add(new Robot("John", 100, new byte[] {30, 0, 15}));
    robots.Add(new Robot("Bobby", 100, new byte[] {30, 0, 15}));
    robots.Add(new Robot("Viktor", 100, new byte[] {30, 0, 15}));
    robots.Add(new Robot("Josh", 300, new byte[] {30, 0, 15}));

    foreach(Robot obj in robots){
        Console.WriteLine(obj.Name);
    }

    Robot.Count();
    

    }

     // Methods
    //  public static void NewFunction(string word) {
    //     Console.WriteLine(word);
    //  }


    //  public static void Summa(int a, int b){
    //     int result =  a + b;
    //     Console.WriteLine(result);
    //     NewFunction("Result is " + result);
    //  }

    //  public static int ReturnFunction(int x, int y)
    //  {
    //     return x + y;
    //  }

    //  public static void CountryMethod (string country = "Norway"){
    //     Console.WriteLine(country);
    //  }


}

}