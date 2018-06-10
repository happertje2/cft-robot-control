namespace cft_robot_control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.ConnectToRoboclawButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.YmaxLabel = new System.Windows.Forms.Label();
			this.YminLabel = new System.Windows.Forms.Label();
			this.ZmaxLabel = new System.Windows.Forms.Label();
			this.ZminLabel = new System.Windows.Forms.Label();
			this.XminLabel = new System.Windows.Forms.Label();
			this.XmaxLabel = new System.Windows.Forms.Label();
			this.RminLabel = new System.Windows.Forms.Label();
			this.RmaxLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.trackBar4 = new System.Windows.Forms.TrackBar();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// ConnectToRoboclawButton
			// 
			this.ConnectToRoboclawButton.BackColor = System.Drawing.Color.Red;
			this.ConnectToRoboclawButton.Location = new System.Drawing.Point(12, 27);
			this.ConnectToRoboclawButton.Name = "ConnectToRoboclawButton";
			this.ConnectToRoboclawButton.Size = new System.Drawing.Size(139, 63);
			this.ConnectToRoboclawButton.TabIndex = 0;
			this.ConnectToRoboclawButton.Text = "Connect";
			this.ConnectToRoboclawButton.UseVisualStyleBackColor = false;
			this.ConnectToRoboclawButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(812, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.connectToolStripMenuItem.Text = "connect";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(162, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(640, 480);
			this.tabControl1.TabIndex = 2;
			this.tabControl1.Visible = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(632, 454);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "RobotSetup";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(7, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 59);
			this.button2.TabIndex = 0;
			this.button2.Text = "Home all";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.YmaxLabel);
			this.tabPage1.Controls.Add(this.YminLabel);
			this.tabPage1.Controls.Add(this.ZmaxLabel);
			this.tabPage1.Controls.Add(this.ZminLabel);
			this.tabPage1.Controls.Add(this.XminLabel);
			this.tabPage1.Controls.Add(this.XmaxLabel);
			this.tabPage1.Controls.Add(this.RminLabel);
			this.tabPage1.Controls.Add(this.RmaxLabel);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.textBox4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.textBox3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.trackBar4);
			this.tabPage1.Controls.Add(this.trackBar3);
			this.tabPage1.Controls.Add(this.trackBar2);
			this.tabPage1.Controls.Add(this.trackBar1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(632, 454);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "manual control";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// YmaxLabel
			// 
			this.YmaxLabel.AutoSize = true;
			this.YmaxLabel.Location = new System.Drawing.Point(394, 363);
			this.YmaxLabel.Name = "YmaxLabel";
			this.YmaxLabel.Size = new System.Drawing.Size(37, 13);
			this.YmaxLabel.TabIndex = 19;
			this.YmaxLabel.Text = "81000";
			// 
			// YminLabel
			// 
			this.YminLabel.AutoSize = true;
			this.YminLabel.Location = new System.Drawing.Point(7, 363);
			this.YminLabel.Name = "YminLabel";
			this.YminLabel.Size = new System.Drawing.Size(13, 13);
			this.YminLabel.TabIndex = 18;
			this.YminLabel.Text = "0";
			// 
			// ZmaxLabel
			// 
			this.ZmaxLabel.AutoSize = true;
			this.ZmaxLabel.Location = new System.Drawing.Point(393, 255);
			this.ZmaxLabel.Name = "ZmaxLabel";
			this.ZmaxLabel.Size = new System.Drawing.Size(37, 13);
			this.ZmaxLabel.TabIndex = 17;
			this.ZmaxLabel.Text = "37000";
			// 
			// ZminLabel
			// 
			this.ZminLabel.AutoSize = true;
			this.ZminLabel.Location = new System.Drawing.Point(10, 255);
			this.ZminLabel.Name = "ZminLabel";
			this.ZminLabel.Size = new System.Drawing.Size(25, 13);
			this.ZminLabel.TabIndex = 16;
			this.ZminLabel.Text = "800";
			// 
			// XminLabel
			// 
			this.XminLabel.AutoSize = true;
			this.XminLabel.Location = new System.Drawing.Point(6, 144);
			this.XminLabel.Name = "XminLabel";
			this.XminLabel.Size = new System.Drawing.Size(13, 13);
			this.XminLabel.TabIndex = 15;
			this.XminLabel.Text = "0";
			// 
			// XmaxLabel
			// 
			this.XmaxLabel.AutoSize = true;
			this.XmaxLabel.Location = new System.Drawing.Point(391, 143);
			this.XmaxLabel.Name = "XmaxLabel";
			this.XmaxLabel.Size = new System.Drawing.Size(43, 13);
			this.XmaxLabel.TabIndex = 14;
			this.XmaxLabel.Text = "120000";
			// 
			// RminLabel
			// 
			this.RminLabel.AutoSize = true;
			this.RminLabel.Location = new System.Drawing.Point(3, 38);
			this.RminLabel.Name = "RminLabel";
			this.RminLabel.Size = new System.Drawing.Size(13, 13);
			this.RminLabel.TabIndex = 13;
			this.RminLabel.Text = "0";
			// 
			// RmaxLabel
			// 
			this.RmaxLabel.AutoSize = true;
			this.RmaxLabel.Location = new System.Drawing.Point(392, 38);
			this.RmaxLabel.Name = "RmaxLabel";
			this.RmaxLabel.Size = new System.Drawing.Size(43, 13);
			this.RmaxLabel.TabIndex = 12;
			this.RmaxLabel.Text = "360000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 379);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "position";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(7, 395);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(68, 20);
			this.textBox4.TabIndex = 10;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "position";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(7, 287);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(68, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "position";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(7, 176);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(68, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "position";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(7, 67);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(68, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// trackBar4
			// 
			this.trackBar4.Location = new System.Drawing.Point(6, 332);
			this.trackBar4.Maximum = 81000;
			this.trackBar4.Name = "trackBar4";
			this.trackBar4.Size = new System.Drawing.Size(421, 45);
			this.trackBar4.TabIndex = 3;
			this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
			// 
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point(7, 223);
			this.trackBar3.Maximum = 37000;
			this.trackBar3.Minimum = 800;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(421, 45);
			this.trackBar3.TabIndex = 2;
			this.trackBar3.Value = 800;
			this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(7, 112);
			this.trackBar2.Maximum = 120000;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(421, 45);
			this.trackBar2.TabIndex = 1;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(6, 6);
			this.trackBar1.Maximum = 360000;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(422, 45);
			this.trackBar1.TabIndex = 0;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.panel1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(632, 454);
			this.tabPage3.TabIndex = 3;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
			this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(640, 480);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 544);
			this.Controls.Add(this.ConnectToRoboclawButton);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.Location = new System.Drawing.Point(1280, 0);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button ConnectToRoboclawButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TrackBar trackBar4;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label YmaxLabel;
		private System.Windows.Forms.Label YminLabel;
		private System.Windows.Forms.Label ZmaxLabel;
		private System.Windows.Forms.Label ZminLabel;
		private System.Windows.Forms.Label XminLabel;
		private System.Windows.Forms.Label XmaxLabel;
		private System.Windows.Forms.Label RminLabel;
		private System.Windows.Forms.Label RmaxLabel;
	}
}

