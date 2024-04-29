using System;

namespace project {

    class Robot {
        private string? name; 
        private int height;
        private byte[]? coordinates;

        // constructor:
        public Robot(){
            System.Console.WriteLine("Object has been created");
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
            try {
    if (coordinates != null) {
        foreach (byte el in coordinates) {
            System.Console.WriteLine(el);
        }
    } else {
        System.Console.WriteLine("Coordinates is null");
    }
} catch (NullReferenceException) {
    System.Console.WriteLine("Something's gone wrong");
}

            

        }
    }


}