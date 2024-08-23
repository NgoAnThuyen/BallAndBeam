namespace Cart_and_beam
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label_Status = new System.Windows.Forms.Label();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.Update_Timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Graph_Distance = new ZedGraph.ZedGraphControl();
            this.Graph_Pos = new ZedGraph.ZedGraphControl();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Kp = new System.Windows.Forms.TextBox();
            this.textBox_Ki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Kd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Set = new System.Windows.Forms.Button();
            this.textBox_setpoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.BackColor = System.Drawing.Color.White;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Status.Location = new System.Drawing.Point(113, 109);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(120, 25);
            this.label_Status.TabIndex = 17;
            this.label_Status.Text = "Disconected";
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disconnect.Location = new System.Drawing.Point(275, 59);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(138, 32);
            this.button_Disconnect.TabIndex = 16;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect.Location = new System.Drawing.Point(275, 9);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(138, 32);
            this.button_Connect.TabIndex = 15;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "56000",
            "115200",
            "128000"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(118, 59);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_BaudRate.TabIndex = 14;
            this.comboBox_BaudRate.Text = "115200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Baud rate";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.comboBox_Port.Location = new System.Drawing.Point(118, 9);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Port.TabIndex = 11;
            this.comboBox_Port.Text = "COM8";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.BackColor = System.Drawing.Color.White;
            this.label_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Port.Location = new System.Drawing.Point(11, 9);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(67, 25);
            this.label_Port.TabIndex = 10;
            this.label_Port.Text = "PORT";
            // 
            // Update_Timer
            // 
            this.Update_Timer.Enabled = true;
            this.Update_Timer.Tick += new System.EventHandler(this.Update_Timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // Graph_Distance
            // 
            this.Graph_Distance.Location = new System.Drawing.Point(16, 150);
            this.Graph_Distance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Graph_Distance.Name = "Graph_Distance";
            this.Graph_Distance.ScrollGrace = 0D;
            this.Graph_Distance.ScrollMaxX = 0D;
            this.Graph_Distance.ScrollMaxY = 0D;
            this.Graph_Distance.ScrollMaxY2 = 0D;
            this.Graph_Distance.ScrollMinX = 0D;
            this.Graph_Distance.ScrollMinY = 0D;
            this.Graph_Distance.ScrollMinY2 = 0D;
            this.Graph_Distance.Size = new System.Drawing.Size(912, 288);
            this.Graph_Distance.TabIndex = 20;
            this.Graph_Distance.UseExtendedPrintDialog = true;
            // 
            // Graph_Pos
            // 
            this.Graph_Pos.Location = new System.Drawing.Point(16, 446);
            this.Graph_Pos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Graph_Pos.Name = "Graph_Pos";
            this.Graph_Pos.ScrollGrace = 0D;
            this.Graph_Pos.ScrollMaxX = 0D;
            this.Graph_Pos.ScrollMaxY = 0D;
            this.Graph_Pos.ScrollMaxY2 = 0D;
            this.Graph_Pos.ScrollMinX = 0D;
            this.Graph_Pos.ScrollMinY = 0D;
            this.Graph_Pos.ScrollMinY2 = 0D;
            this.Graph_Pos.Size = new System.Drawing.Size(912, 288);
            this.Graph_Pos.TabIndex = 21;
            this.Graph_Pos.UseExtendedPrintDialog = true;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(692, 15);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 22;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kp";
            // 
            // textBox_Kp
            // 
            this.textBox_Kp.Location = new System.Drawing.Point(586, 17);
            this.textBox_Kp.Name = "textBox_Kp";
            this.textBox_Kp.Size = new System.Drawing.Size(100, 22);
            this.textBox_Kp.TabIndex = 24;
            this.textBox_Kp.Text = "1";
            // 
            // textBox_Ki
            // 
            this.textBox_Ki.Location = new System.Drawing.Point(586, 45);
            this.textBox_Ki.Name = "textBox_Ki";
            this.textBox_Ki.Size = new System.Drawing.Size(100, 22);
            this.textBox_Ki.TabIndex = 26;
            this.textBox_Ki.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ki";
            // 
            // textBox_Kd
            // 
            this.textBox_Kd.Location = new System.Drawing.Point(586, 73);
            this.textBox_Kd.Name = "textBox_Kd";
            this.textBox_Kd.Size = new System.Drawing.Size(100, 22);
            this.textBox_Kd.TabIndex = 28;
            this.textBox_Kd.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kd";
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(692, 101);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(75, 23);
            this.button_Set.TabIndex = 29;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // textBox_setpoint
            // 
            this.textBox_setpoint.Location = new System.Drawing.Point(586, 101);
            this.textBox_setpoint.Name = "textBox_setpoint";
            this.textBox_setpoint.Size = new System.Drawing.Size(100, 22);
            this.textBox_setpoint.TabIndex = 30;
            this.textBox_setpoint.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Set Point";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 667);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_setpoint);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.textBox_Kd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Ki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Kp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.Graph_Pos);
            this.Controls.Add(this.Graph_Distance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.comboBox_BaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.label_Port);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Timer Update_Timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl Graph_Distance;
        private ZedGraph.ZedGraphControl Graph_Pos;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Kp;
        private System.Windows.Forms.TextBox textBox_Ki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Kd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.TextBox textBox_setpoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

