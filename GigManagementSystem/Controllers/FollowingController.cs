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
    public class FollowingController : ControllerBase
    {
        private IFollowingRepository context = null;
        public FollowingController(IFollowingRepository followingDetail)
        {
            this.context = followingDetail;
        }
        [HttpPost]
        [Route("AddDetails")]
        public string AddDetials(Following following)
        {
            context.AddDetials(following);
            return "Added";
        }
        [HttpGet]
        [Route("GetDetails")]

        public List<Following> GetDetails()
        {
            return context.GetDetails();
        }
        [HttpGet]
        [Route("GetDetailsBy/{email}")]

        public List<Following> GetDetailsBy(string email)
        {
            return context.GetDetailsBy(email);
        }
        [HttpPut]
        [Route("UpdateDetails")]
        public void UpdateGig(Following following)
        {
            context.UpdateGig(following);
        }
    }
}
