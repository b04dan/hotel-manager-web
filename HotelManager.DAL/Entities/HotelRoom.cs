using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelManager.DAL.Entities
{
    public class HotelRoom : Entity
    {
        public int RoomType { get; set; } // тип номера. Кол-во мест для проживания
        public int Floor { get; set; } // этаж 

        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; } // номер телефона в номере
        public double Price { get; set; } // стоимость проживания в сутки

        public List<Residence> Residences { get; set; } // проживания в этом номере

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } // отель
    }
}
