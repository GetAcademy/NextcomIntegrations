using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NextcomIntegrations.Core.DomainModel;

namespace NextcomIntegrations.Core.DomainServices
{
    public interface IMasterListService
    {
        Task<ExternalId> ExternalIdFromInternalId(int internalId);
        Task<int> InternalIdFromExternalId(ExternalId externalId);
        Task<bool> Add(int internalId, ExternalId externalId);
    }
}
