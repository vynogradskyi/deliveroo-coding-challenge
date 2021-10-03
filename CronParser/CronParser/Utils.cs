using System;
using System.Text.RegularExpressions;

namespace CronParser
{
    public static class Utils
    {


        public static CronCommand Parse(string min, string hrs, string dayOfMonth, string month, string dayOfWeek)
        {

            Console.WriteLine("min/hrs/dom/m/dow: {0}/{1}/{2}/{3}/{4}", min, hrs, dayOfMonth, month, dayOfWeek);

            min = parseRegular(min, 59);
            hrs = parseRegular(hrs, 23);
            month = parseMonth(month);
            dayOfMonth = parseDayOfMonth(dayOfMonth);
            dayOfWeek = parseDayOfWeek(dayOfWeek);

            return new CronCommand()
            {
                Minutes = min,
                Hours = hrs,
                DayOfMonth = dayOfMonth,
                Month = month,
                DayOfWeek = dayOfWeek
            };

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

        public static string parseMonth(string cronItem)
        {
            if (isNotContainsSpecial(cronItem) && noWords(cronItem))
            {
                return parseRegular(cronItem, 12);
            }

            //todo: for now i assume that if month is written buy words, it is only 3 letters (jul, jun etc, no june, july )

            var lowerCaseString = cronItem.ToLower();



            return "";
        }

        public static bool noWords(string cronItem)
        {
            var wordPattern = @"jan|feb|mar|apr|may|jun|jul|aug|sep|oct|nov|dec";
            var pattern = new Regex(wordPattern,RegexOptions.IgnoreCase);

            return !pattern.IsMatch(cronItem);
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
            if (str.Contains("W") || str.Contains("L") || str.Contains("#")) return false;

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
