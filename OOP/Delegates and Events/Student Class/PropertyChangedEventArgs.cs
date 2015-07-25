using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    class PropertyChangedEventArgs:EventArgs
    {
        public PropertyChangedEventArgs(string propName, dynamic oldVal, dynamic newVal)
        {
            this.PropertyName = propName;
            this.OldValue = oldVal;
            this.NewValue = newVal;
        }

        public string PropertyName { get; private set; }

        public dynamic OldValue { get; private set; }

        public dynamic NewValue { get; private set; }
    }
}
