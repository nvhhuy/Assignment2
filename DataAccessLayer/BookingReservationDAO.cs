using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace DataAccessLayer
{
     public class BookingReservationDAO
    {
        public static List<BookingReservation> GetBookingReservation()
        {
            var listBookingReservation = new List<BookingReservation>();
            try
            {
                using var db = new FuminiHotelManagementContext();
                listBookingReservation = db.BookingReservations.ToList();
            }
            catch (Exception ex) { }

            return listBookingReservation;
        }

        public static void AddBookingReservation(BookingReservation br)
        {
            try
            {
                using var context = new FuminiHotelManagementContext();
                context.BookingReservations.Add(br);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteBookingReservation(BookingReservation br)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                var bookingre = db.BookingReservations.SingleOrDefault(cr => cr.BookingReservationId == br.BookingReservationId);
                db.BookingReservations.Remove(bookingre);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void UpdateBookingReservation(BookingReservation br)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                db.Entry<BookingReservation>(br).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static BookingReservation GetBookingReservationById(int id)
        {
            using var db = new FuminiHotelManagementContext();
            return db.BookingReservations.FirstOrDefault(cr => cr.BookingReservationId.Equals(id));
        }
    }
}
