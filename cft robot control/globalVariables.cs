using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RoboclawClassLib;

namespace cft_robot_control
{
	public class Globals
	{
		public static Roboclaw roboClaw1;
		public static Roboclaw roboClaw2;
		public static DateTime time = new DateTime();
		public static int encoder1RoboClaw1 = 0;
		public static AxisController axisController = new AxisController();
		public static RoboclawConnectionHandler roboclawConnectionHandler = new RoboclawConnectionHandler();

		public static bool ManualControl = true;
	}
}
