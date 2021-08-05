using GigManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigManagementSystem.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private GigManagementSysContext context = null;
        public FollowingRepository()
        {
            context = new GigManagementSysContext();
        }
        public void AddDetials(Following gigdetail)
        {
            context.Followings.Add(gigdetail);
            context.SaveChanges();
        }

        public List<Following> GetDetails()
        {
            return context.Followings.ToList();
        }

        public List<Following> GetDetailsBy(string ArtistEmail)
        {
            List<Following> user = context.Followings.Where(s => s.EmailId == ArtistEmail).ToList();
            return user;
        }

        public void UpdateGig(Following gigdetail)
        {
            context.Followings.Update(gigdetail);
            context.SaveChanges();
        }
    }
}
