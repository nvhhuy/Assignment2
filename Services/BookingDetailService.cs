using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using Repositories;

namespace Services
{
    public class BookingDetailService : IBookingDetailService
    {
        private readonly IBookingDetailRepository _bookingDetailRepository;
        public BookingDetailService()
        {
            _bookingDetailRepository = new BookingDetailRepository();
        }

        public List<BookingDetail> GetHistoryBooking(int id)
        {
            return _bookingDetailRepository.GetHistoryBooking(id);
        }

        public List<BookingDetail> GetBookingDetailsByPeriod(DateOnly startDate, DateOnly endDate)
        {
            return _bookingDetailRepository.GetBookingDetailsByPeriod(startDate, endDate);
        }
    }
}
