using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelManager.DAL.Entities
{
    // клиент гостиницы
    public class Client : Person
    {
        [Required]
        [MaxLength(200)]
        public string City { get; set; } // город проживания

        public List<Residence> Residences { get; set; } // проживания клиента в гостинице
    }
}
