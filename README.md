# deliveroo-coding-challenge

## Assumptions made during implementations
- No special words like @yearly
- No error handling, i mean it
    - if i would work on such task in real life, there would be one ofc
- Command doesn't have spaces
    - in case it is, it is easy to fix in future
- No refactoring and naming isn't perfect
    - As i was trying to put myself into 3hrs timeframe w/ README i was in a rush a bit, so i would definitely refactor, and rename some of the code
- No validation - validation should be added later
    - Parameter validation (input is string in proper format)
    - String contains 6 values split by space mins/hours/day-of-week/month/day-of-month/command
    - every Cron item of the string is in correct [format][https://docs.oracle.com/cd/E12058_01/doc/doc.1014/e12030/cron_expressions.htm]


## Not achieved

I was able to implement only basic scenario in a given time. No special letters or symbols like: L, W, C, #. No reserved words for Months and Dys like (Jan, Jul, Mon, Wed etc). 

## Installation
version of the framework is *.Net Core 3.1*

- [install dotnet on your machine][https://docs.microsoft.com/en-us/dotnet/core/install/] 
- go to solution folder (one where CronParser.sln is)
- to build the project run: `dotnet build CronParser.sln`
- to run tests: `dotnet test`
- to run script: `dotnet run -p CronParser/CronParser.csproj "{string here}"`
    for example: `dotnet run -p CronParser/CronParser.csproj "*/15 0 1,15 * 1-5 /usr/bin/find"`