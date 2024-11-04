using BusinessObjects.Models;
using MiniHotelDAO;
using MiniHotelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelService
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepo roomTypeRepository;

        public RoomTypeService()
        {
            roomTypeRepository = new RoomTypeRepo(); 
        }

        public List<RoomType> GetRoomTypes() => roomTypeRepository.GetRoomTypes();

        public RoomType GetRoomTypeById(int id) => roomTypeRepository.GetRoomTypeById(id);

        public void SaveRoomType(RoomType roomType) => roomTypeRepository.SaveRoomType(roomType);

        public void UpdateRoomType(RoomType roomType) => roomTypeRepository.UpdateRoomType(roomType);

        public void DeleteRoomType(int id) => roomTypeRepository.DeleteRoomType(id);
    }
}
