using System.Globalization;
using System;

namespace AulaExtensionMethods.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) // this referencia o próprio objeto, sem a necessidade de parametrizar na chamada
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
