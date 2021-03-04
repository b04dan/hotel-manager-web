using System.ComponentModel.DataAnnotations;

namespace HotelManager.DAL.Entities
{
    // человек
    public class Person : Entity
    {
        [Required]
        [MaxLength(200)]
        public string Surname { get; set; } // фамилия

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } // имя

        [Required]
        [MaxLength(200)]
        public string Patronymic { get; set; } // отчество

        [Required]
        [MaxLength(50)]
        public string PassportNumber { get; set; } // номер паспорта

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } // электоронная почта

        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; } // номер телефона
    }
}
