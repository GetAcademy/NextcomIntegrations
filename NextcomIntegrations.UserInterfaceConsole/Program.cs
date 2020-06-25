using System;
using NextcomIntegrations.Core.ApplicationServices;
using NextcomIntegrations.Infrastructure.DataAccess;
using NextcomIntegrations.Infrastructure.Nextcom;
using NextcomIntegrations.Infrastructure.Tripletex;

namespace NextcomIntegrations.UserInterfaceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new IntegrationService(
                new ChecksumRepository(), 
                new MasterListService(), 
                new NextcomRepository(), 
                new TripletexProductService()
            );

            service.FullSyncProducts();
        }
    }
}
