using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Arduino_y_Led
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        public Form1()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM8";
            Arduino.BaudRate = 9600;
            Arduino.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Arduino.IsOpen) 
            {
                Arduino.Close();
            }
        }

        private void BttnEncender_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");
        }

        private void BttnApagar_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("G");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("H");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");
            Arduino.Write("G");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");
            Arduino.Write("H");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");
            Arduino.Write("H");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");
            Arduino.Write("G");
        }
    }
}
