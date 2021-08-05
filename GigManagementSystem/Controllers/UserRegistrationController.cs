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
    public class UserRegistrationController : ControllerBase
    {
        private IUserRegistrationRepository repository;
        
        public UserRegistrationController(IUserRegistrationRepository repository)
        {
            this.repository = repository;
        }
        //user registraion methods
        [HttpGet]
        [Route("GetAllUsers")]
        public List<UserRegistration> GetUserRegistrations()
        {
            return repository.GetUserRegistrations();
        }
        [HttpGet]
        [Route("GetUserByEmail/{EmailId}")]
        public UserRegistration GetUserRegistrations(string EmailId)
        {
            return repository.GetUserRegistrationBy(EmailId);
        }
        [HttpPost]
        [Route("AddUser")]
        public string AddUser(UserRegistration userRegistration)
        {
            repository.AddUser(userRegistration);
            return "Registered Succesfully";
        }
        [HttpDelete]
        [Route("DeleteUser/{EmailId}")]
        public string DeleteUser(string EmailId)
        {
            repository.DeleteUser(EmailId);
            return "Deleted";
        }
        [HttpPut]
        [Route("UpdateUser")]
        public string UpdateUser(UserRegistration userRegistration)
        {
            repository.UpdateUser(userRegistration);
            return "Details Updated";
        }

        //end user registraion methods

        
    }
}
