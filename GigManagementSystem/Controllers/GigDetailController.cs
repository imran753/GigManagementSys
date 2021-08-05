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
    public class GigDetailController : ControllerBase
    {
        private IGigDetailRepository context = null;
        public GigDetailController(IGigDetailRepository gigDetail)
        {
            this.context = gigDetail;
        }
        [HttpPost]
        [Route("AddDetails")]
        public string AddDetials(GigDetail gigdetail)
        {
            context.AddDetials(gigdetail);
            return "Added";
        }
        [HttpGet]
        [Route("GetDetails")]

        public List<GigDetail> GetDetails()
        {
            return context.GetDetails();
        }
        [HttpGet]
        [Route("GetDetailsBy/{email}")]

        public List<GigDetail> GetDetailsBy(string email)
        {
            return context.GetDetailsBy(email);
        }
        [HttpPut]
        [Route("UpdateDetails")]
        public void UpdateGig(GigDetail gigdetail)
        {
            context.UpdateGig(gigdetail);
        }
    }
}
