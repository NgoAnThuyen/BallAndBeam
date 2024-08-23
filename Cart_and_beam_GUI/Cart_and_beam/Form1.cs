using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Cart_and_beam
{
    public partial class Form1 : Form
    {
        int TickStart;
        float pos, distance, setpoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            
            serialPort.PortName = comboBox_Port.Text;
            serialPort.BaudRate = int.Parse(comboBox_BaudRate.Text);
            serialPort.Encoding = System.Text.Encoding.GetEncoding(28605);
            serialPort.Open();
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void Update_Timer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                label_Status.Text = "Connected";
                label_Status.ForeColor = Color.Green;

                label3.Text = pos.ToString();
                label4.Text = distance.ToString();
                label9.Text = setpoint.ToString();
               
                Draw();
            }
            else
            {
                label_Status.Text = "Disconnected";
                label_Status.ForeColor = Color.Red;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graph_Distance.GraphPane.Title.Text = "Distance Graph";
            Graph_Distance.GraphPane.XAxis.Title.Text = "Time,s";
            Graph_Distance.GraphPane.YAxis.Title.Text = "Distance,cm";
            Graph_Distance.GraphPane.Title.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Distance.GraphPane.XAxis.Scale.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Distance.GraphPane.YAxis.Scale.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Distance.GraphPane.XAxis.Title.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Distance.GraphPane.YAxis.Title.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            RollingPointPairList list_distance = new RollingPointPairList(1000);
            RollingPointPairList list_setpoint = new RollingPointPairList(1000);
            Graph_Distance.GraphPane.XAxis.Scale.Min = 0;
            Graph_Distance.GraphPane.XAxis.Scale.Max = 10;
            Graph_Distance.GraphPane.XAxis.Scale.MinorStep = 1;
            Graph_Distance.GraphPane.XAxis.Scale.MajorStep = 5;
            Graph_Distance.GraphPane.YAxis.Scale.Min = 0;
            Graph_Distance.GraphPane.YAxis.Scale.Max = 40;
            Graph_Distance.AxisChange();
            LineItem curve_distance = Graph_Distance.GraphPane.AddCurve("Distance", list_distance, Color.Blue, SymbolType.None);
            LineItem curve_setpoint = Graph_Distance.GraphPane.AddCurve("Setpoint", list_setpoint, Color.Red, SymbolType.None);



            Graph_Pos.GraphPane.Title.Text = "Servo Position Graph";
            Graph_Pos.GraphPane.XAxis.Title.Text = "Time,s";
            Graph_Pos.GraphPane.YAxis.Title.Text = "Servo pos ,Degree";
            Graph_Pos.GraphPane.Title.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Pos.GraphPane.XAxis.Scale.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Pos.GraphPane.YAxis.Scale.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Pos.GraphPane.XAxis.Title.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            Graph_Pos.GraphPane.YAxis.Title.FontSpec.Size = 3.0f * (this.Size.Width / 100);
            RollingPointPairList list_pos = new RollingPointPairList(1000);

            Graph_Pos.GraphPane.XAxis.Scale.Min = 0;
            Graph_Pos.GraphPane.XAxis.Scale.Max = 10;
            Graph_Pos.GraphPane.XAxis.Scale.MinorStep = 1;
            Graph_Pos.GraphPane.XAxis.Scale.MajorStep = 5;
            Graph_Pos.GraphPane.YAxis.Scale.Min =  20;
            Graph_Pos.GraphPane.YAxis.Scale.Max =  150;
            Graph_Pos.AxisChange();
            LineItem curve_pos = Graph_Pos.GraphPane.AddCurve("Servo Position", list_pos, Color.Blue, SymbolType.None);

        }

        private void Draw()
        {
            double time = (Environment.TickCount - TickStart) / 1000.0;

            if (Graph_Distance.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve_distance = Graph_Distance.GraphPane.CurveList[0] as LineItem;
            LineItem curve_setpoint = Graph_Distance.GraphPane.CurveList[1] as LineItem;
            if (curve_distance == null)
                return;
            IPointListEdit list_distance = curve_distance.Points as IPointListEdit;
            IPointListEdit list_setpoint = curve_setpoint.Points as IPointListEdit;
            list_distance.Add(time, distance);
            list_setpoint.Add(time, setpoint);
            Scale xScale_Distacne = Graph_Distance.GraphPane.XAxis.Scale;
            if (time > xScale_Distacne.Max - xScale_Distacne.MajorStep)
            {
                xScale_Distacne.Max = time + xScale_Distacne.MajorStep;
                xScale_Distacne.Min = xScale_Distacne.Max - 10.0;
            }
            Graph_Distance.GraphPane.AxisChange();
            Graph_Distance.Invalidate();


            if (Graph_Pos.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve_pos = Graph_Pos.GraphPane.CurveList[0] as LineItem;
            if (curve_pos == null)
                return;

            IPointListEdit list_pos = curve_pos.Points as IPointListEdit;

            list_pos.Add(time, pos);
            Scale xScale_Pos = Graph_Pos.GraphPane.XAxis.Scale;
            if (time > xScale_Pos.Max - xScale_Pos.MajorStep)
            {
                xScale_Pos.Max = time + xScale_Pos.MajorStep;
                xScale_Pos.Min = xScale_Pos.Max - 10.0;
            }
            Graph_Pos.GraphPane.AxisChange();
            Graph_Pos.Invalidate();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_setpoint.Text = "-1";
            Packing_and_send();
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            //float temp_setpoint = float.Parse(textBox_setpoint.Text);
            // textBox_setpoint.Text = "20";
            setpoint = float.Parse(textBox_setpoint.Text);
            Packing_and_send();
        }

        private void Packing_and_send()
        {
            /*
	        Format: BYTE0 BYTE1 BYTE2 BYTE3 BYTE4 BYTE5 BYTE6 BYTE7 BYTE8  
                      $   -------Setpoint-------- --------Kp------------	
            Format: BYTE9 BYTE10 BYTE11 BYTE12 BYTE13 BYTE14 BYTE15 BYTE16 BYTE17  BYTE18   BYTE19 
            $        -----------Ki------------ ------------Kd------------  Checksum    \r     \n
	        */

        
            byte[] frame = new byte[20];
            byte[] vOut = new byte[4];
        
            frame[0] = 20;

            vOut = BitConverter.GetBytes(float.Parse(textBox_setpoint.Text));
            frame[1] = vOut[0];
            frame[2] = vOut[1];
            frame[3] = vOut[2];
            frame[4] = vOut[3];

            vOut = BitConverter.GetBytes(float.Parse(textBox_Kp.Text));
            frame[5] = vOut[0];
            frame[6] = vOut[1];
            frame[7] = vOut[2];
            frame[8] = vOut[3];

            vOut = BitConverter.GetBytes(float.Parse(textBox_Ki.Text));
            frame[9] = vOut[0];
            frame[10] = vOut[1];
            frame[11] = vOut[2];
            frame[12] = vOut[3];

            vOut = BitConverter.GetBytes(float.Parse(textBox_Kd.Text));
            frame[13] = vOut[0];
            frame[14] = vOut[1];
            frame[15] = vOut[2];
            frame[16] = vOut[3];

            byte CS_Tx = 0;
            for (int i = 0; i < 17; i++)
            {
                CS_Tx += frame[i];
            }
            frame[17] = CS_Tx;

            frame[18] = 13;
            frame[19] = 10;

            serialPort.Write(frame, 0, 20);
        }
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            System.Diagnostics.Debug.WriteLine(data);
            System.Diagnostics.Debug.WriteLine(data.Length);
            if (data.Length == 9)
            {
                if ((data[0] == '$'))
                {
                    System.Text.Encoding enc = System.Text.Encoding.GetEncoding(28605);
                    byte[] Rx_buffer = enc.GetBytes(data.Substring(0, 9));
                    System.Diagnostics.Debug.WriteLine("Successful");
                    byte[] temp_bytes = new byte[4];
                    Buffer.BlockCopy(Rx_buffer,1, temp_bytes, 0, 4);
                    pos = BitConverter.ToSingle(temp_bytes, 0);
                    System.Diagnostics.Debug.WriteLine(pos);
                    Buffer.BlockCopy(Rx_buffer, 5, temp_bytes, 0, 4);
                    distance = BitConverter.ToSingle(temp_bytes, 0);
                    System.Diagnostics.Debug.WriteLine(distance);
                    //pos = BitConverter.ToSingle(temp_bytes, 0);
                }

            }

              
        }
    }
}
