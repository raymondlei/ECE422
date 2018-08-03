using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPort_Demo
{
    /// <summary>
    /// Simple Serial Communication
    /// 
    /// Reference URLs:
    /// 
    /// Example codes: http://csharp.simpleserial.com/
    /// Official MSDN documentation: https://msdn.microsoft.com/en-us/library/system.io.ports.serialport.aspx
    /// 
    /// Keywords: "C# SerialPort", "C# serial port"
    /// </summary>
    public partial class FormSerialTx : Form
    {
        private bool _autosendEnabled;
        private string _rxString;

        public FormSerialTx()
        {
            InitializeComponent();
        }

        private void Connect(SerialPort handle)
        {
            //Configure serial port
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;

            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.Open();  //attempt to open the configured serial port
                    if (serialPort1.IsOpen)
                    {
                        //Com Port is connected
                        connectToolStripMenuItem.Enabled = false;
                        disconnectToolStripMenuItem.Enabled = true;
                        tbAscii.ReadOnly = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to open serial port");
                }
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //handle serial port connect
            Connect(serialPort1);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //Disconnect serial port
                serialPort1.Close();
                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
                tbAscii.ReadOnly = true;
            }
        }

        private void FormSerialTx_Load(object sender, EventArgs e)
        {
            _autosendEnabled = cbAutoSend.Checked;
        }

        private void FormSerialTx_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Note: SerialPort object operates on a seperate thread.
            //      Therefore, DataReceived event can not interact directly with other WinForm controls.
            //      Doing so will cause cross-thread action exception.
            //      In order to display received data to UI, delegate method must be used.

            //Read data from serial port object
            string data = serialPort1.ReadExisting();

            //Choose one of the approaches below

            //Approach 1: call Invoke method and pass data via external variable
            _rxString = data;  //assign to external variable
            this.Invoke(new EventHandler(ShowText));

            //Approach 2: pass data via parameter
            //this.Invoke(new EventHandler(DisplayText), new object[] { data });
        }

        private void DisplayText(object sender, EventArgs e)
        {
            tbAscii.AppendText((string)sender);
        }

        private void ShowText(object sender, EventArgs e)
        {
            tbAscii.AppendText(_rxString);
        }

        private void tbAscii_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] key = new char[1];
            key[0] = e.KeyChar;  //Read keypress character

            byte[] buffer = Encoding.ASCII.GetBytes(key);
            if (buffer.Length > 0)
                UpdateTextbox(buffer);

            if (_autosendEnabled)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(key, 0, 1);
                }
            }

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, comment out the next line.
            //e.Handled = true;
        }

        private void UpdateTextbox(byte[] buffer)
        {
            tbHex.Text += ByteArrayToString(buffer);
            tbHex.SelectionStart = tbHex.Text.Length;
            tbHex.ScrollToCaret();
            tbHex.Refresh();
        }

        private void cbAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            _autosendEnabled = cbAutoSend.Checked;
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbAscii.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (string.IsNullOrEmpty(tbAscii.Text) == false)
                {
                    //Write string directly to serial port object
                    serialPort1.Write(tbAscii.Text);
                }
            }
        }

        private static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:X2} ", b);
            return hex.ToString();
        }
    }
}
