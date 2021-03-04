
namespace HotelManager.BLL.DTO
{
    public class HotelRoomDTO
    {
        public int Id { get; set; } // Id
        public int RoomType { get; set; } // тип номера. Кол-во мест для проживания
        public int Floor { get; set; } // этаж 
        public string PhoneNumber { get; set; } // номер телефона в номере
        public double Price { get; set; } // стоимость проживания в сутки
    }
}
