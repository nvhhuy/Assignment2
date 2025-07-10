using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using Repositories;

namespace Services
{
    public class BookingReservationService : IBookingReservationService
    {
        private readonly IBookingReservationRepository _service;

        public BookingReservationService()
        {
            _service = new BookingReservationRepository();
        }
        public void AddBookingReservation(BookingReservation b)
        {
            _service.AddBookingReservation(b);
        }
        public void UpdateBookingReservation(BookingReservation b)
        {
            _service.UpdateBookingReservation(b);
        }
        public void DeleteBookingReservation(BookingReservation b)
        {
            _service.DeleteBookingReservation(b);
        }
        public List<BookingReservation> GetBookingReservation()
        {
            return _service.GetBookingReservation();
        }
        public BookingReservation GetBookingReservationById(int id)
        {
            return _service.GetBookingReservationById(id);
        }
    }
}
