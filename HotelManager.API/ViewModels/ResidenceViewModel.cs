using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.API.ViewModels
{
    public class ResidenceViewModel
    {
        public int Id { get; set; }
        public int HotelRoomId { get; set; }
        public int ClientId { get; set; }
        public string ClientSNP { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
    }
}
