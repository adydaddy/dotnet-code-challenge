using System;
using System.Collections.Generic;
using System.IO;
using dotnet_code_challenge.CrossCutting;
using dotnet_code_challenge.WolferHamptonRacesDataService.Models;

namespace dotnet_code_challenge.WolferHamptonRacesDataService.FeedData
{
    public class RetrieveWolferHamptonRaceDataService
    {
        const string DataSourceName = "Wolferhampton_Race1.json";

        public IEnumerable<WolferHamptonRaceModel> Get()
        {

            JsonDeserializer deserializer = new JsonDeserializer();

            var fileContent = File.ReadAllText(string.Concat(Environment.CurrentDirectory, "\\FeedData\\",
                DataSourceName));

            return new List<WolferHamptonRaceModel>()
            {
                deserializer.Deserialize<WolferHamptonRaceModel>(
                    fileContent)
            };


        }
    }
}
