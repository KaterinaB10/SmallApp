using System;

namespace project {

    class Robot {

        // ------For counting robots:
        public static int count;
        // ---------------------------

        private string? name; 
        private int height;
        private byte[]? coordinates;

        // constructor:
        public Robot(string bot_name, int bot_height, byte[] bot_coordinates){
            System.Console.WriteLine("Object has been created");
            setValues(bot_name, bot_height, bot_coordinates);
            count++;
        }

        public Robot() {
            count++;
        }

        // -------------------------------------------------


        public void setValues(string bot_name, int bot_height,
         byte[] bot_coordinates)
        {
           name = bot_name;
           height = bot_height;
           coordinates = bot_coordinates; 
        }

        public void printValues(){
            System.Console.WriteLine("Hi, I'm " + name +
            ". My height is " + height + ". Coordinates: ");


    if (coordinates != null) {
        foreach (byte el in coordinates) {
            System.Console.WriteLine(el);
        }
        } else {
        System.Console.WriteLine("Coordinates is null");
        }    
        }

        public static void Count(){
            System.Console.WriteLine
            ("There were created robots: " + count);
        }
        
    }


}