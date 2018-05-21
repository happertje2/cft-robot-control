using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using RoboclawClassLib;

namespace cft_robot_control
{
    public static partial class Program
    {

        static void Main()
        {
			string roboClawModel = "emty";
            int baudRate = 38400;
            byte roboClawAdress1 = 128;
			byte roboClawAdress2 = 129;

			Roboclaw roboclaw1;
			Roboclaw roboclaw2;
			roboclaw1 = new Roboclaw("COM3", baudRate, roboClawAdress1);
			roboclaw2 = new Roboclaw("COM3", baudRate, roboClawAdress2);
			roboclaw1.Open();
			roboclaw2.Open();

			roboclaw2.ST_M1Forward(100);

			//roboclaw = new Roboclaw();
			//roboclaw.Open("AUTO", ref roboClawModel,roboClawAdress, baudRate);

			Console.WriteLine(roboclaw1.IsOpen());
        }
    }
}
