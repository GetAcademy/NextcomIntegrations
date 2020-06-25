using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;
using NextcomIntegrations.Core.DomainServices;

namespace NextcomIntegrations.Infrastructure.DataAccess
{
    public class ChecksumRepository : IChecksumRepository
    {
        public Task<Checksum> LookupSearchHash(SearchHash searchHash)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddSearchHash(SearchHash searchHash, Checksum checksum)
        {
            throw new NotImplementedException();
        }
    }
}
