using IntroToMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToMVC.Controllers
{
    public class HolidayController : Controller
    {
        private const int NUMBER_OF_HOLIDAYS = 2;

        // GET: Holiday
        public ActionResult Index()
        {
            Random rand = new Random();
            Holiday holiday = new Holiday();
            int holidayCode = rand.Next(NUMBER_OF_HOLIDAYS);
            holiday.Name = holidayFactory(holidayCode);
            holiday.HowManyDaysToHoliday = howManyDaysTillHoliday(holidayCode);
            holiday.PicturePath = (holidayCode == 0) ? "~/Content/Images/QueensBirthday.jpg" : "~/Content/Images/BoxingDay.jpg";
            return View(holiday);
        }

        private int howManyDaysTillHoliday(int code)
        {
            DateTime date = DateTime.Now;
            DateTime queensBirthdayDate = new DateTime(date.Year, 6, 1);
            DateTime boxingDay = new DateTime(date.Year, 12, 26);

            int days = 0;

            switch (code)
            {
                case 0:
                    days = (queensBirthdayDate - date).Days;
                    break;
                case 1:
                    days = (boxingDay - date).Days;
                    break;
            }
            return days;
        }

        private string holidayFactory(int code)
        {
            string holiday = null;
            switch (code)
            {
                case 0:
                    holiday = "Queen's birthday";
                    break;
                case 1:
                    holiday = "Boxing day";
                    break;
            }
            return holiday;
        }
    }
}