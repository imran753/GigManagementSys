using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Repositories;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private GigManagementSysContext context = null;
        public UserRegistrationRepository()
        {
            context = new GigManagementSysContext();
        }

        public void AddUser(UserRegistration userRegistration)
        {
            context.UserRegistrations.Add(userRegistration);
            context.SaveChanges();
        }

        public void DeleteUser(string EmailId)
        {
            UserRegistration userRegistration = context.UserRegistrations.SingleOrDefault(s => s.EmailId == EmailId);
            if (userRegistration != null)
            {
                context.UserRegistrations.Remove(userRegistration);
                context.SaveChanges();
            }
        }

        public GigDetail GetGigDetailBy(string EmailId)
        {
            throw new NotImplementedException();
        }

        public GigDetail GetGigDetailBy1(string Venue)
        {
            throw new NotImplementedException();
        }

        public GigDetail GetGigDetailBy2(DateTime DateTime1)
        {
            throw new NotImplementedException();
        }

        public List<GigDetail> GetGigDetails()
        {
            throw new NotImplementedException();
        }

        public UserRegistration GetUserRegistrationBy(string EmailId)
        {
            UserRegistration user = context.UserRegistrations.SingleOrDefault(s => s.EmailId == EmailId);
            return user;
        }

        public List<UserRegistration> GetUserRegistrations()
        {
            return context.UserRegistrations.ToList();
        }

        public void UpdateUser(UserRegistration userRegistration)
        {
            context.UserRegistrations.Update(userRegistration);
            context.SaveChanges();
        }
    }
}
