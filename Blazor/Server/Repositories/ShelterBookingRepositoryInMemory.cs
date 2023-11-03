using System;
using System.Collections.Generic;
using Blazor.Server.Repositories;
using Blazor.Shared;

namespace Blazor.Server.Repositories
{
    public class ShelterBookingRepositoryInMemory : IShelterBookingRepository
    {
        private List<ShelterBooking> mBookings = new() {
            new ShelterBooking {Id = 1, Location = "Shelter A", Phone = "123-456-7890", Email = "shelter@example.com", Time = DateTime.Now },
            new ShelterBooking { Id = 2, Location = "Shelter B", Phone = "987-654-3210", Email = "shelter2@example.com", Time = DateTime.Now.AddHours(2) }
        };

        public void BookShelter(ShelterBooking booking)
        {
            int newId = mBookings.Count + 1;
            mBookings.Add(booking);
        }

        public void CancelBooking(int id)
        {
            // Empty implementation; you can remove this method body if not needed.
        }

        public ShelterBooking[] GetAllBookings() => mBookings.ToArray();

        public void UpdateBooking(ShelterBooking booking)
        {
            var existingBooking = mBookings.FindIndex(b => b.Id == booking.Id);
            if (existingBooking != -1)
            {
                mBookings[existingBooking] = booking;
            }
        }
    }
}

