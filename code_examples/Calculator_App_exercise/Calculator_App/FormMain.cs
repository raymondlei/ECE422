using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class FormMain : Form
    {
        private FormPortSettings _formPortSettings;
        private PortSettingsEntity _defaultSettings, _currentSettings;

        public FormMain()
        {
            InitializeComponent();
            tbDisplay.ReadOnly = true;
        }

        private void InitializeComPort(PortSettingsEntity handle)
        {
            string[] port_name = System.IO.Ports.SerialPort.GetPortNames();
            if(port_name.Length == 0)
            {
                tbDisplay.Text = "Error";
            }
            else
            {
                handle.PortName = port_name[0];  //Default com port is the first one on the list
                handle.BaudRate = 9600;
                handle.DataBits = 8;
                handle.StopBits = System.IO.Ports.StopBits.One;
                handle.Parity = System.IO.Ports.Parity.None;
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

            //TODO: display received string to Textbox
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement serial port connect
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //Disconnect serial port
                serialPort1.Close();

                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
                tbDisplay.ReadOnly = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _defaultSettings = new PortSettingsEntity();  //Object instance containing default settings
            _currentSettings = new PortSettingsEntity();  //Object instance storing current settings from user

            InitializeComPort(_defaultSettings);
            InitializeComPort(_currentSettings);

            //Initialize UI visual elements
            connectToolStripMenuItem.Enabled = true;
            disconnectToolStripMenuItem.Enabled = false;
        }

        private void FormSerialTx_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (string.IsNullOrEmpty(tbDisplay.Text) == false)
                {
                    //Write string directly to serial port object
                    serialPort1.Write(tbDisplay.Text);
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_formPortSettings == null)
            {
                _formPortSettings = new FormPortSettings();
            }

            _formPortSettings.Initialize(_defaultSettings, _currentSettings);
            if (_formPortSettings.ShowDialog() == DialogResult.OK)
            {
                //apply settings
                _currentSettings = _formPortSettings.NewSettings;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "0";

            if(serialPort1.IsOpen)
            {
                //TODO: send '0' to serial port
            }
        }
    }
}
