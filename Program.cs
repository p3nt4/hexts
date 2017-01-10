using System;
using System.Net;
using System.Net.Sockets;


namespace hexcat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IPAddress ip;
            int port;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try {
                ip = IPAddress.Parse(args[0]);
            }
            catch {
                try
                {
                    ip = Dns.GetHostEntry(args[0]).AddressList[0];
                }
                catch
                {
                    Console.WriteLine("Error parsing IP Address or resolving Host Name.");
                    return;
                }
            }
            try
            {
                port = Int32.Parse(args[1]);
            }
            catch {
                Console.WriteLine("Error parsing Port number.");
                return;
            }
            try
            {
                s.Connect(ip, port);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            byte[] msg = null;
            for (int i = 2; i < args.Length; i++) {
                if (args[i].Length > 1)
                {
                    try
                    {
                        msg = Utils.HexStringToByteArray(args[i]);
                    }
                    catch {
                        Console.WriteLine("Error parsing HEX string.");
                        return;
                    }
                    Send(s, msg);
                }
                Receive(s);
            }
            s.Disconnect(true);
            s.Close();
        }

        public static int Send(Socket server, byte[] msg)
        {
            String frame = "--------------------------------Sending " + msg.Length + " bytes------------------------------------";
            frame = frame.Substring(0, 78);
            Console.WriteLine(frame);
            Console.WriteLine(Utils.HexDump(msg, msg.Length));
            byte[] bytes = new Byte[4096];
            try
            {
                // Blocks until send returns.
                int byteCount = server.Send(msg, SocketFlags.None);
                //Console.WriteLine("Sent {0} bytes.", byteCount);
            }
            catch (SocketException e)
            {
                Console.WriteLine("{0} Error code: {1}.", e.Message, e.ErrorCode);
                return (e.ErrorCode);
            }
            return 0;
        }

        public static int Receive(Socket server)
        {
            byte[] bytes = new Byte[4096];
            try
            {
                int byteCount;           
                // Get reply from the server.
                byteCount = server.Receive(bytes, SocketFlags.None);
                if (byteCount > 0)
                {
                    String frame = "--------------------------------Received " + byteCount + " bytes-----------------------------------";
                    frame = frame.Substring(0, 78);
                    Console.WriteLine(frame);
                    Console.WriteLine(Utils.HexDump(bytes, byteCount));

                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("{0} Error code: {1}.", e.Message, e.ErrorCode);
                return (e.ErrorCode);
            }
            return 0;
        }

    }
}


