using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public interface IGigDetailRepository
    {
        List<GigDetail> GetDetails();
        void AddDetials(GigDetail gigdetail);
        List<GigDetail> GetDetailsBy(string ArtistEmail);
        void UpdateGig(GigDetail gigdetail);
    }
}
