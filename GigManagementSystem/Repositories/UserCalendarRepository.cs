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
        //object creation for gigmanagementsys context
        private GigManagementSysContext context = null;
        public UserCalendarRepository()
        {
            context = new GigManagementSysContext();
        }
        //add calendar implementation
        public void AddCalendar(UserCalendar usercalendar)
        {
            context.UserCalendars.Add(usercalendar);
            context.SaveChanges();
        }
        //delete calendar implementation
        public void DeleteCalendar(string EmailId)
        {
            //get calendar entries and convert it to list
            List<UserCalendar> usercalendar = context.UserCalendars.Where(s => s.EmailId == EmailId).ToList();
            //delete each entry fetched by where()
            foreach(var uc in usercalendar)
            if (uc != null)
            {
                context.UserCalendars.Remove(uc);
                context.SaveChanges();
            }
        }
        //get calendar by email
        public List<UserCalendar> GetUserCalendarBy(string EmailId)
        {

            //UserCalendar user = context.UserCalendars.SelectMany(s => s.EmailId == EmailId);
            List<UserCalendar> user = context.UserCalendars.Where(s => s.EmailId == EmailId).ToList();
            return user;
        }
        //get all calendar
        public List<UserCalendar> GetUserCalender()
        {
            return context.UserCalendars.ToList();
        }
        //update calendar
        public void UpdateCalendar(UserCalendar usercalendar)
        {
            context.UserCalendars.Update(usercalendar);
            context.SaveChanges();
        }
    }
}
