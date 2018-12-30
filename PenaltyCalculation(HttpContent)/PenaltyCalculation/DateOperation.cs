using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PenaltyCalculation
{
    public class DateOperation
    {
        private DateOperation() 
        {
        
        }

        private static DateTime firstDate = Convert.ToDateTime(null);

        public static bool ControlStartEndDate(DateTime startDate, DateTime endDate)//Başlangıç tarihi bitiş tarihinden önce olamaz.
        {
            if (Convert.ToInt32(endDate.Subtract(startDate).TotalDays) >= 0)
            {
                return true;
            }
            else
                return false;
        }

        public static void ControlHolidayDate(DateTime date , List<DateTime> holidayDates)
        {           
            // Tarihin üstüne tıklandığında çalışan kod -Başlangıç ve Bitiş tarihlerinin tatil günü olup olmadığını kontrol eder-
            // Bu fonksiyondan sonra "CalendarName.SelectedDates.Clear()" yapılabilir.Bu calendar üzerinde seçilen tarihleri temizler
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int i = 0; i < holidayDates.Count(); i++)
                {
                    if (date == holidayDates.ElementAt(i))
                    {
                        HttpContext.Current.Response.Write("<script>alert('Tatil günü seçemezsiniz');</script>");
                    }
                }

            }
            else
            {
                HttpContext.Current.Response.Write("<script>alert('Tatil günü seçemezsiniz');</script>");
            }
        }

        public static int CalculateBusinessDay(DateTime startDate, DateTime endDate, List<DateTime> holidayDates)            
        {
            //Belirlenen iki tarih arasındaki tüm tatiller dışında kalan iş günü sayısını hesaplar
            if (startDate == firstDate || endDate == firstDate)
                HttpContext.Current.Response.Write("<script>alert('Herhangi bir tarih seçmediniz!');</script>");
            else if (!ControlStartEndDate(startDate, endDate))
                HttpContext.Current.Response.Write("<script>alert('Herhangi Veriş tarihi Alış tarihinden önce olamaz!');</script>");
            else
            {
                int penaltyCnt = 0;
                int cnt = Convert.ToInt32(endDate.Subtract(startDate).TotalDays);
                DateTime nextDay = startDate;
                for (int i = 0; i <= cnt; i++)
                {
                    for (int j = 0; j < holidayDates.Count(); j++)
                        if (nextDay == holidayDates.ElementAt(j) || nextDay.DayOfWeek == DayOfWeek.Saturday
                                                            || nextDay.DayOfWeek == DayOfWeek.Sunday)
                        {
                            if (i == 0 || i == cnt)
                            {
                                HttpContext.Current.Response.Write("<script>alert('Tatil günü seçemezsiniz');</script>");
                                return 0;
                            }
                            penaltyCnt--;
                            break;
                        }
                    nextDay = nextDay.AddDays(1);
                    penaltyCnt++;
                }
                return penaltyCnt;
            }
            return 0;
        }
    }
}