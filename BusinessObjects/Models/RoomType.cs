using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class RoomType
    {
        public RoomType() { }

        public RoomType(int RoomTypeId, string RoomTypeName, string TypeDescription, string TypeNote)
        {
            this.RoomTypeId = RoomTypeId;
            this.RoomTypeName = RoomTypeName;
            this.TypeDescription = TypeDescription;
            this.TypeNote = TypeNote;
        }

        public int RoomTypeId {  get; set; }
        public string RoomTypeName {  get; set; }
        public string TypeDescription {  get; set; }
        public string TypeNote {  get; set; }
    }
}
