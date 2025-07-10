using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using Repositories;

namespace Services
{
    public class RoomInformationService : IRoomInformationService
    {
        private readonly IRoomInformationRepository _roomInformationService;

        public RoomInformationService()
        {
            _roomInformationService = new RoomInformationRepository();
        }
        public void AddRoomInformation(RoomInformation r)
        {
            _roomInformationService.AddRoomInformation(r);
        }
        public void UpdateRoomInformation(RoomInformation r)
        {
            _roomInformationService.UpdateRoomInformation(r);
        }
        public void DeleteRoomInformation(RoomInformation r)
        {
            _roomInformationService.DeleteRoomInformation(r);
        }
        public List<RoomInformation> GetRoomInformation()
        {
            return _roomInformationService.GetRoomInformation();
        }
        public RoomInformation GetRoomInformationById(int id)
        {
            return _roomInformationService.GetRoomInformationById(id);
        }
    }
}
