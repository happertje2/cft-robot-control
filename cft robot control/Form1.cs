using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RoboclawClassLib;

namespace cft_robot_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


		private int connectedToRoboClaw = 0;

		private void button1_Click(object sender, EventArgs e)
		{
			if (connectedToRoboClaw == 0)
			{
				Globals.roboClaw1 = connectToRoboClaw(Globals.roboClaw1, 38400, 128, "COM3");
				Globals.roboClaw2 = connectToRoboClaw(Globals.roboClaw2, 38400, 129, "COM4");
			}
			else if(connectedToRoboClaw == 1)
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
			connectedToRoboClaw = 1;
			button1.Text = "disconnect";
			button1.BackColor = Color.Green;
			tabControl1.Visible = true;
			return roboclaw;
		}

		private void disconnectFromRoboclaw(Roboclaw roboclaw)
		{
			stopMotors(roboclaw);
			roboclaw.Close();
			Console.WriteLine("is roboclaw open? " + roboclaw.IsOpen());
			connectedToRoboClaw = 0;
			button1.Text = "connect";
			button1.BackColor = Color.Red;
			tabControl1.Visible = false;
		}

		private void setHome()
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

		private static void stopMotors(Roboclaw roboClaw)
		{
			roboClaw.ST_M1Forward(0);
			roboClaw.ST_M2Forward(0);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			setHome();
			Console.WriteLine(DateTime.Now.Ticks);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			textBox1.Text = Globals.roboClaw1.GetM1Encoder(
		}
	}
}
