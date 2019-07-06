using APIProject.Models;
using Application.Data.EDMX;
using Application.Service.Interfaces;
using Application.Service.Services;
using System.Web.Http;

namespace APIProject.Controllers
{
    public class CapacityProviderController : ApiController
    {
        private readonly ICapacityProviderService service;
        public CapacityProviderController()
        {
            service = new CapacityProviderService();
        }

        [HttpPost]
        [Route("capacity-provider")]
        public IHttpActionResult postBooking(CapacityProviderModel data)
        {
            CAPACITY_PROVIDER cprv = new CAPACITY_PROVIDER();
            cprv.city = data.city;
            cprv.contract_number = data.contract_number;
            cprv.email = data.email;
            cprv.id = data.id;
            cprv.name = data.name;
            cprv.phone = data.phone;
            return Ok(service.postBooking(cprv));
        }
    }
}
