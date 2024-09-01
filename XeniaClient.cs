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
        public int ProcId { get; set; } = Memory.XENIA_PROCESSID;

        public bool Connect()
        {
            Console.WriteLine("Connecting to Xenia");
            var pid = ProcId;
            if (pid == 0)
            {
                Console.WriteLine("Xenia not found.");
                Console.WriteLine("Press any key to exit.");
                Console.Read();
                System.Environment.Exit(0);
                return false;
            }
            return true;
        }
    }
}
