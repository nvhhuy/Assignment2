using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace DataAccessLayer
{
        public class RoomInformationDAO
    {
        public static List<RoomInformation> GetRoomInformation()
        {
            var listRoomInformation = new List<RoomInformation>();
            try
            {
                using var db = new FuminiHotelManagementContext();
                listRoomInformation = db.RoomInformations.ToList();
            }
            catch (Exception ex) { }

            return listRoomInformation;
        }

        public static void AddRoomInformation(RoomInformation r)
        {
            try
            {
                using var context = new FuminiHotelManagementContext();
                context.RoomInformations.Add(r);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteRoomInformation(RoomInformation r)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                var room = db.RoomInformations.SingleOrDefault(cr => cr.RoomId == r.RoomId);
                db.RoomInformations.Remove(room);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void UpdateRoomInformation(RoomInformation r)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                db.Entry<RoomInformation>(r).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static RoomInformation GetCustomerById(int id)
        {
            using var db = new FuminiHotelManagementContext();
            return db.RoomInformations.FirstOrDefault(cr => cr.RoomId.Equals(id));
        }
    }
}
