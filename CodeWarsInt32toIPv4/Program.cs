using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsInt32toIPv4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UInt32ToIP(1391959717));
            Console.WriteLine(UInt32ToIP(610294945));
            Console.WriteLine(UInt32ToIP(0));
            Console.ReadLine();
        }

        public static string UInt32ToIP(uint ip)
        {
            string strIP = Convert.ToString(ip, 2);
            strIP = strIP.PadLeft(32, '0');
            Console.WriteLine(strIP);
            Console.WriteLine(strIP.Length);
            List<uint> byteList = new List<uint>();        
            for (int i = 0; i < 4; i++)
            {
                string value = new string(strIP.Skip((i * 8)).Take(8).ToArray());
                uint bffr = Convert.ToUInt32(value, 2);
                byteList.Add(bffr);
            }         
            return string.Join(".", byteList);
        }
    }
}
