using System;
using System.Collections.Generic;
using System.Text;
using NextcomIntegrations.Core.DomainServices;

namespace NextcomIntegrations.Core.ApplicationServices
{
    public class IntegrationService
    {
        private IChecksumRepository _checksumRepository;
        private IMasterListService _masterListService;
        private INextcomRepository _nextcomRepository;
        private IProductService _productService;

        public IntegrationService(
            IChecksumRepository checksumRepository,
            IMasterListService masterListService,
            INextcomRepository nextcomRepository,
            IProductService productService
            
            )
        {
            _productService = productService;
            _nextcomRepository = nextcomRepository;
            _masterListService = masterListService;
            _checksumRepository = checksumRepository;
        }

        public void FullSyncProducts()
        {

        }
    }
}
