using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(hostName);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, 1100);
            Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(remoteEndPoint);
                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                while (true)
                {
                    Console.Write("> ");
                    string message = Console.ReadLine();
                    byte[] buffer = Encoding.ASCII.GetBytes(message + "<EOF>");
                    int bytesSend = sender.Send(buffer);
                    if (message == "exit")
                    {
                        break;
                    }
                    buffer = new byte[1024];
                    message = string.Empty;
                    while (true)
                    {
                        int messageSize = sender.Receive(buffer);
                        message += Encoding.ASCII.GetString(buffer, 0, messageSize);
                        if (message.Contains("<EOF>"))
                        {
                            message = message.Replace("<EOF>", "");
                            break;
                        }
                    }
                    Console.WriteLine("echo: {0}", message);
                }
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
