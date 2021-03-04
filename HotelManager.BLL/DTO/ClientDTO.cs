
namespace HotelManager.BLL.DTO
{
    // клиент гостиницы
    public class ClientDTO
    {
        public int Id { get; set; } // Id
        public string Surname { get; set; } // фамилия
        public string Name { get; set; } // имя
        public string Patronymic { get; set; } // отчество
        public string PassportNumber { get; set; } // номер паспорта
        public string Email { get; set; } // электоронная почта
        public string PhoneNumber { get; set; } // номер телефона
        public string City { get; set; } // город проживания
    }
}
