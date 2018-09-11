using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.CaulFieldRacesDataService.FeedData;
using dotnet_code_challenge.CaulFieldRacesDataService.Models;
using System.Linq;
using System.Threading.Tasks;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Services.HorseService.Providers
{
    public class CaulFieldRaceProvider : IProvideHorseData
    {
        public Task<IEnumerable<SimpleHorse>> Get()
        {
            RetrieveCaulFieldRacesDataService caulFieldRacesDataService = new RetrieveCaulFieldRacesDataService();
            var dataInOriginalFormat = caulFieldRacesDataService.Get();

            var allRaces = dataInOriginalFormat.Races;
            var pricesForAllHorses = allRaces.SelectMany(e => e.Race.Prices.Price.Horses.Horse);
            var allHorses = allRaces.SelectMany(e => e.Race.Horses.Horse);

            //assumption here is that Price is the right value not prize money
            return Task.FromResult(pricesForAllHorses.Select(e =>
                new SimpleHorse()
                { Race = RaceType.CaulFieldRace, Name = allHorses.First(f => f.Number == e._Number).Name, Price = Convert.ToDouble(e.Price) }));
        }
    }
}
