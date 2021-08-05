using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public interface IUserRegistrationRepository
    {
        List<UserRegistration> GetUserRegistrations();
        UserRegistration GetUserRegistrationBy(string EmailId);
        void AddUser(UserRegistration userRegistration);
        void DeleteUser(string EmailId);
        void UpdateUser(UserRegistration userRegistraion);
    }
}
