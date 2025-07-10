using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class BookingDetailDAO
    {
        public static List<BookingDetail> GetHistoryBooking(int customerId)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                return db.BookingDetails
                         .Include(b => b.BookingReservation)
                         .Include(b => b.Room)
                         .Where(b => b.BookingReservation.CustomerId == customerId)
                         .OrderByDescending(b => b.StartDate)
                         .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting booking details: " + ex.Message);
            }
        }

        public static List<BookingDetail> GetBookingDetailsByPeriod(DateOnly startDate, DateOnly endDate)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                return db.BookingDetails
                         .Include(b => b.BookingReservation)
                         .Include(b => b.Room)
                         .Where(b => b.EndDate >= startDate && b.StartDate <= endDate)
                         .OrderByDescending(b => b.StartDate)
                         .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating booking detail report: " + ex.Message);
            }
        }

    }
}
