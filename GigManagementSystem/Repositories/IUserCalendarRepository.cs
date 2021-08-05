using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public interface IUserCalendarRepository
    {
        List<UserCalendar> GetUserCalender();
        List<UserCalendar> GetUserCalendarBy(string EmailId);
        void AddCalendar(UserCalendar usercalendar);
        void DeleteCalendar(string EmailId);
        void UpdateCalendar(UserCalendar usercalendar);
    }
}
