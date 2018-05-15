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
            byte roboClawAdress = 128;

			Roboclaw roboclaw;
			roboclaw = new Roboclaw("AUTO", baudRate, roboClawAdress);
			roboclaw.Open();

			//roboclaw = new Roboclaw();
			//roboclaw.Open("AUTO", ref roboClawModel,roboClawAdress, baudRate);

			Console.WriteLine(roboclaw.IsOpen());
        }
    }
}
