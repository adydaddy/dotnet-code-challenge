using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using dotnet_code_challenge.Bootstrap;
using dotnet_code_challenge.Services.HorseService;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IoC.RegisterIoC();
            var service = IoC.Resolve<IRetrieveHorseServicesFromVarietyOfProviders>();

            var allHorsesAcrossAllRacesAndEvents = Task.Run(() => service.GetHorses());

            foreach (var horse in allHorsesAcrossAllRacesAndEvents.Result.OrderBy(e => e.Price))
            {
                Console.WriteLine($"Horse:{horse.Name} - Price: {horse.Price} - Race: {horse.Race.ToString()}");
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }
    }
}
