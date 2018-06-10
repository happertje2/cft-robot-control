using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cft_robot_control
{
	class GetEncoders
	{
		public byte statusRoboClaw1 = 0;
		private void timer()
		{
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Interval = 100;
			timer.Elapsed += timer_Elapsed;
			timer.Start();
		}

		private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			getEncoders();
			Console.WriteLine(Globals.encoder1RoboClaw1);
		}

		private void getEncoders()
		{
			Globals.roboClaw1.GetM1Encoder(ref Globals.encoder1RoboClaw1, ref statusRoboClaw1);
		}
	}
}
