using System;
namespace CronParser
{
    public static class Utils
    {
        public static string[] SplitInputToCronAndCommand(string str)
        {
            return new string[] { };
        }

        //this method is validating CronString to requirements mentioned in tech task
        public static bool ValidateCronString(string str)
        {
            return false;
        }

        public static CronCommand ParseCron(string str)
        {
            return new CronCommand();
        }
    }
}
