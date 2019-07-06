using Application.Data.EDMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Interfaces
{
    public interface ICapacityProviderService
    {
        bool postBooking(CAPACITY_PROVIDER data);
    }
}
