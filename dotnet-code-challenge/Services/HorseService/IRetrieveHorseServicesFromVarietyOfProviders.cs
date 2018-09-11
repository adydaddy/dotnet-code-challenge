using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Services.HorseService
{
    public interface IRetrieveHorseServicesFromVarietyOfProviders
    {
       Task<IEnumerable<SimpleHorse>> GetHorses();
    }
}