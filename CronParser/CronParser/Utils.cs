using System;
namespace CronParser
{
    public static class Utils
    {


        public static void Parse(string min, string hrs, string dayOfMonth, string month, string dayOfWeek)
        {

            Console.WriteLine("min/hrs/dom/m/dow: {0}/{1}/{2}/{3}/{4}", min, hrs, dayOfMonth, month, dayOfWeek);

            min = parseRegular(min, 59);
            hrs = parseRegular(hrs, 23);
            month = parseRegular(month, 31);
            dayOfMonth = parseDayOfMonth(dayOfMonth);
            dayOfWeek = parseDayOfWeek(dayOfWeek);

        }

        public static string parseRegular(string cronItem, int max)
        {
            if (cronItem == "*") return makeResult(0, 1, max);

            if (cronItem.Contains(",")) return cronItem.Replace(",", " ");

            if (cronItem.StartsWith("*/"))
            {
                var step = int.Parse(cronItem.Remove(0, 2));
                return makeResult(0, step, max);
            }

            if (cronItem.Contains("-")){
                var items = cronItem.Split("-");

                return makeResult(int.Parse(items[0]), 1, int.Parse(items[1]));
            }

            return cronItem;
        }

        public static string parseDayOfMonth(string cronItem)
        {
            if (isNotContainsSpecial(cronItem)) return parseRegular(cronItem, 31);

            return "";
        }

        public static string parseDayOfWeek(string cronItem)
        {
            if (isNotContainsSpecial(cronItem)) return parseRegular(cronItem, 7);

            return "";
        }

        public static bool isNotContainsSpecial(string str)
        {
            if (str.Contains("W") || str.Contains("C") || str.Contains("L") || str.Contains("#")) return false;

            return true;
        }

        public static string makeResult(int start, int step, int max)
        {
            var res = "";
            var resInt = new int[]{};
            for (var i = start; i <= max; i += step)
            {
                res = res + i + " ";
            }

            return res.TrimEnd();
        }
    }
}
