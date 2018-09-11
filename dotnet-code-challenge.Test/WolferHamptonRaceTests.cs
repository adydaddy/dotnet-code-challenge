using System;
using dotnet_code_challenge.WolferHamptonRacesDataService.FeedData;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public partial class WolferHamptonRacesDataServiceTests
    {
        [Fact]
        public void Ensure_WolferHampton_Race_Model_Is_Operating()
        {

            RetrieveWolferHamptonRaceDataService retrieveWolferHamptonRaceDataService = new RetrieveWolferHamptonRaceDataService();
            var data = retrieveWolferHamptonRaceDataService.Get();
            Assert.NotNull(data);
        }
    }
}
