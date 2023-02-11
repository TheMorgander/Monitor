using LibreHardwareMonitor.Hardware;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Monitor : Form
    {
        /******************************************************************/
        #region Global Variables
        protected static Resources resources = new Resources();
        protected static Computer computer = new Computer();
        #endregion
        /******************************************************************/

        public Monitor()
        {
            //Initalize layout
            InitializeComponent();

            //Set position to top center of screen
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            Location = new System.Drawing.Point(x, 0);

            //Bind resource values to resource class
            cpu_usage_value.DataBindings.Add(new Binding("Text", resources, "cpu_usage_value", true, DataSourceUpdateMode.OnPropertyChanged));
            cpu_usage_suffix.DataBindings.Add(new Binding("Text", resources, "cpu_usage_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            cpu_temp_value.DataBindings.Add(new Binding("Text", resources, "cpu_temp_value", true, DataSourceUpdateMode.OnPropertyChanged));
            cpu_temp_suffix.DataBindings.Add(new Binding("Text", resources, "cpu_temp_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            gpu_usage_value.DataBindings.Add(new Binding("Text", resources, "gpu_usage_value", true, DataSourceUpdateMode.OnPropertyChanged));
            gpu_usage_suffix.DataBindings.Add(new Binding("Text", resources, "gpu_usage_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            gpu_temp_value.DataBindings.Add(new Binding("Text", resources, "gpu_temp_value", true, DataSourceUpdateMode.OnPropertyChanged));
            gpu_temp_suffix.DataBindings.Add(new Binding("Text", resources, "gpu_temp_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            ram_usage_value.DataBindings.Add(new Binding("Text", resources, "ram_usage_value", true, DataSourceUpdateMode.OnPropertyChanged));
            ram_usage_suffix.DataBindings.Add(new Binding("Text", resources, "ram_usage_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            disk_read_value.DataBindings.Add(new Binding("Text", resources, "disk_read_value", true, DataSourceUpdateMode.OnPropertyChanged));
            disk_read_suffix.DataBindings.Add(new Binding("Text", resources, "disk_read_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            disk_write_value.DataBindings.Add(new Binding("Text", resources, "disk_write_value", true, DataSourceUpdateMode.OnPropertyChanged));
            disk_write_suffix.DataBindings.Add(new Binding("Text", resources, "disk_write_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            network_upload_value.DataBindings.Add(new Binding("Text", resources, "network_upload_value", true, DataSourceUpdateMode.OnPropertyChanged));
            network_upload_suffix.DataBindings.Add(new Binding("Text", resources, "network_upload_suffix", true, DataSourceUpdateMode.OnPropertyChanged));
            network_download_value.DataBindings.Add(new Binding("Text", resources, "network_download_value", true, DataSourceUpdateMode.OnPropertyChanged));
            network_download_suffix.DataBindings.Add(new Binding("Text", resources, "network_download_suffix", true, DataSourceUpdateMode.OnPropertyChanged));

            //Start collecting resources
            resources.Collect(computer);
        }

        //Close hardware listener on close
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            computer.Close();
        }

        //Hide for 10 min on home key press
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.Home)
            {

                //Fade out
                for (double i = 0.70; i > 0.0; i -= 0.05)
                {
                    this.Opacity = i;
                    Thread.Sleep(10);
                }

                //Turn off for 10 minutes
                this.Visible = false;
                Thread.Sleep(600000);

                //Turn on
                this.Visible = true;
                this.Refresh();

                //Fade in
                for (double i = 0.0; i < 0.70; i += 0.05)
                {
                    this.Opacity = i;
                    Thread.Sleep(10);
                }
            }
        }

        //Hide the app for 3 seconds on hover to access content below
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            //Fade out
            for (double i = 0.70; i > 0.0; i-=0.05)
            {
                this.Opacity = i;
                Thread.Sleep(10);
            }

            //Turn off for 3 second
            this.Visible = false;
            Thread.Sleep(10000);
            this.Visible = true;
            this.Refresh();

            //Fade in
            for (double i = 0.0; i < 0.70; i += 0.05)
            {
                this.Opacity = i;
                Thread.Sleep(10);
            }
        }

        //*** Draw CPU Outline ***//
        private void cpu_Paint(object sender, PaintEventArgs e)
        {
            //Create pen
            Pen pen = new Pen(cpu_header.ForeColor, 3);

            //Create rectangle
            Rectangle rect = new Rectangle(0, 0, 67, 40);

            //Draw rectangle to screen
            e.Graphics.DrawRectangle(pen, rect);
        }

        //*** Draw GPU Outline ***//
        private void gpu_Paint(object sender, PaintEventArgs e)
        {
            //Create pen
            Pen pen = new Pen(gpu_header.ForeColor, 3);

            //Create rectangle
            Rectangle rect = new Rectangle(0, 0, 67, 40);

            //Draw rectangle to screen
            e.Graphics.DrawRectangle(pen, rect);
        }

        //*** Draw Ram Outline ***//
        private void ram_Paint(object sender, PaintEventArgs e)
        {
            //Create pen
            Pen pen = new Pen(ram_header.ForeColor, 3);

            //Create rectangle
            Rectangle rect = new Rectangle(0, 0, 67, 40);

            //Draw rectangle to screen
            e.Graphics.DrawRectangle(pen, rect);
        }

        //*** Draw Disk Outline ***//
        private void disk_Paint(object sender, PaintEventArgs e)
        {
            //Create pen
            Pen pen = new Pen(disk_header.ForeColor, 3);

            //Create rectangle
            Rectangle rect = new Rectangle(0, 0, 67, 40);

            //Draw rectangle to screen
            e.Graphics.DrawRectangle(pen, rect);
        }

        //*** Draw Network Outline ***//
        private void network_Paint(object sender, PaintEventArgs e)
        {
            //Create pen
            Pen pen = new Pen(network_header.ForeColor, 3);

            //Create rectangle
            Rectangle rect = new Rectangle(0, 0, 67, 40);

            //Draw rectangle to screen
            e.Graphics.DrawRectangle(pen, rect);
        }
    }
}
