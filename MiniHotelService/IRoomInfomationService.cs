using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelService
{
    public interface IRoomInfomationService
    {
        List<RoomInfomation> GetRoomInformations();
        RoomInfomation GetRoomInformationById(int id);
        void SaveRoomInformation(RoomInfomation roomInformation);
        void UpdateRoomInformation(RoomInfomation roomInformation);
        void DeleteRoomInformation(int id);
    }
}
