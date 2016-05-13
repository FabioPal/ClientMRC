using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fabio;
        private void button1_Click(object senderObj, EventArgs e)
        {
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024];

            // Connect to a remote device.
            try
            {
                IPAddress ipAddress;
                //Controlla se l'indirizzo IP è in formato valido
                if (!IPAddress.TryParse((ipBox.Text), out ipAddress))
                {
                    MessageBox.Show("Inserisci un indirizzo IP valido", "Errore");
                }
                else
                {
                    // Establish the remote endpoint for the socket.
                    UInt16 portNum = UInt16.Parse(portBox.Text);
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, portNum);
                    // Create a TCP/IP  socket.
                    Socket sender = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);

                    // Connect the socket to the remote endpoint. Catch any errors.
                    try
                    {
                        sender.Connect(remoteEP);

                        Console.WriteLine("Socket connected to {0}",
                            sender.RemoteEndPoint.ToString());

                        // Encode the data string into a byte array.
                        byte[] msg = Encoding.ASCII.GetBytes(msgBox.Text + "<EOF>");

                        // Send the data through the socket.
                        int bytesSent = sender.Send(msg);

                        // Release the socket.
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();
                    }

                    catch (ArgumentNullException ane)
                    {
                        MessageBox.Show("Errore nell'invio del messaggio", "Errore");
                        Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("Errore nella socket", "Errore");
                        Console.WriteLine("SocketException : {0}", se.ToString());
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Errore non previsto", "Errore");
                        Console.WriteLine("Unexpected exception : {0}", e.ToString());
                    }
                }

            }
            catch (Exception exce)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void msgBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Testo cambiato");
        }
    }
}
