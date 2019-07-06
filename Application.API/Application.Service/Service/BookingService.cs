using Application.Data.EDMX;
using Application.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Service.Services
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationEntities db;

        public BookingService()
        {
            db = new ApplicationEntities();
        }
        public bool deleteBooking(int id)
        {
            try
            {
                db.BOOKINGs.Remove(db.BOOKINGs.SingleOrDefault(s=>s.id == id));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<BOOKING> getBooking()
        {
            List<BOOKING> list;
            list = db.BOOKINGs.ToList<BOOKING>();
            return list;
        }

        public bool postBooking(BOOKING data)
        {
            try
            {
                db.BOOKINGs.Add(data);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // we can log the exception here
                return false;
            }
        }
    }
}