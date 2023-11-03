using System;

namespace Blazor.Shared
{
    public class ShelterBooking
    {
        public int Id { get; set; } // Add an Id property

        public string Location { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime Time { get; set; } = DateTime.Now;
    }
}


