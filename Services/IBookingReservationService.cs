using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Services
{
    public interface IBookingReservationService
    {
        void AddBookingReservation(BookingReservation b);
        void UpdateBookingReservation(BookingReservation b);
        void DeleteBookingReservation(BookingReservation b);
        List<BookingReservation> GetBookingReservation();
        BookingReservation GetBookingReservationById(int id);
    }
}
