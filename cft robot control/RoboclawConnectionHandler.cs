using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RoboclawClassLib;

namespace cft_robot_control
{
	public class RoboclawConnectionHandler
	{
		public int connectedToRoboClaw { get; private set; } = 0;

		public void ToggleRoboclawConnection()
		{
			if (connectedToRoboClaw == 0)
			{
				Globals.roboClaw1 = connectToRoboClaw(Globals.roboClaw1, 38400, 128, "COM3");
				Globals.roboClaw2 = connectToRoboClaw(Globals.roboClaw2, 38400, 129, "COM4");
			}
			else if (connectedToRoboClaw == 1)
			{
				disconnectFromRoboclaw(Globals.roboClaw1);
				disconnectFromRoboclaw(Globals.roboClaw2);
			}
		}

		private Roboclaw connectToRoboClaw(Roboclaw roboclaw, int baudRate, byte adress, string comport)
		{
			roboclaw = new Roboclaw(comport, baudRate, adress);
			roboclaw.Open();
			Console.WriteLine("is roboclaw open? " + roboclaw.IsOpen());
			if (roboclaw.IsOpen() == true)
			{
				connectedToRoboClaw = 1;
			}
			else
			{
				Console.WriteLine("Something went wrong. could not connect to roboclaw. is power on?");
				connectedToRoboClaw = 0;
			}
			return roboclaw;
		}

		private void disconnectFromRoboclaw(Roboclaw roboclaw)
		{
			Globals.axisController.stopMotors(roboclaw);
			roboclaw.Close();
			Console.WriteLine("is roboclaw open? " + roboclaw.IsOpen());
			if (roboclaw.IsOpen() == false)
			{
				connectedToRoboClaw = 0;
			}
			else
			{
				Console.WriteLine("Something went wrong. could not disconnect from roboclaw");
				connectedToRoboClaw = 1;
			}
		}


	}
}
