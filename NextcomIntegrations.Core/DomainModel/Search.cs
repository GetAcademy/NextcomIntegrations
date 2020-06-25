using System;
using System.Collections.Generic;
using System.Text;

namespace NextcomIntegrations.Core.DomainModel
{
    public class Search
    {
        public string Entity { get;  }
        public string Id { get;  }
        public int Page { get;  }

        public SearchHash GetHash()
        {
            throw new NotImplementedException();
        }
    }
}
