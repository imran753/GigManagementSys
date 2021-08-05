using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Repositories;
using GigManagementSystem.Models;

namespace GigManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCalendarController : ControllerBase
    {
        //object declaration
        private IUserCalendarRepository calendar;
        public UserCalendarController(IUserCalendarRepository calendar)
        {
            this.calendar = calendar;
        }
        //calendar methods
        //get all calendars
        [HttpGet]
        [Route("GetAllUsersCalendars")]
        public List<UserCalendar> GetUserCalender()
        {
            return calendar.GetUserCalender();
        }
        //get all calendars by email
        [HttpGet]
        [Route("GetUserCalendarByEmail/{EmailId}")]
        public List<UserCalendar> GetUserCalendarBy(string EmailId)
        {
            return calendar.GetUserCalendarBy(EmailId);
        }
        //add a new calendar
        [HttpPost]
        [Route("AddCalendar")]
        public string AddCalendar(UserCalendar usercalendar)
        {
            calendar.AddCalendar(usercalendar);
            return "Registered Succesfully";
        }
        //delete calendar entries by email id
        [HttpDelete]
        [Route("DeleteUser/{EmailId}")]
        public string DeleteCalendar(string EmailId)
        {
            calendar.DeleteCalendar(EmailId);
            return "Deleted";
        }
        //update calendar entries
        [HttpPut]
        [Route("UpdateCalendar")]
        public string UpdateCalendar(UserCalendar usercalendar)
        {
            calendar.UpdateCalendar(usercalendar);
            return "Details Updated";
        }
    }
}
