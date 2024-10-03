using System.Security.Cryptography.X509Certificates;

namespace Dima.Core.Common.Extentions;

public static class DateTimeExtention
{
    public static DateTime GetFirstDay(this DateTime time, int? year = null, int? month = null)
    {
        return new DateTime(year ?? time.Year, month ?? time.Month, 1);
    }
    public static DateTime GetLastDay(this DateTime time, int? year = null, int? month = null)
    {
        return new DateTime(year ?? time.Year, month ?? time.Month, 1).AddMonths(1).AddDays(-1);
    }
}