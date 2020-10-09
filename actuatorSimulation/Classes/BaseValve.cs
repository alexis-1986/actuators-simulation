using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace actuatorSimulation
{
    // BaseValve is the root class for valves and define all the common features.
    // BaseValve implements INotifyPropertyChanged to allow data bindings with HMI
    // components
    public class BaseValve: INotifyPropertyChanged
    {
        // Property changed event
        public event PropertyChangedEventHandler PropertyChanged;

        // Method firing the property changed event
        // The attribute CallerMemberName sets name argument to the corresponding property name 
        // without explicitely passing it 
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        // Valve position
        private double position;
        public virtual double Position { get { return position; } set { position = value; OnPropertyChanged(); } }

        // Valve type
        private string type;
        public string Type { get => type; set => type = value; }

        // Valve end position (progress bar maximum value)
        private double endPosition;
        public virtual double EndPosition { get => endPosition; set => endPosition = value; }

        // Valve closing or opening step (m)
        private double step;
        public virtual double Step { get => step; set => step = value; }

        // Open position indicator
        private bool tlOpen;
        public virtual bool TlOpen { get { return tlOpen; } set { tlOpen = value; OnPropertyChanged(); } }

        // Close position indicator
        private bool tlClose;
        public virtual bool TlClose { get { return tlClose; } set { tlClose = value; OnPropertyChanged(); } }

        /// <summary>
        /// Method used to increment or decrement valve
        /// position. Marked as virtual for overriding in derived classes
        /// </summary>
        /// <param name="step"></param>
        /// Increment or decrement value
        public virtual void updatePos(double step)
        {
            // Calculate next position
            double nextPos = Position + step;

            // If the next position is negative
            if (nextPos < 0)
            {
                // Clamp it to 0
                Position = 0;
            }
            // If the next position is greater than end position
            else if (nextPos > EndPosition)
            {
                // Clamp it to end position
                Position = EndPosition;
            }
            // Else increment or decrement the position
            else
            {
                Position += step;
            }

            Debug.WriteLine("Current position: " + Position);
        }

        /// <summary>
        /// Constructor marked protected to prevent BaseValve class
        /// instanciation
        /// </summary>
        /// <param name="type"></param>
        /// Valve type
        protected BaseValve(string type)
        {
            Type = type;
            // Valve is set to open position by default
            Position = 0;
            // End position is set to 10 to prevent display 
            // issues
            EndPosition = 10;
            // Step is set to 1 (arbitrary)
            Step = 1;
            // Open position indicator is set and
            // close one is reset
            TlOpen = true;
            TlClose = false;
        }

        /// <summary>
        /// Method used to set open or close indicator
        /// based on the current valve position
        /// </summary>
        public virtual void updateFeedbacks()
        {
            // Valve is open
            if (Position == 0)
            {
                TlOpen = true;
                TlClose = false;

            }
            // Valve is closed
            else if (Position == EndPosition)
            {
                TlOpen = false;
                TlClose = true;

            }
            // Valve is in between
            else
            {
                TlOpen = false;
                TlClose = false;
            }
        }

        /// <summary>
        /// Method used to open the valve
        /// </summary>
        public virtual void open()
        {
            // First update the position by -Step
            updatePos(-Step);
            // update the open or close indicators
            updateFeedbacks();
        }

        /// <summary>
        /// Method used to close the valve
        /// same logic as open
        /// </summary>
        public virtual void close()
        {
            updatePos(Step);
            updateFeedbacks();
        }         
    }
}
