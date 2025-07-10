using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Services
{
    public interface IBookingDetailService
    {
        List<BookingDetail> GetHistoryBooking(int id);
        List<BookingDetail> GetBookingDetailsByPeriod(DateOnly startDate, DateOnly endDate);
    }
}
