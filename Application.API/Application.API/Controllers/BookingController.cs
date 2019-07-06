using APIProject.Models;
using Application.Data.EDMX;
using Application.Service.Interfaces;
using Application.Service.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace APIProject.Controllers
{
    public class BookingController : ApiController
    {
        private readonly IBookingService service;
        public BookingController()
        {
            service = new BookingService();
        }
        [HttpGet]
        [Route("booking")]
        [ResponseType(typeof(List<BOOKING>))]
        public IHttpActionResult getBooking()
        {
            return Ok(service.getBooking());
        }
        [HttpPost]
        [Route("booking")]
        public IHttpActionResult postBooking(BookingModel data)
        {
            BOOKING booking = new BOOKING();
            booking.amount = data.amount;
            booking.capacity_provider_id = data.capacity_provider_id;
            booking.comment = data.comment;
            booking.currency = data.currency;
            booking.date_from = data.date_from;
            booking.date_to = data.date_to;
            booking.id = data.id;
            booking.is_active = data.is_active;
            booking.object_name = data.object_name;

            return Ok(service.postBooking(booking));
        }
        [HttpDelete]
        [Route("booking/{id}")]
        public IHttpActionResult deleteBooking(int id)
        {
            return Ok(service.deleteBooking(id));
        }
    }
}
