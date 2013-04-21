using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

using SlimDX.DirectInput;

namespace quadrotor
{
    public partial class Form1 : Form
    {

        SerialPort sp;
        DirectInput di = new DirectInput();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            var xxk = SerialPort.GetPortNames();

            foreach (var x in xxk)
                cbSerial.Items.Add(x);

            if (cbSerial.Items.Count != 0)
                cbSerial.SelectedIndex = 0;


            var xxd = di.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly);

            foreach (var x in xxd)

                cbPad.Items.Add(new xJoypad(x));

            if (cbPad.Items.Count != 0)
                cbPad.SelectedIndex = 0;
        }

        private void cbSerial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            if (sp != null) sp.Close();

            sp = new SerialPort(cbSerial.Text, 9600);

            sp.Open();

            lblSerialStatus.Text = "Open: " + sp.PortName;

        }

        
        Joystick jp;
        private void btnOpenPad_Click(object sender, EventArgs e)
        {
            if (jp != null)
                jp.Dispose();

            jp = new Joystick(di, (cbPad.SelectedItem as xJoypad).dix.InstanceGuid);
            jp.Acquire();

            lblPadStatus.Text = "Open: " + jp.Information.InstanceName;
        }

        float x0, y0, x1, y1;

        byte format(float v, int idx)
        {
            return (byte)(v * 32 + 32 + idx * 64);
        }
        static string strlog = "";

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (jp != null)
            {
                try
                {
                    var s = jp.GetCurrentState();

                    x0 = (s.X - 32768) / 32768.0f;
                    y0 = ((s.Y - 32768) / 32768.0f) * -1;
                    x1 = (s.RotationX - 32768) / 32768.0f *0.3f;
                    y1 = ((s.RotationY - 32768) / 32768.0f) * -0.3f;

                    y0 = Math.Max(-1, y0 * 2 - 1.5f);

                    lblState.Text = s.X + " " + s.Y + " " + s.Z + " " + s.RotationZ + "\n\r" + x0 + " " + y0 + " " + x1 + " " + y1;
                    var data = new byte[] { format(x0,0), format(y0,1), format(x1,2), format(y1,3) };
                    if (sp != null && sp.IsOpen)
                        sp.Write(data, 0, 4);

                    pictureBox1.Refresh();
                }
                catch (Exception ex)
                {
                    lblState.Text = "Error getting data";
                }
            }

            while (sp != null && sp.IsOpen && sp.BytesToRead > 0)
                strlog += (char)sp.ReadByte();

            strlog = String.Join("\n", strlog.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Reverse().Take(5).Reverse().ToArray());



            richTextBox1.Text = String.Join("\n", strlog.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Take(4).ToArray()); ;
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            var g = e.Graphics;

            g.Clear(Color.White);

            var r = Math.Min(w / 4 - 32, h / 2 - 32);

            g.FillEllipse(Brushes.Red, w / 4 - 16 + x0 * r, h / 2 - 16 - y0 * r, 32, 32);

            g.FillEllipse(Brushes.Red, w * 3 / 4 - 16 + x1 * r, h / 2 - 16 - y1 * r, 32, 32);
        }
    }

    class xJoypad
    {
        public DeviceInstance dix;
        public xJoypad(DeviceInstance d) { dix = d; }
        public override string ToString()
        {
            return dix.InstanceName;
        }
    }
}
