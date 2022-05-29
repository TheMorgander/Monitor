using System.Windows.Forms;

namespace Monitor
{
    partial class Monitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cpu_header = new System.Windows.Forms.Label();
            this.gpu_header = new System.Windows.Forms.Label();
            this.ram_header = new System.Windows.Forms.Label();
            this.disk_header = new System.Windows.Forms.Label();
            this.network_header = new System.Windows.Forms.Label();
            this.cpu_outline = new System.Windows.Forms.Panel();
            this.cpu_usage_value = new System.Windows.Forms.Label();
            this.cpu_temp_value = new System.Windows.Forms.Label();
            this.cpu_usage_suffix = new System.Windows.Forms.Label();
            this.cpu_temp_suffix = new System.Windows.Forms.Label();
            this.gpu_outline = new System.Windows.Forms.Panel();
            this.gpu_usage_value = new System.Windows.Forms.Label();
            this.gpu_temp_value = new System.Windows.Forms.Label();
            this.gpu_usage_suffix = new System.Windows.Forms.Label();
            this.gpu_temp_suffix = new System.Windows.Forms.Label();
            this.ram_outline = new System.Windows.Forms.Panel();
            this.ram_usage_value = new System.Windows.Forms.Label();
            this.ram_usage_suffix = new System.Windows.Forms.Label();
            this.disk_outline = new System.Windows.Forms.Panel();
            this.disk_write_suffix = new System.Windows.Forms.Label();
            this.disk_read_suffix = new System.Windows.Forms.Label();
            this.disk_write_value = new System.Windows.Forms.Label();
            this.disk_read_value = new System.Windows.Forms.Label();
            this.network_outline = new System.Windows.Forms.Panel();
            this.network_upload_value = new System.Windows.Forms.Label();
            this.network_download_value = new System.Windows.Forms.Label();
            this.network_upload_suffix = new System.Windows.Forms.Label();
            this.network_download_suffix = new System.Windows.Forms.Label();
            this.cpu_outline.SuspendLayout();
            this.gpu_outline.SuspendLayout();
            this.ram_outline.SuspendLayout();
            this.disk_outline.SuspendLayout();
            this.network_outline.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpu_header
            // 
            this.cpu_header.AutoSize = true;
            this.cpu_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.cpu_header.Location = new System.Drawing.Point(32, -2);
            this.cpu_header.Name = "cpu_header";
            this.cpu_header.Size = new System.Drawing.Size(36, 17);
            this.cpu_header.TabIndex = 4;
            this.cpu_header.Text = "CPU";
            this.cpu_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpu_header
            // 
            this.gpu_header.AutoSize = true;
            this.gpu_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gpu_header.Location = new System.Drawing.Point(131, -2);
            this.gpu_header.Name = "gpu_header";
            this.gpu_header.Size = new System.Drawing.Size(38, 17);
            this.gpu_header.TabIndex = 0;
            this.gpu_header.Text = "GPU";
            this.gpu_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ram_header
            // 
            this.ram_header.AutoSize = true;
            this.ram_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(135)))), ((int)(((byte)(250)))));
            this.ram_header.Location = new System.Drawing.Point(230, -2);
            this.ram_header.Name = "ram_header";
            this.ram_header.Size = new System.Drawing.Size(38, 17);
            this.ram_header.TabIndex = 3;
            this.ram_header.Text = "RAM";
            this.ram_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disk_header
            // 
            this.disk_header.AutoSize = true;
            this.disk_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.disk_header.Location = new System.Drawing.Point(332, -2);
            this.disk_header.Name = "disk_header";
            this.disk_header.Size = new System.Drawing.Size(35, 17);
            this.disk_header.TabIndex = 2;
            this.disk_header.Text = "Disk";
            this.disk_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // network_header
            // 
            this.network_header.AutoSize = true;
            this.network_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(142)))));
            this.network_header.Location = new System.Drawing.Point(419, -2);
            this.network_header.Name = "network_header";
            this.network_header.Size = new System.Drawing.Size(59, 17);
            this.network_header.TabIndex = 1;
            this.network_header.Text = "Network";
            this.network_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_outline
            // 
            this.cpu_outline.BackColor = System.Drawing.Color.Transparent;
            this.cpu_outline.Controls.Add(this.cpu_usage_value);
            this.cpu_outline.Controls.Add(this.cpu_temp_value);
            this.cpu_outline.Controls.Add(this.cpu_usage_suffix);
            this.cpu_outline.Controls.Add(this.cpu_temp_suffix);
            this.cpu_outline.Location = new System.Drawing.Point(6, 2);
            this.cpu_outline.Margin = new System.Windows.Forms.Padding(4);
            this.cpu_outline.Name = "cpu_outline";
            this.cpu_outline.Size = new System.Drawing.Size(90, 55);
            this.cpu_outline.TabIndex = 9;
            this.cpu_outline.Paint += new System.Windows.Forms.PaintEventHandler(this.cpu_Paint);
            // 
            // cpu_usage_value
            // 
            this.cpu_usage_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_usage_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.cpu_usage_value.Location = new System.Drawing.Point(22, 11);
            this.cpu_usage_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu_usage_value.Name = "cpu_usage_value";
            this.cpu_usage_value.Size = new System.Drawing.Size(25, 20);
            this.cpu_usage_value.TabIndex = 0;
            this.cpu_usage_value.Text = "1";
            this.cpu_usage_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cpu_temp_value
            // 
            this.cpu_temp_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_temp_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.cpu_temp_value.Location = new System.Drawing.Point(22, 27);
            this.cpu_temp_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu_temp_value.Name = "cpu_temp_value";
            this.cpu_temp_value.Size = new System.Drawing.Size(25, 20);
            this.cpu_temp_value.TabIndex = 1;
            this.cpu_temp_value.Text = "1";
            this.cpu_temp_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cpu_usage_suffix
            // 
            this.cpu_usage_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_usage_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.cpu_usage_suffix.Location = new System.Drawing.Point(43, 11);
            this.cpu_usage_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu_usage_suffix.Name = "cpu_usage_suffix";
            this.cpu_usage_suffix.Size = new System.Drawing.Size(40, 20);
            this.cpu_usage_suffix.TabIndex = 2;
            this.cpu_usage_suffix.Text = "%";
            // 
            // cpu_temp_suffix
            // 
            this.cpu_temp_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_temp_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.cpu_temp_suffix.Location = new System.Drawing.Point(43, 27);
            this.cpu_temp_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu_temp_suffix.Name = "cpu_temp_suffix";
            this.cpu_temp_suffix.Size = new System.Drawing.Size(40, 20);
            this.cpu_temp_suffix.TabIndex = 3;
            this.cpu_temp_suffix.Text = "°C";
            // 
            // gpu_outline
            // 
            this.gpu_outline.BackColor = System.Drawing.Color.Transparent;
            this.gpu_outline.Controls.Add(this.gpu_usage_value);
            this.gpu_outline.Controls.Add(this.gpu_temp_value);
            this.gpu_outline.Controls.Add(this.gpu_usage_suffix);
            this.gpu_outline.Controls.Add(this.gpu_temp_suffix);
            this.gpu_outline.Location = new System.Drawing.Point(104, 2);
            this.gpu_outline.Margin = new System.Windows.Forms.Padding(4);
            this.gpu_outline.Name = "gpu_outline";
            this.gpu_outline.Size = new System.Drawing.Size(90, 55);
            this.gpu_outline.TabIndex = 5;
            this.gpu_outline.Paint += new System.Windows.Forms.PaintEventHandler(this.gpu_Paint);
            // 
            // gpu_usage_value
            // 
            this.gpu_usage_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_usage_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gpu_usage_value.Location = new System.Drawing.Point(22, 11);
            this.gpu_usage_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpu_usage_value.Name = "gpu_usage_value";
            this.gpu_usage_value.Size = new System.Drawing.Size(25, 20);
            this.gpu_usage_value.TabIndex = 0;
            this.gpu_usage_value.Text = "1";
            this.gpu_usage_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpu_temp_value
            // 
            this.gpu_temp_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_temp_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gpu_temp_value.Location = new System.Drawing.Point(22, 27);
            this.gpu_temp_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpu_temp_value.Name = "gpu_temp_value";
            this.gpu_temp_value.Size = new System.Drawing.Size(25, 20);
            this.gpu_temp_value.TabIndex = 1;
            this.gpu_temp_value.Text = "1";
            this.gpu_temp_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpu_usage_suffix
            // 
            this.gpu_usage_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_usage_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gpu_usage_suffix.Location = new System.Drawing.Point(43, 11);
            this.gpu_usage_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpu_usage_suffix.Name = "gpu_usage_suffix";
            this.gpu_usage_suffix.Size = new System.Drawing.Size(40, 20);
            this.gpu_usage_suffix.TabIndex = 2;
            this.gpu_usage_suffix.Text = "%";
            // 
            // gpu_temp_suffix
            // 
            this.gpu_temp_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_temp_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gpu_temp_suffix.Location = new System.Drawing.Point(43, 27);
            this.gpu_temp_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpu_temp_suffix.Name = "gpu_temp_suffix";
            this.gpu_temp_suffix.Size = new System.Drawing.Size(40, 20);
            this.gpu_temp_suffix.TabIndex = 3;
            this.gpu_temp_suffix.Text = "°C";
            // 
            // ram_outline
            // 
            this.ram_outline.BackColor = System.Drawing.Color.Transparent;
            this.ram_outline.Controls.Add(this.ram_usage_value);
            this.ram_outline.Controls.Add(this.ram_usage_suffix);
            this.ram_outline.Location = new System.Drawing.Point(204, 2);
            this.ram_outline.Margin = new System.Windows.Forms.Padding(4);
            this.ram_outline.Name = "ram_outline";
            this.ram_outline.Size = new System.Drawing.Size(90, 55);
            this.ram_outline.TabIndex = 6;
            this.ram_outline.Paint += new System.Windows.Forms.PaintEventHandler(this.ram_Paint);
            // 
            // ram_usage_value
            // 
            this.ram_usage_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_usage_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(135)))), ((int)(((byte)(250)))));
            this.ram_usage_value.Location = new System.Drawing.Point(25, 18);
            this.ram_usage_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ram_usage_value.Name = "ram_usage_value";
            this.ram_usage_value.Size = new System.Drawing.Size(25, 20);
            this.ram_usage_value.TabIndex = 0;
            this.ram_usage_value.Text = "1";
            this.ram_usage_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ram_usage_suffix
            // 
            this.ram_usage_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_usage_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(135)))), ((int)(((byte)(250)))));
            this.ram_usage_suffix.Location = new System.Drawing.Point(45, 18);
            this.ram_usage_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ram_usage_suffix.Name = "ram_usage_suffix";
            this.ram_usage_suffix.Size = new System.Drawing.Size(40, 20);
            this.ram_usage_suffix.TabIndex = 1;
            this.ram_usage_suffix.Text = "%";
            // 
            // disk_outline
            // 
            this.disk_outline.BackColor = System.Drawing.Color.Transparent;
            this.disk_outline.Controls.Add(this.disk_write_suffix);
            this.disk_outline.Controls.Add(this.disk_read_suffix);
            this.disk_outline.Controls.Add(this.disk_write_value);
            this.disk_outline.Controls.Add(this.disk_read_value);
            this.disk_outline.Location = new System.Drawing.Point(304, 2);
            this.disk_outline.Margin = new System.Windows.Forms.Padding(4);
            this.disk_outline.Name = "disk_outline";
            this.disk_outline.Size = new System.Drawing.Size(90, 55);
            this.disk_outline.TabIndex = 7;
            this.disk_outline.Paint += new System.Windows.Forms.PaintEventHandler(this.disk_Paint);
            // 
            // disk_write_suffix
            // 
            this.disk_write_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_write_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.disk_write_suffix.Location = new System.Drawing.Point(40, 27);
            this.disk_write_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disk_write_suffix.Name = "disk_write_suffix";
            this.disk_write_suffix.Size = new System.Drawing.Size(45, 20);
            this.disk_write_suffix.TabIndex = 3;
            this.disk_write_suffix.Text = "MB/s";
            // 
            // disk_read_suffix
            // 
            this.disk_read_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_read_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.disk_read_suffix.Location = new System.Drawing.Point(40, 11);
            this.disk_read_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disk_read_suffix.Name = "disk_read_suffix";
            this.disk_read_suffix.Size = new System.Drawing.Size(45, 20);
            this.disk_read_suffix.TabIndex = 2;
            this.disk_read_suffix.Text = "MB/s";
            // 
            // disk_write_value
            // 
            this.disk_write_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_write_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.disk_write_value.Location = new System.Drawing.Point(5, 27);
            this.disk_write_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disk_write_value.Name = "disk_write_value";
            this.disk_write_value.Size = new System.Drawing.Size(40, 20);
            this.disk_write_value.TabIndex = 1;
            this.disk_write_value.Text = "1";
            this.disk_write_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // disk_read_value
            // 
            this.disk_read_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_read_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.disk_read_value.Location = new System.Drawing.Point(5, 11);
            this.disk_read_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disk_read_value.Name = "disk_read_value";
            this.disk_read_value.Size = new System.Drawing.Size(40, 20);
            this.disk_read_value.TabIndex = 0;
            this.disk_read_value.Text = "1";
            this.disk_read_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // network_outline
            // 
            this.network_outline.BackColor = System.Drawing.Color.Transparent;
            this.network_outline.Controls.Add(this.network_upload_value);
            this.network_outline.Controls.Add(this.network_download_value);
            this.network_outline.Controls.Add(this.network_upload_suffix);
            this.network_outline.Controls.Add(this.network_download_suffix);
            this.network_outline.Location = new System.Drawing.Point(404, 2);
            this.network_outline.Margin = new System.Windows.Forms.Padding(4);
            this.network_outline.Name = "network_outline";
            this.network_outline.Size = new System.Drawing.Size(90, 55);
            this.network_outline.TabIndex = 8;
            this.network_outline.Paint += new System.Windows.Forms.PaintEventHandler(this.network_Paint);
            // 
            // network_upload_value
            // 
            this.network_upload_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_upload_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(142)))));
            this.network_upload_value.Location = new System.Drawing.Point(5, 11);
            this.network_upload_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.network_upload_value.Name = "network_upload_value";
            this.network_upload_value.Size = new System.Drawing.Size(40, 20);
            this.network_upload_value.TabIndex = 0;
            this.network_upload_value.Text = "1";
            this.network_upload_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // network_download_value
            // 
            this.network_download_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_download_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(142)))));
            this.network_download_value.Location = new System.Drawing.Point(5, 27);
            this.network_download_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.network_download_value.Name = "network_download_value";
            this.network_download_value.Size = new System.Drawing.Size(40, 20);
            this.network_download_value.TabIndex = 1;
            this.network_download_value.Text = "1";
            this.network_download_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // network_upload_suffix
            // 
            this.network_upload_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_upload_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(142)))));
            this.network_upload_suffix.Location = new System.Drawing.Point(40, 11);
            this.network_upload_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.network_upload_suffix.Name = "network_upload_suffix";
            this.network_upload_suffix.Size = new System.Drawing.Size(45, 20);
            this.network_upload_suffix.TabIndex = 2;
            this.network_upload_suffix.Text = "MB/s";
            // 
            // network_download_suffix
            // 
            this.network_download_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_download_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(142)))));
            this.network_download_suffix.Location = new System.Drawing.Point(40, 27);
            this.network_download_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.network_download_suffix.Name = "network_download_suffix";
            this.network_download_suffix.Size = new System.Drawing.Size(45, 20);
            this.network_download_suffix.TabIndex = 3;
            this.network_download_suffix.Text = "MB/s";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 60);
            this.Controls.Add(this.gpu_header);
            this.Controls.Add(this.network_header);
            this.Controls.Add(this.disk_header);
            this.Controls.Add(this.ram_header);
            this.Controls.Add(this.cpu_header);
            this.Controls.Add(this.gpu_outline);
            this.Controls.Add(this.ram_outline);
            this.Controls.Add(this.disk_outline);
            this.Controls.Add(this.network_outline);
            this.Controls.Add(this.cpu_outline);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Monitor";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.cpu_outline.ResumeLayout(false);
            this.gpu_outline.ResumeLayout(false);
            this.ram_outline.ResumeLayout(false);
            this.disk_outline.ResumeLayout(false);
            this.network_outline.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cpu_header;
        private Label gpu_header;
        private Label ram_header;
        private Label disk_header;
        private Label network_header;
        private Panel cpu_outline;
        private Label cpu_usage_value;
        private Label cpu_usage_suffix;
        private Label cpu_temp_value;
        private Label cpu_temp_suffix;
        private Panel gpu_outline;
        private Label gpu_usage_value;
        private Label gpu_usage_suffix;
        private Label gpu_temp_value;
        private Label gpu_temp_suffix;
        private Panel ram_outline;
        private Label ram_usage_value;
        private Label ram_usage_suffix;
        private Panel disk_outline;
        private Label disk_read_value;
        private Label disk_read_suffix;
        private Label disk_write_value;
        private Label disk_write_suffix;
        private Panel network_outline;
        private Label network_upload_value;
        private Label network_upload_suffix;
        private Label network_download_value;
        private Label network_download_suffix;
    }
}

