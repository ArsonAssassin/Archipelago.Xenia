using Archipelago.Core;
using Archipelago.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archipelago.Xenia
{
    public class XeniaClient : IGameClient
    {
        public bool IsConnected { get; set; }
        public int ProcId { get; set; }
        public string ProcessName { get; set; }
        public XeniaClient()
        {

            ProcessName = "Xenia";
            ProcId = Memory.GetProcIdFromExe(ProcessName);
        }
        public bool Connect()
        {
            Console.WriteLine($"Connecting to {ProcessName}");
            var pid = ProcId;
            if (pid == 0)
            {
                Console.WriteLine($"{ProcessName} not found.");
                Console.WriteLine("Press any key to exit.");
                Console.Read();
                System.Environment.Exit(0);
                return false;
            }
            return true;
        }
    }
}
