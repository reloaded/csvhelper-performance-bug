using System;
using System.Diagnostics;
using System.IO;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.UtcNow;
            Console.WriteLine("Import Started at " + startTime.ToShortTimeString());


            if ( args.Length == 0 || string.IsNullOrWhiteSpace(args[0]) || !File.Exists(args[0]))
            {
                throw new Exception("Please specify path to customer CSV as first argument.");
            }

            var streamReader = File.OpenText(args[0]);

            var service = new CustomerCsvProcessorService(streamReader);

            service.StartAsync().Wait();

            var endTime = DateTime.UtcNow;

            Console.WriteLine("Import Ended at " + endTime.ToShortTimeString());
            Console.WriteLine("Run Time (ms): " + (endTime - startTime).TotalMilliseconds);

            Debugger.Break();
        }
    }
}
