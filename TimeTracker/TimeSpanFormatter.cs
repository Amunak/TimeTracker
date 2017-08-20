using System;

namespace TimeTracker
{
    public static class TimeSpanFormatter
    {
        /// <summary>
        /// Formats a TimeSpan value
        /// </summary>
        /// <param name="timeSpan">The timespan to be formatted</param>
        /// <returns>The formatted string</returns>
        public static String Format(TimeSpan timeSpan)
        {
            if (timeSpan.TotalDays > 1)
                return timeSpan.ToString("d\\d\\ hh\\:mm\\:ss");

            if (timeSpan.TotalHours > 1)
                return timeSpan.ToString("h\\:mm\\:ss");

            return timeSpan.ToString("m\\:ss");
        }
    }
}
