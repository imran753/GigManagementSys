using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public interface IUserCalendarRepository
    {
        List<UserCalendar> GetUserCalender();//get all calendar details
        List<UserCalendar> GetUserCalendarBy(string EmailId);//get calendar detials by emailid
        void AddCalendar(UserCalendar usercalendar);//add calendar
        void DeleteCalendar(string EmailId);//delete calendar
        void UpdateCalendar(UserCalendar usercalendar);//update calendar
    }
}
