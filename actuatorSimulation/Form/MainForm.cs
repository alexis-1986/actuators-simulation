using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actuatorSimulation
{
    public partial class MainForm : Form
    {
        // Valves declaration
        private ShutOffValve v1;
        private ManualValve v2;
        private AutoValve v3;
        private ControlValve v4;

        public MainForm()
        {
            InitializeComponent();
        }
    
        private void MainFormLoad(object sender, EventArgs e)
        {
            #region Valve 1 (ShutOffValve) initialization

            // Valve 1 init with runtime = 5s and speed = 5m/s
            v1 = new ShutOffValve("Manual shut off valve", 5, 5);
            
            // Progress bar Value property is bind to the valve Position property
            pBar1.DataBindings.Add("Value", v1, "Position", false, DataSourceUpdateMode.OnPropertyChanged);
            // Progress bar maximum value is set to the valve  EndPosition
            pBar1.Maximum = (int)v1.EndPosition;

            // The labels indicate the valve Open or Close state
            // the BackColor property is bind to valve TlOpen property
            Binding bindLblOpen1 = new Binding("BackColor", v1, "TlOpen");
            // formatting is required to convert the boolean value to a color
            // https://stackoverflow.com/questions/20017748/binding-a-bool-property-to-backcolor-property-of-a-winform
            bindLblOpen1.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblOpen1.DataBindings.Add(bindLblOpen1);

            // Same as above for the valve TlClose property
            Binding bindLblClose1 = new Binding("BackColor", v1, "TlClose");
            bindLblClose1.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblClose1.DataBindings.Add(bindLblClose1);

            // The groupBox label is bind to the valve Type property
            gBx1.DataBindings.Add("Text", v1, "Type", false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion ShutOffValve initialization

            #region Valve 2 (ManualValve) initialization

            // Valve 2 init with endPosition = 10m and step = 1m
            v2 = new ManualValve("Manual control valve", 10, 1);

            // Progress bar binding
            pBar2.DataBindings.Add("Value", v2, "Position", false, DataSourceUpdateMode.OnPropertyChanged);
            pBar2.Maximum = (int)v2.EndPosition;

            // Labels bindings
            Binding bindLblOpen2 = new Binding("BackColor", v2, "TlOpen");
            bindLblOpen2.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblOpen2.DataBindings.Add(bindLblOpen2);

            Binding bindLblClose2 = new Binding("BackColor", v2, "TlClose");
            bindLblClose2.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblClose2.DataBindings.Add(bindLblClose2);

            // Group box binding
            gBx2.DataBindings.Add("Text", v2, "Type", false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion

            #region Valve 3 (AutoValve) initialization

            // Valve 3 init with runtime = 5s and speed = 2m/s
            v3 = new AutoValve("Auto control valve", 5, 2);

            // Progress bar binding
            pBar3.DataBindings.Add("Value", v3, "Position", false, DataSourceUpdateMode.OnPropertyChanged);
            pBar3.Maximum = (int)v3.EndPosition;

            // Labels bindings
            Binding bindLblOpen3 = new Binding("BackColor", v3, "TlOpen");
            bindLblOpen3.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblOpen3.DataBindings.Add(bindLblOpen3);

            Binding bindLblClose3 = new Binding("BackColor", v3, "TlClose");
            bindLblClose3.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblClose3.DataBindings.Add(bindLblClose3);

            // Group box binding
            gBx3.DataBindings.Add("Text", v3, "Type", false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion

            #region Valve 4 (ControlValve) initialization

            // Valve 4 init with runtime = 5s and speed = 1m/s
            v4 = new ControlValve("Auto control valve with position", 5, 1);

            // Progress bar binding
            pBar4.DataBindings.Add("Value", v4, "Position", false, DataSourceUpdateMode.OnPropertyChanged);
            pBar4.Maximum = (int)v4.EndPosition;

            // Labels bindings
            Binding bindLblOpen4 = new Binding("BackColor", v4, "TlOpen");
            bindLblOpen4.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblOpen4.DataBindings.Add(bindLblOpen4);

            Binding bindLblClose4 = new Binding("BackColor", v4, "TlClose");
            bindLblClose4.Format += new ConvertEventHandler((s, ce) => { ce.Value = (bool)ce.Value ? Color.Red : Color.Gray; });
            lblClose4.DataBindings.Add(bindLblClose4);

            // Group box binding
            gBx4.DataBindings.Add("Text", v4, "Type", false, DataSourceUpdateMode.OnPropertyChanged);

            // Text box binding to valve CurrentValue property
            txtCurrent4.DataBindings.Add("Text", v4, "CurrentValue", false, DataSourceUpdateMode.OnPropertyChanged);
            
            #endregion
        }

        // Button open 1 click event
        private void btnOpen1Click(object sender, EventArgs e)
        {
            // Valve 1 open command
            v1.open();
        }

        // Button close 1 click event
        private void btnClose1Click(object sender, EventArgs e)
        {
            // Valve 1 close command
            v1.close();
        }

        // Button open 2 click event
        private void btnOpen2Click(object sender, EventArgs e)
        {
            // Valve 2 open command
            v2.open();
        }

        // Button close 2 click event
        private void btnClose2Click(object sender, EventArgs e)
        {
            // Valve 2 close command
            v2.close();
        }

        // Button open 3 click event
        private void btnOpen3Click(object sender, EventArgs e)
        {
            // Valve 3 open command
            v3.open();
        }

        // Button close 3 click event
        private void btnClose3Click(object sender, EventArgs e)
        {
            // Valve 3 close command
            v3.close();
        }

        // Button stop 3 click event
        private void btnStop3Click(object sender, EventArgs e)
        {
            // Valve 3 stop command
            v3.stop();
        }

        // Button open 4 click event
        private void btnOpen4Click(object sender, EventArgs e)
        {
            // Valve 4 open command
            v4.open();
        }

        // Button close 4 click event
        private void btnClose4Click(object sender, EventArgs e)
        {
            // Valve 4 close command
            v4.close();
        }

        // Button stop 4 click event
        private void btnStop4Click(object sender, EventArgs e)
        {
            // Valve 4 stop command
            v4.stop();
        }
      
    }
}
