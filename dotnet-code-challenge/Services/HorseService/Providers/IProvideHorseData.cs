using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Services.HorseService.Providers
{
    public interface IProvideHorseData
    {
        Task<IEnumerable<SimpleHorse>> Get();
    }
}
