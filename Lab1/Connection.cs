using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Connection
    {

        public TelephoneNumber requester { get; }
        public TelephoneNumber responser { get; }

        public Connection(TelephoneNumber requester, TelephoneNumber responser)
        {
            this.requester = requester;
            this.responser = responser;
        }

    }
}
