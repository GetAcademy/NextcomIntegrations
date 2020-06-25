using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;
using NextcomIntegrations.Core.DomainServices;

namespace NextcomIntegrations.Infrastructure.Nextcom
{
    public class NextcomRepository : INextcomRepository
    {
        public Task<bool> Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> ReadProduct(NextcomId id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> ReadCustomer(NextcomId id)
        {
            throw new NotImplementedException();
        }
    }
}
