using System;
namespace CronParser
{
    public class CronCommand
    {
        public string Minutes { get; set; }
        public string Hours { get; set; }
        public string DayOfMonth { get; set; }
        public string Month { get; set; }
        public string DayOfWeek { get; set; }
        public string Commmand { get; set; }

        //todo: create ToString overload
    }
}
