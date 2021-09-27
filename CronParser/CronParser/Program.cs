using System;

namespace CronParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                var input = args[0];
                Console.WriteLine("Hello World!" + input);

            }
        }
    }
}
