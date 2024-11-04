using BusinessObjects.Models;
using MiniHotelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public class RoomInfomationRepo : IRoomInfomationRepo
    {
        public List<RoomInfomation> GetRoomInformations() => RoomInformationDAO.GetAllRooms();

        public RoomInfomation GetRoomInformationById(int id) => RoomInformationDAO.GetAllRooms().FirstOrDefault(r => r.RoomId == id);

        public void SaveRoomInformation(RoomInfomation roomInformation) => RoomInformationDAO.AddRoom(roomInformation);

        public void UpdateRoomInformation(RoomInfomation roomInformation) => RoomInformationDAO.UpdateRoom(roomInformation);

        public void DeleteRoomInformation(int id) => RoomInformationDAO.DeleteRoom(id);
    }
}
