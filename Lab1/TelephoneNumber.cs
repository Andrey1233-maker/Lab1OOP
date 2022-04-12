using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class TelephoneNumber
    {
        public string owner { get; }
        public string number { get; }

        public TelephoneNumber(string owner, string number)
        {
            this.owner = owner;
            this.number = number;
        }
    }
}
