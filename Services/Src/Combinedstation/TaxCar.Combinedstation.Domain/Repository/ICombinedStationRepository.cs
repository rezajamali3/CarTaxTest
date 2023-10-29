using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCar.Combinedstation.Core.Repository
{

    public interface ICombinedStationRepository
    {

        Task<CombinedStations> AddAsync(CombinedStations combinedStations);

        Task<CombinedStations> DeleteAsync(CombinedStations combinedStations);

        Task<bool> Exists(Guid combinedStationsId);

        Task<CombinedStations> Find(Guid combinedStationsId);

        Task<bool> Commit();

    }

}
