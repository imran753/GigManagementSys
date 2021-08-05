using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Repositories;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public class ArtistRegistrationRepository: IArtistRegistrationRepository
    {
        private GigManagementSysContext context = null;

        public ArtistRegistrationRepository()
        {
            context = new GigManagementSysContext();
        }

        public void AddArtist(ArtistRegistration artistRegistration)
        {
            context.ArtistRegistrations.Add(artistRegistration);
            context.SaveChanges();
        }

        public void DeleteArtist(string EmailId)
        {
            ArtistRegistration artistRegistration = context.ArtistRegistrations.SingleOrDefault(s => s.EmailId == EmailId);
            if (artistRegistration != null)
            {
                context.ArtistRegistrations.Remove(artistRegistration);
                context.SaveChanges();
            }
        }

        public List<ArtistRegistration> GetArtist()
        {
            return context.ArtistRegistrations.ToList();
        }

        public ArtistRegistration GetArtistBy(string EmailId)
        {
            ArtistRegistration staffMaster = context.ArtistRegistrations.SingleOrDefault(s => s.EmailId == EmailId);
            return staffMaster;
        }

        public ArtistRegistration GetArtistBy(decimal ArtistID)
        {
            throw new NotImplementedException();
        }

        public void UpdateArtist(ArtistRegistration artistRegistration)
        {
            context.ArtistRegistrations.Update(artistRegistration);
            context.SaveChanges();
        }
    }
}
