using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actuatorSimulation
{
    // Control valve inherits from AutoValve
    public class ControlValve: AutoValve
    {
        // Current value property is added to the base class
        private double currentValue;
        public double CurrentValue
        {
            get
            {
                return currentValue;
            }

            private set
            {
                currentValue = value;
            }
        }

        // Electrical range property is added to the base class
        private List<double> range;
        public List<double> Range { get => range; set => range = value; }

        // Position property is overriden to update the electrical position
        public override double Position
        {
            get
            {
                // Getter is unchanged
                return base.Position;
            }
            set
            {
                // update the position
                base.Position = value;

                // update the currentValue property
                // !!! the Range property is added to the derived class
                // !!! as the Position property is updated in the base class constructor
                // !!! it is set before Range property initialization which can be null.
                if (Range != null)
                {
                    CurrentValue = Range[0] + (Range[1] - Range[0]) * (Position / EndPosition);
                }
                
            }
        }





        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="type"></param>
        /// <param name="runtime"></param>
        /// <param name="speed"></param>
        /// <param name="range"></param>
        /// Range is the valve electrical range typically for 
        /// analog valve 4mA = open and 20mA = close
        public ControlValve(string type, double runtime, double speed, List<double> range = null): base(type, runtime, speed)
        {
            // Set the range to 4-20mA by default
            if (range == null)
            {
                Range = new List<double>() { 4, 20 };
            }
            else
            {
                Range = range;
            }
            
            // Set currentValue to range min
            CurrentValue = Range[0];
        }
    }
}
