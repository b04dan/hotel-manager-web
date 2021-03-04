
using System;

namespace HotelManager.BLL.DTO
{
    // информация о проживании клиента
    public class ResidenceDTO
    {
        public int Id { get; set; } // Id

        public int HotelRoomId { get; set; }
        public int ClientId { get; set; }

        public string Client { get; set; }

        public DateTime CheckInDate { get; set; }  // дата заселения
        public DateTime? CheckOutDate { get; set; }  // дата выселения
    }
}
