using System;
using System.Collections.Generic;
using System.Text;

namespace cloudmddl
{
    class NodeBase : HashEntryBase
    {
        protected IEnumerable<EdgeBase> edges;

        public NodeBase() : base()
        {
        }
    }
}
