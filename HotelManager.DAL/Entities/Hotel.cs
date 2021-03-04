using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelManager.DAL.Entities
{
    public class Hotel : Entity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } // название гостиницы

        [Required]
        [MaxLength(300)]
        public string Address { get; set; } // адрес


        public int FloorCount { get; set; } // кол-во этажей


        public List<HotelRoom> HotelRooms { get; set; } // номера гостиницы
        public List<Worker> Workers { get; set; } // работники отеля
    }
}
