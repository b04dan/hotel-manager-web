using HotelManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Client> ClientRepository { get; }
        IRepository<Worker> WorkerRepository { get; }
        IRepository<Residence> ResidenceRepository { get; }
        IRepository<WeeklySchedule> ScheduleRepository { get; }
        IRepository<HotelRoom> HotelRoomRepository { get; }
        IRepository<Hotel> HotelRepository { get; }

        int SaveChanges();
        void Initialize();
    }
}
