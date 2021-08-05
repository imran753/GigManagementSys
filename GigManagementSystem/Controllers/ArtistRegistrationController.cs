using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;
using GigManagementSystem.Repositories;

namespace GigManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistRegistrationController : ControllerBase
    {
        private IArtistRegistrationRepository repository;
        public ArtistRegistrationController(IArtistRegistrationRepository repository)
        {
            this.repository = repository;

        }
        //Action methods
        [HttpGet]
        [Route("GetAllArtists")]
        public List<ArtistRegistration> GetArtists()
        {
            return repository.GetArtist();
        }
        [HttpGet]
        [Route("GetArtistsByEmail/{EmailId}")]
        public ArtistRegistration GetArtist(string EmailId)
        {
            return repository.GetArtistBy(EmailId);
        }
        [HttpPost]
        [Route("AddArtist")]
        public string AddArtist(ArtistRegistration artistRegistration)
        {
            repository.AddArtist(artistRegistration);
            return "Registered Succesfully";
        }
        [HttpDelete]
        [Route("DeleteArtist/{EmailId}")]
        public string DelArtist(string EmailId)
        {
            repository.DeleteArtist(EmailId);
            return "Deleted";
        }
        [HttpPut]
        [Route("UpdateArtist")]
        public string UpdateArtist(ArtistRegistration artistRegistration)
        {
            repository.UpdateArtist(artistRegistration);
            return "Details Updated";
        }
    }
}
