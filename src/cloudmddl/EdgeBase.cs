using System;
using System.Collections.Generic;
using System.Text;

namespace cloudmddl
{
    class EdgeBase
    {
        protected NodeBase node;

        public EdgeBase(NodeBase node)
        {
            this.node = node;
        }
    }
}
