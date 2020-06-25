using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;

namespace NextcomIntegrations.Core.DomainServices
{
    public interface INextcomRepository
    {
        Task<bool> Add(Product product);
        Task<bool> Add(Customer customer);
        // Task<bool> Add<T>(T entity);
        Task<bool> Update(Product product);
        //Task<T> Read<T>(NextcomId id);
        Task<Product> ReadProduct(NextcomId id);
        Task<Customer> ReadCustomer(NextcomId id);
    }
}
