using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Services
{
    public interface IRoomInformationService
    {
        void AddRoomInformation(RoomInformation r);
        void UpdateRoomInformation(RoomInformation r);
        void DeleteRoomInformation(RoomInformation r);
        List<RoomInformation> GetRoomInformation();
        RoomInformation GetRoomInformationById(int id);
    }
}
