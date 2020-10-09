using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actuatorSimulation
{
    // ManualValve inherits from BaseValve
    public class ManualValve: BaseValve
    {
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="type"></param>
        /// <param name="endPosition"></param>
        /// Valve max position
        /// <param name="step"></param>
        /// Valve increment or decrement step
        public ManualValve(string type, double endPosition, double step): base(type)
        {
            EndPosition = endPosition;
            Step = step;     
        }

        // Nothing more to add to the base class for a valve
        // actuated manually
    }
}
