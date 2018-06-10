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


		private void button1_Click(object sender, EventArgs e)
		{
			Globals.roboclawConnectionHandler.ToggleRoboclawConnection();
			if (Globals.roboclawConnectionHandler.connectedToRoboClaw == 1)
			{
				ConnectToRoboclawButton.Text = "disconnect";
				ConnectToRoboclawButton.BackColor = Color.Green;
				tabControl1.Visible = true;
			}
			else
			{
				ConnectToRoboclawButton.Text = "connect";
				ConnectToRoboclawButton.BackColor = Color.Red;
				tabControl1.Visible = false;
			}
		}

		private void setHome()
		{
			Globals.axisController.SetHome();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			setHome();
			Console.WriteLine(DateTime.Now.Ticks);
		}


		#region rotating axis control R
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			if (Globals.ManualControl == true)
			{
				Globals.axisController.SetPosR(trackBar1.Value);
				numericUpDownR.Value = trackBar1.Value;
			}
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Globals.axisController.SetPosR(Convert.ToInt32(numericUpDownR.Value));
		}
		#endregion

		#region total translating axis X
		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			if (Globals.ManualControl == true)
			{
				Globals.axisController.SetPosX(trackBar2.Value);
				numericUpDownX.Value = trackBar2.Value;
			}
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			Globals.axisController.SetPosX(Convert.ToInt32(numericUpDownX.Value));
		}
		#endregion

		#region heigth axis Z
		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			if (Globals.ManualControl == true)
			{
				Globals.axisController.SetPosZ(trackBar3.Value);
				numericUpDownZ.Value = trackBar3.Value;
			}
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			Globals.axisController.SetPosZ(Convert.ToInt32(numericUpDownZ.Value));
		}
		#endregion

		#region translating axis Y
		private void trackBar4_Scroll(object sender, EventArgs e)
		{
			if (Globals.ManualControl == true)
			{
				Globals.axisController.SetPosY(trackBar4.Value);
				numericUpDownY.Value = trackBar4.Value;
			}
		}

		private void numericUpDown4_ValueChanged(object sender, EventArgs e)
		{
			Globals.axisController.SetPosY(Convert.ToInt32(numericUpDownY.Value));
		}
		#endregion

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Console.WriteLine(panel1.PointToScreen(Cursor.Position).X);
			Console.WriteLine(Cursor.Position);
		}

		private void mouseDown(object sender, MouseEventArgs e)
		{
			if (Globals.ManualControl == true)
			{
				Console.WriteLine(panel1.PointToClient(Cursor.Position));
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
	}
}
