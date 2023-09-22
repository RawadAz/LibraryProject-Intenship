using Dapper;
using Library.Data;
using Library.Models.Reservation.DTO_s;
using Library.Repositories.ClientRepo;
using Library.Repositories.EventRepo;
using Library.Repositories.GenericRepo;
using System.Threading.Tasks;

namespace Library.Repositories.ReservationRepo
{
    public class ReservationRepository : GenericRepository<ReservationDTO>, IReservationRepository
    {
        private new readonly LibraryDBConnection _Connection;

        public IGenericRepository<ReservationDTO> GenericRepository { get; private set; }

        public ReservationRepository(LibraryDBConnection connection) : base(connection)
        {
            _Connection = connection;
            GenericRepository = new GenericRepository<ReservationDTO>(_Connection);
            
        }

    }
}
