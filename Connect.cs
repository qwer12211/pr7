using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    public class ConnectClass
    {
        private Socket socket;
        private string ipadres;
        private int port;
        private CancellationTokenSource canceledSource;

        public ConnectClass(string ipAddress, int port)
        {
            ipadres = ipAddress;
            port = port;
        }

        public async Task ConnectAsync(CancellationToken cancellationToken)
        {
            canceledSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            await socket.ConnectAsync(IPAddress.Parse(ipadres), port);
        }

        public async Task SendMessageAsync(string message)
        {
            var noliki = Encoding.UTF8.GetBytes(message);
            await socket.SendAsync(noliki, SocketFlags.None);
        }

        public async Task<string> ReceiveMessageAsync()
        {
            byte[] noliki = new byte[1024];
            await socket.ReceiveAsync(noliki, SocketFlags.None);
            return Encoding.UTF8.GetString(noliki);
        }

        public void Close()
        {
            canceledSource.Cancel();
            socket.Close();
        }
    }
}
