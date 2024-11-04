using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class RoomInformation
    {
        public RoomInformation() { }

        public RoomInformation(int id, string roomNumber, string description, int maxCapacity, decimal price, int roomtypeId, int status)
        {
            this.RoomId = id;
            this.RoomNumber = roomNumber;
            this.RoomDescription = description;
            this.RoomMaxCapacity = maxCapacity;
            this.RoomPricePerDay = price;
            this.RoomTypeId = roomtypeId;
            this.RoomStatus = status;
        }

        public int RoomId { get; set; }
        public string RoomNumber {  get; set; }
        public string RoomDescription {  get; set; }

        public int RoomMaxCapacity {  get; set; }

        public decimal RoomPricePerDay {  get; set; }

        public int RoomTypeId {  get; set; }

        public int RoomStatus {  get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
