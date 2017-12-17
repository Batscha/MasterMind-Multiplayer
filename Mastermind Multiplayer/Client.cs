using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Multiplayer
{
    class Client
    {
        public Socket socket = null;

        /// <summary>
        /// Stellt eine Verbindung zum angegebenen Server her
        /// </summary>
        /// <param name="ipAddress">IP-Adresse oder Hostname des Servers</param>
        /// <param name="port">Port-Nummer des Servers</param>
        public Client(String Address, int port)
        {
            try
            {

                //H/H/DS
                IPHostEntry hostInfo = Dns.GetHostByName(Address);
                System.Net.IPEndPoint ep = new System.Net.IPEndPoint(hostInfo.AddressList[0], port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ep);
                
            }
            catch (SecurityException ex)
            {
                throw new Exception("Fehler beim Herstellen der Verbindung zum Server, evtl. verursacht durch eine Firewall oder ähnliche Schutzmechanismen", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Herstellen der Verbindung zum Server", ex);
            }
        }


        public byte[] receive()
        {
            return null;
            //try
            //{
            //    int TimeOut = 500;
            //    int SleepTime = 50;
            //    int cnt = 0;
            //    MemoryStream mem = new MemoryStream();// Empfangspuffer
            //    byte[] buffer = new byte[1024];
            //    while (cnt < (TimeOut / SleepTime))
            //    {
            //        while (socket.Available > 0)
            //        {
            //            int bytesRead = socket.Receive(buffer, buffer.Length, SocketFlags.None);
            //            if (bytesRead <= 0) continue;
            //            mem.Write(buffer, 0, bytesRead);
            //        }
            //        //Thread.Sleep(SleepTime);
            //        if (mem.Length > 0 && socket.Available == 0)
            //        {
            //            return mem.ToArray();
            //        }
            //        else
            //        {
            //            cnt++;
            //        }
            //    }
            //    return null;
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}
        }
    }
}
