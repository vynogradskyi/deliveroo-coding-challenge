using System;

namespace CronParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo: validate: exactly 6 params, each param is valid (https://docs.oracle.com/cd/E12058_01/doc/doc.1014/e12030/cron_expressions.htm)
            //todo: handle more complicated cases with seconds and years
            //todo: handle more complicated cases like */15,15-18,48 in one CronItem
            //todo: I didn't get wat "C" is doing, so not working on it now.
            var inputParam = args[0];
            var splitParam = inputParam.Split(' ');


            var command = splitParam[5];
            Console.WriteLine("command: {0}", command);


            var cc = Utils.Parse(splitParam[0], splitParam[1], splitParam[2], splitParam[3], splitParam[4]);
            cc.Commmand = splitParam[5];

            Console.WriteLine("minute:{0}", cc.Minutes);
            Console.WriteLine("hour:{0}", cc.Hours);
            Console.WriteLine("day of month:{0}", cc.DayOfMonth);
            Console.WriteLine("month:{0}", cc.Month);
            Console.WriteLine("day of week:{0}", cc.DayOfWeek);
            Console.WriteLine("command:{0}", cc.Commmand);
        }

    }
}
