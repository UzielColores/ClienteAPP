using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_App
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private byte[] sendData;
        public Form1()
        {
            InitializeComponent();

            logTxt.ScrollBars = ScrollBars.Vertical;
            contentTxt.ScrollBars = ScrollBars.Vertical;
            panel2.Enabled = false;
            panel3.Enabled = false;
        }

        private void ConectBttn_Click(object sender, EventArgs e)
        {
            string ip = ipTxt.Text;
            int port = Convert.ToInt32(portTxt.Text);
            client = new TcpClient();
            client.Connect( ip, port ); // Conecta al servidor local en el puerto 8888
            stream = client.GetStream();
            Log("Conected To Server :) ");

            panel2.Enabled = true;
            panel3.Enabled = true;
            //iniciamos el hilo para recibir
            StartReceiving();
        }


        private void StartReceiving()
        {
            // Iniciar un hilo para escuchar mensajes del servidor
            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();
        }

        private void ReceiveMessages()
        {
            byte[] receivedData = new byte[4096];
            int bytesRead;

            while (true)
            {
                try
                {
                    // Bloquea hasta que recibe un mensaje del servidor
                    bytesRead = stream.Read(receivedData, 0, receivedData.Length);
                }
                catch
                {
                    // Se ha producido un error de lectura
                    break;
                }

                if (bytesRead == 0)
                {
                    // El servidor ha cerrado la conexión
                    break;
                }

                // Decodificar el mensaje recibido y convertirlo a una cadena
                string incomingMessage = Encoding.ASCII.GetString(receivedData, 0, bytesRead);

                // Mostrar el mensaje en el label
                Log("REC<<<: " + incomingMessage);
            }
        }

        private void Log(string message)
        {
            if (logTxt.InvokeRequired)
            {
                logTxt.Invoke(new Action<string>(Log), new object[] { message });
            }
            else
            {
                logTxt.AppendText(message + Environment.NewLine);
            }
        }

        private void sendBttn_Click(object sender, EventArgs e)
        {
            string message = contentTxt.Text;
            if (!string.IsNullOrEmpty(message))
            {
                sendData = Encoding.ASCII.GetBytes(message);
                stream.Write(sendData, 0, sendData.Length);
                Log("SENT >>>: " + message);
            }
            else
            {
                Log("Message cannot be empty.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta al archivo (puedes ajustarla según tu ubicación)
                string source = @"C:\Users\color\source\repos\UzielColores\Cliente App\Cliente App\Resources\Datos.txt";
                string textoArch = File.ReadAllText(source);

                if (!string.IsNullOrEmpty(textoArch))
                {
                    sendData = Encoding.ASCII.GetBytes(textoArch);
                    stream.Write(sendData, 0, sendData.Length);
                    Log("Sent: " + textoArch);
                }
                else
                {
                    Log("Message cannot be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            panel3.Enabled = false;
            DisconnectFromServer();
        }

        private void DisconnectFromServer()
        {
            if (client != null)
            {
                client.Close();
                Log("Disconnected from server.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logTxt.Text = string.Empty;
        }
    }
}
