using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public interface IFollowingRepository
    {
        List<Following> GetDetails();
        void AddDetials(Following gigdetail);
        List<Following> GetDetailsBy(string ArtistEmail);
        void UpdateGig(Following gigdetail);
    }
}
