using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;
using GigManagementSystem.Repositories;

namespace GigManagementSystem.Repositories
{
    public class UserCalendarRepository : IUserCalendarRepository
    {
        private GigManagementSysContext context = null;
        public UserCalendarRepository()
        {
            context = new GigManagementSysContext();
        }
        public void AddCalendar(UserCalendar usercalendar)
        {
            context.UserCalendars.Add(usercalendar);
            context.SaveChanges();
        }

        public void DeleteCalendar(string EmailId)
        {

            List<UserCalendar> usercalendar = context.UserCalendars.Where(s => s.EmailId == EmailId).ToList();
            foreach(var uc in usercalendar)
            if (uc != null)
            {
                context.UserCalendars.Remove(uc);
                context.SaveChanges();
            }
        }

        public List<UserCalendar> GetUserCalendarBy(string EmailId)
        {

            //UserCalendar user = context.UserCalendars.SelectMany(s => s.EmailId == EmailId);
            List<UserCalendar> user = context.UserCalendars.Where(s => s.EmailId == EmailId).ToList();
            return user;
        }

        public List<UserCalendar> GetUserCalender()
        {
            return context.UserCalendars.ToList();
        }

        public void UpdateCalendar(UserCalendar usercalendar)
        {
            context.UserCalendars.Update(usercalendar);
            context.SaveChanges();
        }
    }
}
