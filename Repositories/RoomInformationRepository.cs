using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using DataAccessLayer;


namespace Repositories
{
    public class RoomInformationRepository : IRoomInformationRepository
    {
        public void AddRoomInformation(RoomInformation r) => RoomInformationDAO.AddRoomInformation(r);
        public void UpdateRoomInformation(RoomInformation r) => RoomInformationDAO.UpdateRoomInformation(r);
        public void DeleteRoomInformation(RoomInformation r) => RoomInformationDAO.DeleteRoomInformation(r);
        public List<RoomInformation> GetRoomInformation() => RoomInformationDAO.GetRoomInformation();
        public RoomInformation GetRoomInformationById(int id) => RoomInformationDAO.GetCustomerById(id);
    }
}
