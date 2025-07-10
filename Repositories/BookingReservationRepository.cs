using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using DataAccessLayer;

namespace Repositories
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        public void AddBookingReservation(BookingReservation b) => BookingReservationDAO.AddBookingReservation(b);
        public void UpdateBookingReservation(BookingReservation b) => BookingReservationDAO.UpdateBookingReservation(b);
        public void DeleteBookingReservation(BookingReservation b) => BookingReservationDAO.DeleteBookingReservation(b);
        public List<BookingReservation> GetBookingReservation() => BookingReservationDAO.GetBookingReservation();
        public BookingReservation GetBookingReservationById(int id) => BookingReservationDAO.GetBookingReservationById(id);
    }
}
