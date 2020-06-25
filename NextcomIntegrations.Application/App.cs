using System;
using System.Collections.Generic;
using System.Text;
using NextcomIntegrations.Core.ApplicationServices;
using NextcomIntegrations.Infrastructure.DataAccess;
using NextcomIntegrations.Infrastructure.Nextcom;
using NextcomIntegrations.Infrastructure.Tripletex;

namespace NextcomIntegrations.Application
{
    public class App
    {
        public static void Run()
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
