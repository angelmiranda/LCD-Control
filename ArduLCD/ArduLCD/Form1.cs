using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduLCD
{
    public partial class Form1 : Form
    {
        private const Int32 lgtMsg = 24;  
        public Form1()
        {
            InitializeComponent();
        }

        private string getPortName()
        {
            SerialPort inPort = new SerialPort();
            String[] allPorts = System.IO.Ports.SerialPort.GetPortNames();
                        
            string portFound = "";
            try
            {
                //Go through all port until we find where Arduino is connected 
                for (int i = 0; i < allPorts.Length && portFound==""; i++)
                {
                    inPort.Close();
                    inPort.PortName = allPorts[i];
                    inPort.Open();
                    inPort.Write("A");

                    String readFromIt = inPort.ReadLine();
                    if (readFromIt.Remove(readFromIt.IndexOf('\r')) == "ARDUINO")
                    {
                        //When we have it, save port name
                        portFound = allPorts[i]; 
                    }
                    inPort.Close();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);          
            }

            //Return port and message
            return portFound;
        }

        private void ReceiveData_Click(object sender, EventArgs e)
        {
            SerialPort inPort = new SerialPort();
            upperText.ForeColor = Color.Black;
            upperText.Text = "";

            try
            {
                string arduPortObj = getPortName();

                if (arduPortObj == "")
                    throw new Exception("Port not found!");
                else
                {
                    //All is correct
                    inPort.PortName = arduPortObj;
                    inPort.Open();
                    //Communicate with Arduino
                    inPort.Write("R");
                    //Read from Arduino, and get the upper and lower strings
                    string revFromArdu = inPort.ReadLine();
                    upperText.Text = revFromArdu.Substring(0, lgtMsg);
                    lowerText.Text = revFromArdu.Substring(lgtMsg, lgtMsg);
                    inPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendData_Click(object sender, EventArgs e)
        {
            SerialPort inPort = new SerialPort();

            //Buil string to send to Arduino
            string str24Cht = new String(' ', lgtMsg);
            string strToSend = (upperText.Text + str24Cht).Substring(0, lgtMsg);
            strToSend += (lowerText.Text + str24Cht).Substring(0, lgtMsg);

            try
            {
                string arduPortObj = getPortName();

                if (arduPortObj == "")
                    throw new Exception("Port not found!");
                else
                {
                    //All is correct
                    inPort.PortName = arduPortObj;
                    inPort.Open();
                    //Communicate with Arduino
                    inPort.Write("S");
                    //Send data to Arduino
                    inPort.Write(strToSend);
                    inPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set 24 charaters max by default for LCD length 
            int LCDMaxLg = 24;
            upperText.MaxLength = LCDMaxLg;
            lowerText.MaxLength = LCDMaxLg;
        }
    }
}