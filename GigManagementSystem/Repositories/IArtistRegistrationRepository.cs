using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public interface IArtistRegistrationRepository
    {
        List<ArtistRegistration> GetArtist();
        ArtistRegistration GetArtistBy(string EmailId);
        void AddArtist(ArtistRegistration artistRegistration);
        void DeleteArtist(string EmailId);
        void UpdateArtist(ArtistRegistration artistRegistration);
    }
}
