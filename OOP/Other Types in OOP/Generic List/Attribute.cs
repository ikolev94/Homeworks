using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    
        [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]
        public class VersionAttribute : System.Attribute
        {
            public VersionAttribute(double version)
            {
                this.Version = version;
            }

            public double Version { get; private set; }
        }
    
}
