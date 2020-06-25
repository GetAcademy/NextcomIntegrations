using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;

namespace NextcomIntegrations.Core.DomainServices
{
    public interface IChecksumRepository
    {
        Task<Checksum> LookupSearchHash(SearchHash searchHash);
        Task<bool> AddSearchHash(SearchHash searchHash, Checksum checksum);
    }
}
