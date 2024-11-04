using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelDAO
{
    public class RoomTypeDAO
    {
        private static List<RoomType> roomTypeList;

        static RoomTypeDAO()
        {
            roomTypeList = new List<RoomType>
            {
                new RoomType(1, "Single", "A room for one person.", "Ideal for business travelers."),
                new RoomType(2, "Double", "A room for two persons.", "Perfect for couples or friends."),
                new RoomType(3, "Suite", "A large room with a living area.", "Luxurious accommodation."),
                new RoomType(4, "Family", "A room for a family.", "Includes additional beds.")
            };
        }

        public static List<RoomType> GetAllRoomTypes()
        {
            return roomTypeList;
        }

        public static RoomType GetRoomTypeById(int id)
        {
            return roomTypeList.Find(roomType => roomType.RoomTypeId == id);
        }

        public static void AddRoomType(RoomType roomType)
        {
            roomTypeList.Add(roomType);
        }

        public static bool UpdateRoomType(RoomType updatedRoomType)
        {
            var roomType = GetRoomTypeById(updatedRoomType.RoomTypeId);
            if (roomType != null)
            {
                roomType.RoomTypeName = updatedRoomType.RoomTypeName;
                roomType.TypeDescription = updatedRoomType.TypeDescription;
                roomType.TypeNote = updatedRoomType.TypeNote;
                return true;
            }
            return false;
        }

        public static bool DeleteRoomType(int id)
        {
            var roomType = GetRoomTypeById(id);
            if (roomType != null)
            {
                roomTypeList.Remove(roomType);
                return true;
            }
            return false;
        }
    }
}
