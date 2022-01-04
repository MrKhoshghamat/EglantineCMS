using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace EglantineCMS
{
    public static class PersianConverterDate
    {
        public static string ToShamsi(this DateTime dateTime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(dateTime) + "/" + persianCalendar.GetMonth(dateTime).ToString("00") + 
                "/" + persianCalendar.GetDayOfMonth(dateTime).ToString("00");
        }
    }
}