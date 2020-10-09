using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actuatorSimulation
{
    // ShutOffValve inherits from AutoValve
    public class ShutOffValve: AutoValve
    {
        // Constructor with parameters
        public ShutOffValve(string type, double runtime, double speed): base(type, runtime, speed)
        {
            // Nothing to add compared to AutoValve
        }

        // open method override: ShutOffValve opening behavior is the same as
        // AutoValve except that movement can't be interrupted
        public override void open()
        {
            // ShutOffValve closing can't be interrupted
            if (IsClosing)
                return;

            // Call the AutoValve open method
            base.open();    
        }

        // close method override: ShutOffValve closing behavior is the same as
        // AutoValve except that movement can't be interrupted
        public override void close()
        {
            // ShutOffValve can't be interrupted
            if (IsOpening)
                return;

            // Call the AutoValve close method
            base.close();     
        }      
    }
}
