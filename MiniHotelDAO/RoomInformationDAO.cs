using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelDAO
{
    public class RoomInformationDAO
    {
        private static List<RoomInfomation> listRooms;

        static RoomInformationDAO()
        {
            listRooms = new List<RoomInfomation>
            {
                new RoomInfomation(1, "101", "Deluxe single room with a king-sized bed.", 1, 100.00m, 1, 1),
                new RoomInfomation(2, "102", "Standard double room with a queen-sized bed.", 2, 150.00m, 2, 1),
                new RoomInfomation(3, "201", "Spacious suite with a living area and kitchenette.", 3, 250.00m, 3, 1),
                new RoomInfomation(4, "202", "Family room with bunk beds and a double bed.", 4, 200.00m, 4, 1)
            };
        }

        public static List<RoomInfomation> GetAllRooms()
        {
            var rooms = listRooms;
            foreach (var room in rooms)
            {
                room.RoomType = RoomTypeDAO.GetRoomTypeById(room.RoomTypeId);
            }
            return listRooms;
        }

        public static RoomInfomation GetRoomById(int id)
        {
            return listRooms.Find(room => room.RoomId == id);
        }

        public static void AddRoom(RoomInfomation room)
        {
            room.RoomId = listRooms.Count > 0 ? listRooms.Max(c => c.RoomId) + 1 : 1;
            listRooms.Add(room);
        }

        public static bool UpdateRoom(RoomInfomation updatedRoom)
        {
            var room = GetRoomById(updatedRoom.RoomId);
            if (room != null)
            {
                room.RoomNumber = updatedRoom.RoomNumber;
                room.RoomDescription = updatedRoom.RoomDescription;
                room.RoomMaxCapacity = updatedRoom.RoomMaxCapacity;
                room.RoomPricePerDay = updatedRoom.RoomPricePerDay;
                room.RoomTypeId = updatedRoom.RoomTypeId;
                room.RoomStatus = updatedRoom.RoomStatus;
                return true;
            }
            return false;
        }

        public static bool DeleteRoom(int id)
        {
            var room = GetRoomById(id);
            if (room != null)
            {
                listRooms.Remove(room);
                return true;
            }
            return false;
        }
    }
}
