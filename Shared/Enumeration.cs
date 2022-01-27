using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public abstract class Enumeration
    {
        [DataMember]
        public int Value { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        public override string ToString() => DisplayName;
    }
}
