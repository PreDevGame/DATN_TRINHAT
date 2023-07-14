using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;


namespace WindowsFormsApp1
{
    public partial class frmConnect : Form
    {
        public object syncGate = new object();
        public Process process;
        public StringBuilder output = new StringBuilder();
        public bool outputChanged;
        public frmConnect()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart != null)
            {
                MessageBox.Show("opened!");
            }

            lock (syncGate)
            {
                if (process != null) return;
            }

            output.Clear();
            outputChanged = false;
            rtbLength.Text = "";
            process = new Process();
            process.StartInfo.FileName = @"C:\Users\DELL\AppData\Local\Programs\Python\Python311\python.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = Application.StartupPath + @"\Project01.py";
            process.StartInfo.RedirectStandardOutput = true;
            MessageBox.Show("Python file is running!");
            process.OutputDataReceived += OnOutputDataReceived;
            process.Exited += OnProcessExited;
            process.Start();
            process.BeginOutputReadLine();
        }
        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock (syncGate)
            {
                if (sender != process) return;
                output.AppendLine(e.Data);
                if (outputChanged) return;
                outputChanged = true;
                BeginInvoke(new Action(OnOutputChanged));
            }
        }

        private void OnOutputChanged()
        {
            lock (syncGate)
            {
                rtbLength.Text = output.ToString();
                outputChanged = false;
            }
        }

        private void OnProcessExited(object sender, EventArgs e)
        {
            lock (syncGate)
            {
                if (sender != process) return;
                process.Dispose();
                process = null;
            }
        }
        private void rtbLength_TextChanged(object sender, EventArgs e)
        {
            rtbLength.SelectionStart = rtbLength.Text.Length;
            rtbLength.ScrollToCaret();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Plc plc = new Plc(CpuType.S71200, txbIP.Text, 0, 0);
            if (plc.Open() == ErrorCode.NoError)
            {
                MessageBox.Show("Connected Successfully!");
                plc.Close();
            }
            else
            {
                MessageBox.Show("Cannot connect to PLC!");
            }
        }

        private void ckbQ0_CheckedChanged(object sender, EventArgs e)
        {
            Plc plc = new Plc(CpuType.S71200, txbIP.Text, 0, 0);
            if (plc.Open() == ErrorCode.NoError)
            {
                byte[] dataGui = new byte[10];
                if (ckbQ0.Checked)
                    dataGui[0] |= 0x01;
                else
                    dataGui[0] &= 0xfe;
                if (ckbQ1.Checked)
                    dataGui[0] |= 0x02;
                else
                    dataGui[0] &= 0xfd;
                plc.WriteBytes(DataType.Output, 0, 0, dataGui);
            }
            else
            {
                MessageBox.Show("Cannot connect to PLC!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
