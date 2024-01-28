using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatTest
{
    public partial class Form1 : Form
    {
        public Socket socket, ns;
        public IPEndPoint ep;
        public Form1()
        {
            InitializeComponent();

        }


        public void MyAcceptCallbakFunction(IAsyncResult ia)
        {   //получаем ссылку на слушающий сокет
            socket = (Socket)ia.AsyncState;
            //получаем сокет для обмена данными с клиентом
            ns = socket.EndAccept(ia);

            //создаем буфер и записываем в него сообщение получиенное от клиента
            byte[] buf = new byte[1024];
            int l = ns.Receive(buf);
            Invoke((MethodInvoker)delegate
            {
                textBox1.Text += System.Text.Encoding.Unicode.GetString(buf, 0, l) + "\r\n";
            });
            ns.Send(buf, 0, buf.Length, SocketFlags.None);

            //возобновляем асинхронный Accept
            socket.BeginAccept(new AsyncCallback(MyAcceptCallbakFunction), socket);
            ns.Shutdown(SocketShutdown.Both);
            ns.Close();
        }

        private void button1_Click(object sender, EventArgs e)//подключение
        {
            if (socket != null)
                return;
            //создаем новый сокет 
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //связываем сокет по нашему порту с ip адресом к которому могут подключаться с разных интерфесов
            socket.Bind(new IPEndPoint(IPAddress.Any, (int)PortText.Value));
            //устонавливаем прослушивание на 10 входящих вызовов(одновременно)
            socket.Listen(10);
            //начинаем ассинхронное прослушивание
            socket.BeginAccept(new AsyncCallback(MyAcceptCallbakFunction), socket);
        }

        private void button2_Click(object sender, EventArgs e)// отправить сообщение
        {
            //создаем новый сокет
            Socket ss = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //создаем новый  endPoint с ip адрессом к которому хотим подключиться
            ep = new IPEndPoint(IPAddress.Parse(IPText.Text), (int)PortText.Value);
            if (!ss.Connected) ss.Connect(ep);
            //кодируем и отправляем наше сообщение клиенту
            ss.Send(System.Text.Encoding.Unicode.GetBytes(msgText.Text));
            //выводим наше сообщение в textbox с пометкой отправленно
            textBox1.Text += "=> " + msgText.Text + "\r\n";
            //отключаемся от сервера
            ss.Shutdown(SocketShutdown.Both);
            ss.Close();
        }
    }
}
