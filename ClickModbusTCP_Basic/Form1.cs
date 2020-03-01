using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ClickModbusTCP_Basic
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbusClient.Connected)
                {
                    modbusClient.Disconnect();
                }


                modbusClient.IPAddress = tbIpAddress.Text;
                modbusClient.Port = 502;
                modbusClient.SerialPort = null;

                modbusClient.Connect();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Unable to connect to PLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteToPLC(int address, bool writeValue)
        {
            try
            {
                modbusClient.WriteSingleCoil(address - 1, writeValue);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Button Clicks
        private void btnC100_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16484, true);
        }

        private void btnC100_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16484, false);
        }

        private void btnC101_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16485, true);
        }

        private void btnC101_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16485, false);
        }

        private void btnC102_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16486, true);
        }

        private void btnC102_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16486, false);
        }

        private void btnC103_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16487, true);
        }

        private void btnC103_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16487, false);
        }

        private void btnC104_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16488, true);
        }

        private void btnC104_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16488, false);
        }

        private void btnC105_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16489, true);
        }

        private void btnC105_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16489, false);
        }

        private void btnC106_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16490, true);
        }

        private void btnC106_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16490, false);

        }

        private void btnC107_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16491, true);
        }

        private void btnC107_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16491, false);

        }

        private void btnC108_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16492, true);
        }

        private void btnC108_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16492, false);

        }

        private void btnC109_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16493, true);
        }

        private void btnC109_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16493, false);

        }

        private void btnC110_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16494, true);
        }

        private void btnC110_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16494, false);

        }

        private void btnC111_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16495, true);
        }

        private void btnC111_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16495, false);

        }

        private void btnC112_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16496, true);
        }

        private void btnC112_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16496, false);

        }

        private void btnC113_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToPLC(16497, true);
        }

        private void btnC113_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToPLC(16497, false);

        }

        #endregion
    }
}
