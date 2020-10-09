using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actuatorSimulation
{
    // AutoValve inherits from BaseValve
    public class AutoValve: BaseValve
    {
        // Timer property is used to call repeatedly the close or
        // open method
        private Timer timer;
        public Timer Timer { get => timer; set => timer = value; }
      
        // Speed property stores the valve movement speed
        private double speed;
        public double Speed { get => speed; set => speed = value; }

        // Runtime property stores the valve time duration to close or open
        private double runtime;
        public double Runtime { get => runtime; set => runtime = value; }

        // IsOpening property indicates if the valve is currently opening
        private bool isOpening;
        public bool IsOpening { get => isOpening; set => isOpening = value; }

        // IsClosing property indicates if the valve is currently closing
        public bool isClosing = false;
        public bool IsClosing { get => isClosing; set => isClosing = value; }

        // Constructor with no parameter
        public AutoValve(): this(string.Empty, 1, 1)
        {
            // Nothing to add compared to the BaseValve class
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="type"></param>
        /// Valve designation
        /// <param name="runtime"></param>
        /// Valve closing or opening time duration (s)
        /// <param name="speed"></param>
        /// Valve speed (m/s)
        public AutoValve(string type, double runtime, double speed): base(type)
        {        
            Speed = speed;
            Runtime = runtime;

            // Timer init
            Timer = new Timer();
            // Timer callback function will be called every 500ms
            Timer.Interval = 500;
            // The valve position will be incremented or decremented by
            // Step m every 500ms
            Step = Speed * Timer.Interval / 1000;
            // Timer callback function assignment
            Timer.Tick += new EventHandler(timerTick);

            // Valve end position calculation (used as maximum value
            // for the progress bar)
            calculateEndPos();

            // Progress bar scaling if the end position is less than 1m
            if (EndPosition < 1)
            {
                EndPosition *= 10;
                Step *= 10;
            }
        }

        // Timer callback function called every 500ms
        public void timerTick(object sender, EventArgs e)
        {
            // Check for a close command
            if (IsClosing)
            {
                // Call for the base class close method
                base.close();

                // If EndPosition is reached timer is stopped and
                // closing command is reset
                if (TlClose)
                {
                    Timer.Stop();
                    IsClosing = false;             
                }
                    
            }
            // Same logic for open command
            else if (IsOpening)
            {
                base.open();

                if (TlOpen)
                {
                    Timer.Stop();
                    IsOpening = false;
                }
            }
        }

        // End position calculation
        public void calculateEndPos()
        {          
            EndPosition = Speed * Runtime;
        }

        // Stop command implementation
        public void stop()
        {
            // Stop the timer in case it is started
            if (Timer.Enabled)
            {
                Timer.Stop();
            }
            
            // Reset open and close commands
            IsOpening = false;
            IsClosing = false;

        }

        // Open command implementation
        public override void open()
        {
           // Check if the valve is already opening
            if (!IsOpening)
            {
                // Check if the timer is not already started
                if (!Timer.Enabled)
                {
                    // If not start the timer
                    Timer.Start();
                }
                
                // Set open command and reset close one
                IsOpening = true;
                IsClosing = false;              
            } 
        }

        // Close method implementation
        // Same logic as open
        public override void close()
        {    
            if (!IsClosing)
            {
                if (!Timer.Enabled)
                {
                    Timer.Start();
                }
                   
                IsClosing = true;
                IsOpening = false;
            }       
        }
    }
}
