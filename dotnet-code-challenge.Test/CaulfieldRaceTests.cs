using dotnet_code_challenge.CaulFieldRacesDataService.FeedData;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public partial class WolferHamptonRacesDataServiceTests
    {
        [Fact]
        public void Ensure_CaulfieldDataService_Is_Operating()
        {
            RetrieveCaulFieldRacesDataService retrieveCaulFieldRacesDataService = new RetrieveCaulFieldRacesDataService();
            var data = retrieveCaulFieldRacesDataService.Get();
            Assert.NotNull(data);
        }

    
    }
}
