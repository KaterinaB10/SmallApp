using System;

namespace project {

    class MainRobot : Robot {
        public MainRobot(){}
        public MainRobot(string bot_name, int bot_height, byte[] bot_coordinates) : 
        base(bot_name, bot_height, bot_coordinates){}

        public int Health { get; set; }

    }

   

}