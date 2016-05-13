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
        private void button1_Click(object senderObj, EventArgs e)
        {
            // Buffer per i dati in uscita
            byte[] bytes = new byte[1024];

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
                    // Crea l'endpoint remoto della socket
                    UInt16 portNum = UInt16.Parse(portBox.Text);
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, portNum);
                    //  Crea una socket TCP/IP
                    Socket sender = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);

                    //Connettiti alla socket
                    try
                    {
                        sender.Connect(remoteEP);

                        Console.WriteLine("Socket connected to {0}",
                            sender.RemoteEndPoint.ToString());

                        // Converte il messaggio da inviare, secondo il protocollo adottato, in un array di byte
                        //concluso da un carattere terminatore (EOF)
                        //IL MESSAGGIO INVIATO HA LA SEGUENTE STRUTTURA:
                        // idSensore#temperatura#umidità#pressione<EOF>
                        byte[] msg = Encoding.ASCII.GetBytes(idBox.Text + "#" + tempBox.Text + "#" + humBox.Text + "#"+ presBox.Text + "<EOF>");

                        // Invia i dati tramite la socket
                        int bytesSent = sender.Send(msg);

                        // Rilascia la socket
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();
                    }

                    //Gestione delle eccezioni
                    catch (ArgumentNullException ane)
                    {
                        MessageBox.Show("Errore nell'invio del messaggio", "Errore");
                        Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("Errore nella socket: \n" + se.Message.ToString(), "Errore");
                        Console.WriteLine("SocketException : {0}", se.ToString());
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("I campi del messaggio non possono essere vuoti", "Errore");
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Errore non previsto", "Errore");
                        Console.WriteLine("Unexpected exception : {0}", e.ToString());
                    }
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Il campo numero di porta non può essere vuoto", "Errore");
            }
            catch (Exception exce)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
