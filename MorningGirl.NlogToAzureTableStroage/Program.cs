using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.NlogToAzureTableStroage
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Start Log Test");

            logger.Error("Errorですよ！！");

            Console.WriteLine("End Log Test");
        }
    }
}
