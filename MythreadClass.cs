using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FrmBasicThread1
{
    class MythreadClass
    {
        public static void threads()
        {
            for (int loopcount = 0; loopcount  < 6; loopcount++)
            {
                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process= " + loopcount);
            }
        }
    }
}
