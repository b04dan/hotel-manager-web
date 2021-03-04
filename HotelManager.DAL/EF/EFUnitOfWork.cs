using HotelManager.DAL.Entities;
using HotelManager.DAL.Interfaces;

namespace HotelManager.DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly HotelDbContext _db;

        public EFUnitOfWork(HotelDbContext databaseContext)
        {
            _db = databaseContext;
        }


        public int SaveChanges()
        {
            return _db.SaveChanges();
        }


        public void Dispose()
        {
            _db.Dispose();
        }

        public void Initialize()
        {
            HotelDbInitializer.Seed(_db);
        }

        private IRepository<Client> _clients;
        private IRepository<Worker> _workers;
        private IRepository<Residence> _residences;
        private IRepository<WeeklySchedule> _schedules;
        private IRepository<HotelRoom> _hotelRooms;
        private IRepository<Hotel> _hotels;


        public IRepository<Client> ClientRepository => _clients ??= new EFRepository<Client>(_db);
        public IRepository<Worker> WorkerRepository => _workers ??= new EFRepository<Worker>(_db);
        public IRepository<Residence> ResidenceRepository => _residences ??= new EFRepository<Residence>(_db);
        public IRepository<WeeklySchedule> ScheduleRepository => _schedules ??= new EFRepository<WeeklySchedule>(_db);
        public IRepository<HotelRoom> HotelRoomRepository => _hotelRooms ??= new EFRepository<HotelRoom>(_db);
        public IRepository<Hotel> HotelRepository => _hotels ??= new EFRepository<Hotel>(_db);
    }
}
