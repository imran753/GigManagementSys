using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GigManagementSystem.Repositories;
using GigManagementSystem.Models;

namespace GigManagementSystem.Repositories
{
    public class GigDetailRepository : IGigDetailRepository
    {

        private GigManagementSysContext context = null;
        public GigDetailRepository()
        {
            context = new GigManagementSysContext();
        }
        public void AddDetials(GigDetail gigdetail)
        {
            context.GigDetails.Add(gigdetail);
            context.SaveChanges();
        }

        public List<GigDetail> GetDetails()
        {
            return context.GigDetails.ToList();
        }

        public List<GigDetail> GetDetailsBy(string email)
        {
            List<GigDetail> user = context.GigDetails.Where(s => s.EmailId == email).ToList();
            return user;
        }

        public void UpdateGig(GigDetail gigdetail)
        {
            context.GigDetails.Update(gigdetail);
            context.SaveChanges();
            
        }
    }
}
