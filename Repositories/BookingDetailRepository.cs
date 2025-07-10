using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using DataAccessLayer;

namespace Repositories
{
    public class BookingDetailRepository : IBookingDetailRepository
    {
        public List<BookingDetail> GetHistoryBooking(int id) => BookingDetailDAO.GetHistoryBooking(id);
        public List<BookingDetail> GetBookingDetailsByPeriod(DateOnly startDate, DateOnly endDate) => BookingDetailDAO.GetBookingDetailsByPeriod(startDate, endDate);
    }
}
