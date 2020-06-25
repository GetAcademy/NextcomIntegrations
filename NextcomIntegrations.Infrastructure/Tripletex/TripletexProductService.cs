using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;
using NextcomIntegrations.Core.DomainServices;

namespace NextcomIntegrations.Infrastructure.Tripletex
{
    public class TripletexProductService : IProductService
    {
        public Task<IEnumerable<Product>> GetProducts(int id)
        {
            throw new NotImplementedException();
        }
    }
}
