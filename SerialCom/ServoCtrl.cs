using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialCom
{
    public partial class ServoCtrl : Form
    {
        private const int MAX_RECV_DISP = 200;
        private SerialPort serialPort = new SerialPort();
        private List<byte> recvList = new List<byte>();

        public ServoCtrl()
        {
            InitializeComponent();
            //测试
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPort();
            CCbStopBits.SelectedIndex = 0;
            CCbBaudrate.SelectedIndex = 0;
            CCbCheckBit.SelectedIndex = 0;
            CCbDataBits.SelectedIndex = 3;
            cbDispMode.SelectedIndex = 1;
        }

        private void btnOpenOrClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else //串口关闭的话
            {
                serialPort.PortName = CCbPortNo.Text;
                serialPort.BaudRate = Convert.ToInt32(CCbBaudrate.Text);
                switch (CCbStopBits.SelectedIndex)
                {
                    case 0:
                        serialPort.StopBits = StopBits.One;
                        break;
                    case 1:
                        serialPort.StopBits = StopBits.Two;
                        break;
                    default:
                        break;
                }
                serialPort.DataBits = Convert.ToInt32(CCbDataBits.Text);
                serialPort.NewLine = "\r\n";
                int a = CCbCheckBit.SelectedIndex;
                switch (CCbCheckBit.SelectedIndex)
                {
                    case 0:
                        serialPort.Parity = Parity.None;
                        break;
                    case 1:
                        serialPort.Parity = Parity.Odd;
                        break;
                    case 2:
                        serialPort.Parity = Parity.Even;
                        break;
                    case 3:
                        serialPort.Parity = Parity.Mark;
                        break;
                    case 4:
                        serialPort.Parity = Parity.Space;
                        break;
                    default:
                        break;
                }
                serialPort.DataReceived += serialPort_DataReceived;
                
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            btnOpenOrClose.Text = serialPort.IsOpen ? "关闭串口" : "打开串口";
            btnSend.Enabled = serialPort.IsOpen ? true : false;
        }

        private void btnRefreshPort_Click(object sender, EventArgs e)
        {
            RefreshPort();
        }

        /// <summary>
        /// 刷新串口
        /// </summary>
        private void RefreshPort()
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            CCbPortNo.Items.Clear();
            CCbPortNo.Items.AddRange(ports);
            CCbPortNo.SelectedIndex = CCbPortNo.Items.Count > 0 ? 0 : -1;

            btnOpenOrClose.Enabled = (ports.Count() != 0);  //使能，防止误操作
            btnSend.Enabled = serialPort.IsOpen;
        }

        private void timerDisp_Tick(object sender, EventArgs e)
        {
            tbRecv.Text = GetRecvAreaDispStr(recvList);
        } 

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int recvNum = serialPort.BytesToRead;
            byte[] buf = new byte[recvNum];//声明一个临时数组存储当前来的串口数据

            serialPort.Read(buf, 0, recvNum);
            recvList.AddRange( buf );
            
            if(recvList.Count > MAX_RECV_DISP)
            {
                recvList.RemoveRange(0, recvList.Count - MAX_RECV_DISP);
            }

            //this.Invoke((EventHandler)(delegate
            //{
            //    tbRecv.Text = GetRecvAreaDispStr(recvList);
            //    Console.WriteLine( tbRecv.Text.Length );
            //}));  
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[6];
            buf[0] = Convert.ToByte(hsbServo1.Value);
            buf[1] = Convert.ToByte(hsbServo2.Value);
            buf[2] = Convert.ToByte(hsbServo3.Value);
            buf[3] = Convert.ToByte(hsbServo4.Value);
            buf[4] = Convert.ToByte(hsbServo5.Value);
            buf[5] = Convert.ToByte(hsbServo6.Value);
            
            serialPort.Write(buf.ToArray(), 0, 6);
        }

        #region 滑动时实时显示当前值
        private void hsbServo1_Scroll(object sender, ScrollEventArgs e)
        {
            lbServoAngle1.Text = hsbServo1.Value.ToString();
        }

        private void hsbServo2_Scroll(object sender, ScrollEventArgs e)
        {
            lbServoAngle2.Text = hsbServo2.Value.ToString();
        }

        private void hsbServo3_Scroll(object sender, ScrollEventArgs e)
        {
            lbServoAngle3.Text = hsbServo3.Value.ToString();
        }

        private void hsbServo4_Scroll(object sender, ScrollEventArgs e)
        {
            lbServoAngle4.Text = hsbServo4.Value.ToString();
        }

        private void hsbServo5_Scroll(object sender, ScrollEventArgs e)
        {
            lbServoAngle5.Text = hsbServo5.Value.ToString();
        }

        private void hsbServo6_Scroll(object sender, ScrollEventArgs e)
        {
            lbServoAngle6.Text = hsbServo6.Value.ToString();
        }
        #endregion

        private void btnClearRecv_Click(object sender, EventArgs e)
        {
            recvList.Clear();
            tbRecv.Text = "";
        }

        /// <summary>
        /// 字节数组转16进制字符串 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private string ByteToHexStr(List<byte> bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Count; i++)
                {
                    returnStr += bytes[i].ToString("X2") + " ";
                }
            }
            return returnStr;
        }

        private string ByteToAsciiStr(List<byte> bytes)
        {
            byte[] arrByte = new byte[bytes.Count];
            
            bytes.CopyTo(arrByte);
            string str = "";
            for (int i = 0; i < arrByte.Length; i++)
            {
                if (arrByte[i] == 0)
                    arrByte[i] = 0x20;
            }

                str = System.Text.Encoding.ASCII.GetString(arrByte);
            return str;
        }

        private string GetRecvAreaDispStr( List<byte> bytes )
        {
            string str = ""; ;
            switch( cbDispMode.SelectedIndex )
            {
                case 0:
                    str = String.Join(" ", bytes.ToArray());
                    break;
                case 1:
                    str = ByteToHexStr( bytes );
                    break;
                case 2:
                    str = ByteToAsciiStr( bytes );
                    break;
                default:
                    break;
            }
            return str;
        }

        private void cbDispMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbRecv.Text = GetRecvAreaDispStr( recvList );
        }

        


    }
}





#region 队列操作
//for (int i = 0; i < 133; i++)
//    distForDisp.Enqueue(i);
//while (distForDisp.Count != 0)
//    Console.WriteLine(distForDisp.Dequeue()+" ");
#endregion
