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
            var inputParam = args[0];
            var splitParam = inputParam.Split(' ');


            var command = splitParam[5];
            Console.WriteLine("command: {0}", command);


            Utils.Parse(splitParam[0], splitParam[1], splitParam[2], splitParam[3], splitParam[4]);

        }

    }
}
