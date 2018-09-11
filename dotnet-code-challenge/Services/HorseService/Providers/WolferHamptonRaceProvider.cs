using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_code_challenge.Models;
using dotnet_code_challenge.WolferHamptonRacesDataService.FeedData;

namespace dotnet_code_challenge.Services.HorseService.Providers
{
    public class WolferHamptonRaceProvider : IProvideHorseData
    {

        public Task<IEnumerable<SimpleHorse>> Get()
        {

            RetrieveWolferHamptonRaceDataService wolferHamptonRaceDataService = new RetrieveWolferHamptonRaceDataService();
            var dataInOriginalFormat = wolferHamptonRaceDataService.Get();

            var allMarkets = dataInOriginalFormat.SelectMany(e => e.RawData.Markets);

            var allSelections = allMarkets.SelectMany(e => e.Selections);

            //assumption here is that Price is the right value not prize money
            return Task.FromResult(allSelections.Select(e =>
                new SimpleHorse()
                { Race = RaceType.WolferHamptonRace, Name = e.Tags.Name, Price = Convert.ToDouble(e.Price) }));

        }
    }
}
