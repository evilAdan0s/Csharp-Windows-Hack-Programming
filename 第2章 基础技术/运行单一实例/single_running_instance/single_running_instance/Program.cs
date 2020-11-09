using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace single_running_instance
{
    class Program
    {
        Boolean isAlreadyRun()
        {
            bool isRun;
            Process currentProcess = Process.GetCurrentProcess();
            string currentProcessName = currentProcess.ProcessName;
            Mutex mutex = new Mutex(true, currentProcessName, out isRun);
            return isRun;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            if (program.isAlreadyRun())
            {
                Console.WriteLine("NOT Already Run!");
            }
            else
            {
                Console.WriteLine("Already Run!");
            }
            Console.ReadKey();
        }
    }
}
