using Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Socket.Server.Core;
using System.Net;
using System.IO;
namespace Server.GUI
{
    public partial class FormServerMain : Form
    {

        DefaultLogWriter logWriter;
        Socket.Server.Core.TCPServer server;
        private TextBoxWriter textBoxWriter;
        private delegate void delSetReceivedData(string filteredText, int filteredCount, string receivedText, int receivedCount);
        private delSetReceivedData _delSetReceivedData;
        public FormServerMain()
        {
            InitializeComponent();
            tbxLog.Multiline = true;
            tbxLog.WordWrap = true;
            tbxLog.ScrollBars = ScrollBars.Vertical;
            tbxLog.ReadOnly = true;

            textBoxWriter = new TextBoxWriter(tbxLog);
            Console.SetOut(textBoxWriter);
            logWriter = new DefaultLogWriter();

            _delSetReceivedData = new delSetReceivedData(SetReceivedData);

            tbxReceived.ReadOnly = true;
            tbxCountReceived.ReadOnly = true;
            tbxFiltered.ReadOnly = true;
            tbxCountFiltered.ReadOnly = true;
            tbxLog.ReadOnly = true;

           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = tbxIPAddress.Text;
                int port = Convert.ToInt32(tbxPort.Text);
                server = new Socket.Server.Core.TCPServer(ipAddress, port, logWriter);
                server.Start();
                btnStop.Enabled = true;
              
            }

            catch (System.FormatException)
            {
                MessageBox.Show("IP Address or Port does not have the correct format", "Error");
            }

            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("The server hasn't been started yet", "Error");
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                server.Stop();
            }
            else
            {
                MessageBox.Show("The server is already stopped", "Alert");
            }
         
        }

        public void SetReceivedData(string filteredText, int filteredCount, string receivedText, int receivedCount)
        {
            tbxReceived.ReadOnly = true;
            if (this.InvokeRequired)
            {
                this.Invoke(_delSetReceivedData, filteredText, filteredCount, receivedText, receivedCount);
            }
            else
            {
                tbxReceived.Text = receivedText;
                tbxCountReceived.Text = receivedCount.ToString();
                tbxFiltered.Text = filteredText;
                tbxCountFiltered.Text = filteredCount.ToString();
            }
        }


        
        private void tbxLog_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] lines = tbxLog.Lines;
                string lastLine = lines[lines.Length - 2];

                if (lastLine.IndexOf("Received", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    
                    string[] split = lastLine.Split(' ');
                    tbxReceived.Text = split[2];
                    tbxCountReceived.Text = split[2].Length.ToString();


                    
                    string filtered = split[2].Replace("ä", "");
                    filtered = split[2].Replace("ü", "");
                    filtered = split[2].Replace("ö", "");

                    tbxFiltered.Text = filtered;
                    tbxCountFiltered.Text = filtered.Length.ToString();


                }
            }
            
            catch(System.IndexOutOfRangeException)
            {
              
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxLog.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            server.Stop();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("serverlog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            File.WriteAllText("serverlog.txt", tbxLog.Text);
        }
    }
}
