using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blazor.Server.Repositories;
using Blazor.Shared;

namespace Blazor.Server.Controllers
{
    [ApiController]
    [Route("api/ShelterBooking")]
    public class ShelterBookingController : ControllerBase
    {
        private IShelterBookingRepository mRepo;

        public ShelterBookingController(IShelterBookingRepository repo)
        {
            mRepo = repo;
        }

        [HttpGet]
        [Route("getall")]
        public IEnumerable<ShelterBooking> GetAll()
        {
            return mRepo.GetAllBookings();
        }

        [HttpPost]
        [Route("book")]
        public void BookShelter(ShelterBooking booking)
        {
            mRepo.BookShelter(booking);
        }

        [HttpDelete]
        [Route("cancel/{id:int}")]
        public void CancelBooking(int id)
        {
            mRepo.CancelBooking(id);
        }

        [HttpPut]
        [Route("update")]
        public void UpdateBooking(ShelterBooking booking)
        {
            mRepo.UpdateBooking(booking);
        }
    }
}
