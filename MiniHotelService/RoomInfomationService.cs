using BusinessObjects.Models;
using MiniHotelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelService
{
    public class RoomInfomationService : IRoomInfomationService
    {
        private readonly IRoomInfomationRepo roomInformationRepository;

        public RoomInfomationService()
        {
            roomInformationRepository = new RoomInfomationRepo(); 
        }

        public List<RoomInfomation> GetRoomInformations() => roomInformationRepository.GetRoomInformations();

        public RoomInfomation GetRoomInformationById(int id) => roomInformationRepository.GetRoomInformationById(id);

        public void SaveRoomInformation(RoomInfomation roomInformation) => roomInformationRepository.SaveRoomInformation(roomInformation);

        public void UpdateRoomInformation(RoomInfomation roomInformation) => roomInformationRepository.UpdateRoomInformation(roomInformation);

        public void DeleteRoomInformation(int id) => roomInformationRepository.DeleteRoomInformation(id);
    }
}
