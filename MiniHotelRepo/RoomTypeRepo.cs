using BusinessObjects.Models;
using MiniHotelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public class RoomTypeRepo : IRoomTypeRepo
    {
        public List<RoomType> GetRoomTypes() => RoomTypeDAO.GetAllRoomTypes();

        public RoomType GetRoomTypeById(int id) => RoomTypeDAO.GetAllRoomTypes().FirstOrDefault(rt => rt.RoomTypeId == id);

        public void SaveRoomType(RoomType roomType) => RoomTypeDAO.AddRoomType(roomType);

        public void UpdateRoomType(RoomType roomType) => RoomTypeDAO.UpdateRoomType(roomType);

        public void DeleteRoomType(int id) => RoomTypeDAO.DeleteRoomType(id);
    }
}
