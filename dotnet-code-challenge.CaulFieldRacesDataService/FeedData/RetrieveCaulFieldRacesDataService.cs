using System;
using System.Collections.Generic;
using System.IO;
using dotnet_code_challenge.CaulFieldRacesDataService.Models;
using dotnet_code_challenge.CrossCutting;

namespace dotnet_code_challenge.CaulFieldRacesDataService.FeedData
{
    public class RetrieveCaulFieldRacesDataService
    {
        const string DataSourceName = "Caulfield_Race1.xml";

        public CaulfieldRaceModel Get()
        {
            XmlDeserializer deserializer = new XmlDeserializer();

            var fileContent = File.ReadAllText(string.Concat(Environment.CurrentDirectory, "\\FeedData\\",
                DataSourceName));

            return deserializer.Deserialize<CaulfieldRaceModel>(
               fileContent);

        }
    }
}
