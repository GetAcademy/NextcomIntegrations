using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;
using NextcomIntegrations.Core.DomainServices;

namespace NextcomIntegrations.Infrastructure.DataAccess
{
    public class MasterListService : IMasterListService
    {
        
        public Task<ExternalId> ExternalIdFromInternalId(int internalId)
        {
            throw new NotImplementedException();
        }

        public Task<int> InternalIdFromExternalId(ExternalId externalId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Add(int internalId, ExternalId externalId)
        {
            throw new NotImplementedException();
        }
    }
}
