using Application.Data.EDMX;
using Application.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Service.Services
{
    public class CapacityProviderService : ICapacityProviderService
    {
        private readonly ApplicationEntities db;
        public CapacityProviderService()
        {
            db = new ApplicationEntities();
        }

        public bool postBooking(CAPACITY_PROVIDER data)
        {
            try
            {
                db.CAPACITY_PROVIDER.Add(data);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                // we can log the exception here
                return false;
            }
        }
    }
}