using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace SerialPortPro
{
    public partial class Form1 : Form
    {
        //int x_s;
        //int y_s;
        string s;
        string url = "www.baidu.com";
        SerialPort sp1 = new SerialPort();
        //List<con_orignal_size> orignal_con = new List<con_orignal_size>();
        public Form1()
        {
            InitializeComponent();

            open.Click += new EventHandler(key_event);
            send_button.Click += new EventHandler(key_event);
            send_clear.Click += new EventHandler(key_event);
            rec_clear.Click += new EventHandler(key_event);
            open_html.Click += new EventHandler(key_event);

            MaximizeBox = false;
            baudrate.SelectedIndex = 3;
            databits.SelectedIndex = 3;
            stopbits.SelectedIndex = 0;
            parity.SelectedIndex = 0;

            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command");
            s = key.GetValue("").ToString();

            string[] str = SerialPort.GetPortNames();
            if (str.Length == 0)
                portname.Items.Add("无可用串口");
            else
            {
                foreach (string str1 in str)
                    portname.Items.Add(str1);
            }
            portname.SelectedIndex = 0;
            //Resize += new EventHandler(Mainform_Resize);
            //contrlsizeInit(this);
            //x_s = Width;
            //y_s = Height;
        }
        private void key_event(object sender, EventArgs e)
        {
            if (sender == open)
            {
                string text = this.open.Text;

                if (text == "打开串口")
                    open_com();
                else if (text == "关闭串口")
                {
                    sp1.Close();
                    portname.Enabled = true;
                    baudrate.Enabled = true;
                    databits.Enabled = true;
                    stopbits.Enabled = true;
                    parity.Enabled = true;
                    open.Text = "打开串口";
                }
            }
            else if (sender == send_button)
            {
                byte[] senddata = new byte[send_text.Text.Length * 2];
                if (send_ascii.Checked)
                    senddata = Encoding.ASCII.GetBytes(send_text.Text.Trim());
                else if (send_hex.Checked)
                    senddata = strToHexByte(send_text.Text.Trim().ToString());
                if (sp1.IsOpen)
                {
                    try
                    {
                        sp1.Write(senddata, 0, senddata.Length);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("发送失败", "错误");
                    }
                }
                else
                    MessageBox.Show("串口未打开", "错误");
            }
            else if (sender == send_clear)
                send_text.Clear();
            else if (sender == rec_clear)
                rec_text.Clear();
            else if (sender == open_html)
                System.Diagnostics.Process.Start(s.Substring(0, s.Length - 8), url);
        }

        private byte[] strToHexByte(string hexString)
        {
            bool flag = true;
            hexString = hexString.Replace(" ", "");
            foreach (char ch in hexString)
            {
                if (ch < 'A' || ch > 'f' || (ch > 'F' && ch < 'a'))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                if (hexString.Length % 2 != 0)
                    hexString += " ";
                byte[] returnByte = new byte[hexString.Length / 2];
                for (int i = 0; i < returnByte.Length; i++)
                    returnByte[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
                return returnByte;
            }
            else
            {
                MessageBox.Show("发送数据有误", "错误");
                return new byte[0];
            }
        }
        private void open_com()
        {
            bool flag = true;
            try
            {
                sp1.PortName = portname.Text;
                sp1.BaudRate = int.Parse(baudrate.Text);
                sp1.DataBits = int.Parse(databits.Text);
                sp1.StopBits = (StopBits)(stopbits.SelectedIndex + 1);
                sp1.Parity = (Parity)parity.SelectedIndex;
                //sp1.DtrEnable = true;
                //sp1.RtsEnable = true;
                sp1.Open();
                //rec_text.Text = sp1.PortName + "\n" +
                //                sp1.BaudRate + "\n" +
                //                sp1.DataBits + "\n" +
                //                sp1.StopBits + "\n" +
                //                sp1.Parity;
            }
            catch (Exception)
            {
                flag = false;
                MessageBox.Show("串口参数设置错误", "错误");
            }
            if (flag)
            {
                open.Text = "关闭串口";
                portname.Enabled = false;
                baudrate.Enabled = false;
                databits.Enabled = false;
                stopbits.Enabled = false;
                parity.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] str = SerialPort.GetPortNames();
            if (str.Length == 0)
            {
                portname.Items.Clear();
                portname.Items.Add("无可用串口");
            }
            for (int i = 0; i < str.Length; i++)
            {
                portname.Items.Remove("无可用串口");
                int cnt = portname.Items.Count;
                if (cnt > 0)
                {
                    for (int j = 0; j < cnt; j++)
                    {
                        if (str[i] != portname.GetItemText(portname.Items[j]))
                            portname.Items.Add(str[i]);
                    }
                }
                else
                    portname.Items.Add(str[i]);
            }
            if (sp1.IsOpen)
            {
                byte[] rec_data = new byte[sp1.BytesToRead];
                sp1.Read(rec_data, 0, rec_data.Length);
                add_rec_data(rec_data);
            }
            portname.SelectedIndex = 0;
        }
        private void add_rec_data(byte[] data)
        {
            string show_message = "";
            if (rec_hex.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                show_message = sb.ToString();
                show_message = show_message.ToUpper();
            }
            else if (rec_ascii.Checked)
                show_message = new ASCIIEncoding().GetString(data);
            rec_text.AppendText(show_message);
        }
        //private void Mainform_Resize(object sender, EventArgs e)
        //{
        //    float new_x = (float)Width / x_s;
        //    float new_y = (float)Height / y_s;
        //    set_controls(new_x, new_y, this);
        //}
        //    private void set_controls(float new_x, float new_y, Control cons)
        //    {
        //        int ctrlNo = 1;
        //        foreach (Control con in cons.Controls)
        //        {
        //            con.Width = (int)(orignal_con[ctrlNo].width * new_x);
        //            con.Height = (int)(orignal_con[ctrlNo].heigt * new_y);
        //            con.Left = (int)(orignal_con[ctrlNo].left * new_x);
        //            con.Top = (int)(orignal_con[ctrlNo].top * new_y);
        //            con.Font = new Font(con.Font.Name, orignal_con[ctrlNo].font_size * new_x);
        //            if (con.Controls.Count > 0)
        //            {
        //                set_controls(new_x, new_y, con);
        //            }
        //        }
        //        ctrlNo++;
        //    }
        //    public void contrlsizeInit(Control cons)
        //    {
        //        foreach (Control con in cons.Controls)
        //        {
        //            con_orignal_size con_size = new con_orignal_size();
        //            con_size.left = con.Left;
        //            con_size.top = con.Top;
        //            con_size.width = con.Width;
        //            con_size.heigt = con.Height;
        //            con_size.font_size = cons.Font.Size;
        //            orignal_con.Add(con_size);
        //            if(con.Controls.Count > 0)
        //            {
        //                contrlsizeInit(con);
        //            }
        //        }
        //    }
        //    public struct con_orignal_size
        //    {
        //        public int left;
        //        public int top;
        //        public int width;
        //        public int heigt;
        //        public float font_size;
        //    }
    }
}
