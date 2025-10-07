using Logging;
using Socket.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUI
{
    public partial class FormClientMain : Form
    {
        DefaultLogWriter logWriter = new DefaultLogWriter();
        ClientClass client;
        private TextBoxWriter textBoxWriter;
        public FormClientMain()
        {
            InitializeComponent();
            btnSend.Enabled = false;
            tbxMessage.Enabled = false;

            textBoxWriter = new TextBoxWriter(tbxReceived);
            Console.SetOut(textBoxWriter);

            tbxReceived.ReadOnly = true;
            tbxCount.ReadOnly = true;
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tbxReceived.Text = "";
            if(tbxMessage.Text != "")
            {
                client.RequestResponse(tbxMessage.Text);
                tbxMessage.Text = "";
                string[] split1 = tbxReceived.Text.Split(' ');
                string[] split2 = split1[3].Split(';');
                tbxReceived.Text = split2[0];

                tbxCount.Text = Regex.Replace(split2[1], @"\D", "");        //Only the count will be displayed

            }
            else
            {
                MessageBox.Show("Please enter a message", "No message entered");
            }
            
        
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIP = tbxIPAddress.Text;
                int serverPort = Convert.ToInt32(tbxPort.Text);
                client = new ClientClass(serverIP, serverPort);

                btnSend.Enabled = true;
                tbxMessage.Enabled = true;
                btnConnect.Enabled = false;
                tbxReceived.Text = "";

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


        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            tbxReceived.Text = "";
            client.Close();
        }

    }
}
