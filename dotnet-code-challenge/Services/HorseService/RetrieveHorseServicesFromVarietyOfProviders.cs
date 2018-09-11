using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_code_challenge.Models;
using dotnet_code_challenge.Services.HorseService.Providers;

namespace dotnet_code_challenge.Services.HorseService
{
    public class RetrieveHorseServicesFromVarietyOfProviders : IRetrieveHorseServicesFromVarietyOfProviders
    {
        private readonly IEnumerable<IProvideHorseData> _horseDataProviders;

        public RetrieveHorseServicesFromVarietyOfProviders(IEnumerable<IProvideHorseData> horseDataProviders)
        {
            _horseDataProviders = horseDataProviders;
        }

        public async Task<IEnumerable<SimpleHorse>> GetHorses()
        {
            var allProvidersTaskExecution = Task.WhenAll(_horseDataProviders.Select(e => e.Get()));
            var allProvidersTaskResult = await allProvidersTaskExecution;
            return allProvidersTaskResult.SelectMany(e => e);
        }


    }
}
