using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexusDownloader
{
    /// <summary>
    /// The entry class of the application.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                string[] argParts = arg.Split('=');
                string argFlag = argParts[0].ToLower();
                string argValue = argParts[1].ToLower();
                Console.WriteLine("flag: {0}, value: {1}", argFlag, argValue);
            }
        }
    }
}
