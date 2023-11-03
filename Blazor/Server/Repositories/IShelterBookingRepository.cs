using Blazor.Shared;
using System;

namespace Blazor.Server.Repositories
{
    public interface IShelterBookingRepository
    {
        void BookShelter(ShelterBooking booking);
        void CancelBooking(int id);
        ShelterBooking[] GetAllBookings();
        void UpdateBooking(ShelterBooking booking);
    }
}
