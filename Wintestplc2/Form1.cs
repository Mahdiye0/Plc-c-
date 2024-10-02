

using System;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace Wintestplc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
            }
        }
        SerialPort serialPort = new SerialPort();
        Modbus.Device.ModbusSerialMaster master;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                

                if (!serialPort.IsOpen)
                        {
                    serialPort.PortName = cmbPorts.Text.Trim();
                    serialPort.BaudRate = int.Parse(txtRate.Text.Trim());
                    serialPort.DataBits = int.Parse(txtBits.Text.Trim());
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.SelectedItem.ToString());
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbBits.SelectedItem.ToString());
                    master = Modbus.Device.ModbusSerialMaster.CreateRtu(serialPort);
                    
                    serialPort.Open();
                   
                    pic.BackgroundImage = Properties.Resources.icons8_connected_30;
                    btnRtu.Enabled = false;
                    btndis.Enabled = true;
                }
                else
                    MessageBox.Show("اتصال برقرار هست");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClassGeneral.logError("error_log.txt",ex.Message,ex.StackTrace);
                pic.BackgroundImage = Properties.Resources.icons8_disconnected_30;
                serialPort.Close();
                serialPort.Dispose();

            }
          
        }

       
           
        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {


                string[] ports = SerialPort.GetPortNames();
                cmbPorts.DataSource = ports;
                cmbParity.SelectedIndex = 0;
                cmbBits.SelectedIndex = 0;
                if (radioButton2.Checked)
                {
                    groupBox3.Enabled = true;
                    groupBox2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     

    
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {

                //ushort decimalAddress = Convert.ToUInt16("C8", 16); 
                // int registerNumber = 200; 
                //string hexAddress = registerNumber.ToString("X");
                //Console.WriteLine(hexAddress);
               

                ushort startAddress = 0;
                
                byte slaveId = byte.Parse(txtDevice.Text.Trim());
                if (rdbHex.Checked)
                {
                    string hexAddress = txtStart.Text.Trim();
                    startAddress = ushort.Parse(lbl.Text);
                   
                }
                else
                    startAddress = ushort.Parse(txtStart.Text.Trim());

                if (rdbRead.Checked)
                {

                    ushort numRegisters = ushort.Parse(txtregister.Text.Trim());
                    ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);
                    comboBox1.Visible = true;
                    comboBox1.DataSource = registers;
                   
                  
                }
                else if (rdbWrite.Checked)
                {

                  // ushort[] data = { ushort.Parse(txt1.Text.Trim()), ushort.Parse(txt2.Text.Trim())};
                    ushort data = ushort.Parse(txt1.Text.Trim());
                    master.WriteSingleRegister(slaveId, startAddress, data);
                    MessageBox.Show("The operation was successful");

                }
            }
            catch (Exception ex)
            {
                if(ex.Message== "Object reference not set to an instance of an object.")
                        MessageBox.Show("ابتدا دکمه کانکت رو انتخاب کنید");
                else
                    MessageBox.Show(ex.Message);

                ClassGeneral.logError("error_log.txt", ex.Message, ex.StackTrace);


            }

        }

        private void btndis_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort.IsOpen)
                
                    {
                        serialPort.Close();
                    }
                    serialPort.Dispose();
                    pic.BackgroundImage = Properties.Resources.icons8_disconnected_30;
                btndis.Enabled = false;btnRtu.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClassGeneral.logError("error_log.txt", ex.Message, ex.StackTrace);

            }
        }

   

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)

                {
                    serialPort.Close();
                }
                serialPort.Dispose();
            }
            catch (Exception ex)
            {
                ClassGeneral.logError("error_log.txt", ex.Message, ex.StackTrace);

            }
        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbHex.Checked && txtStart.Text.Trim() != "")
                {
                    lbl.Text =ClassGeneral. ConvertHexAddressToDecimal(txtStart.Text.Trim()).ToString();
                }
                else
                    lbl.Text = "";
            }
            catch (Exception ex)
            {

                ClassGeneral.logError("error_log.txt", ex.Message, ex.StackTrace);


            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                ushort startAddress = 0;

                byte slaveId = byte.Parse(txtDevice.Text.Trim());
                if (rdbHex.Checked)
                {
                    string hexAddress = txtStart.Text.Trim();
                    startAddress = ushort.Parse(lbl.Text);

                }
                else
                    startAddress = ushort.Parse(txtStart.Text.Trim());

                 if (rdbWrite.Checked)
                {

                     ushort[] data = { ushort.Parse(txt1.Text.Trim()), ushort.Parse(txt2.Text.Trim())};
                   // ushort data = ushort.Parse(txt1.Text.Trim());
                    master.WriteMultipleRegisters(slaveId, startAddress, data);
                    MessageBox.Show("The operation was successful");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                ClassGeneral.logError("error_log.txt", ex.Message, ex.StackTrace);


            }
        }
    }
}
