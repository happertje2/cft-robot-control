using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RoboclawClassLib;

namespace cft_robot_control
{
	public class AxisController
	{
		public int RmaxPos = 360000;
		public int XmaxPos = 120000;
		public int ZmaxPos = 37000;
		public int YmaxPos = 81000;

		public int RminPos = 0;
		public int XminPos = 0;
		public int ZminPos = 800;
		public int YminPos = 0;

		public void SetPosR(int position,uint speed)
		{
			Globals.roboClaw2.M1SpeedAccelDeccelPosition(0, speed, 0, position, 128);
		}

		public void SetPosR(int position)
		{
			Globals.roboClaw2.M1SpeedAccelDeccelPosition(0, 50000, 0, position, 128);
		}

		public void SetPosY(int position, uint speed)
		{
			Globals.roboClaw2.M2SpeedAccelDeccelPosition(0, speed, 0, position, 128);
		}
		public void SetPosY(int position)
		{
			Globals.roboClaw2.M2SpeedAccelDeccelPosition(0, 50000, 0, position, 128);
		}

		public void SetPosZ(int position, uint speed)
		{
			Globals.roboClaw1.M1SpeedAccelDeccelPosition(0, speed, 0, position, 128);
		}

		public void SetPosZ(int position)
		{
			Globals.roboClaw1.M1SpeedAccelDeccelPosition(0, 50000, 0, position, 128);
		}

		public void SetPosX(int position, uint speed)
		{
			Globals.roboClaw1.M2SpeedAccelDeccelPosition(0, speed, 0, position, 128);
		}
		public void SetPosX(int position)
		{
			Globals.roboClaw1.M2SpeedAccelDeccelPosition(0, 50000, 0, position, 128);
		}

		public void SetHome()
		{
			Globals.roboClaw1.ST_M1Backward(10);
			Globals.roboClaw1.ST_M2Backward(100);
			Globals.roboClaw2.ST_M1Backward(100);
			Globals.roboClaw2.ST_M2Backward(100);
			System.Threading.Thread.Sleep(8000);
			Globals.roboClaw1.SetEncoder1(0);
			Globals.roboClaw1.SetEncoder2(0);
			Globals.roboClaw2.SetEncoder1(0);
			Globals.roboClaw2.SetEncoder2(0);
			stopMotors(Globals.roboClaw1);
			stopMotors(Globals.roboClaw2);
			Console.Beep();
		}

		public void stopMotors(Roboclaw roboClaw)
		{
			roboClaw.ST_M1Forward(0);
			roboClaw.ST_M2Forward(0);
		}
	}
}
