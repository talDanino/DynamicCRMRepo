using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace MatrixLog4Net
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        static void Main(string[] args)
        {
            log4netFunction();
            Console.ReadLine();
        }

        public static void log4netFunction()
        {
            int input;
            var watch = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Please enter a number: ");
            input = int.Parse(Console.ReadLine());

            GlobalContext.Properties["INPUT"] = input;

            watch.Start();

            for (int i = 0; i < input; i++)
            {
                continue;
            }

            watch.Stop();

            Console.WriteLine($"Loop Execution Time: {watch.ElapsedMilliseconds} ms");

            log.Info("");
        }
    }
}
