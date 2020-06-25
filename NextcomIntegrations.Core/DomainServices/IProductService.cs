using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;

namespace NextcomIntegrations.Core.DomainServices
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts(int id);
    }
}
