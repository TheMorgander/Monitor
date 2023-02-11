using LibreHardwareMonitor.Hardware;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace Monitor
{
    public class Resources : INotifyPropertyChanged
    {
        /******************************************************************/
        #region Watched Variables

        #region CPU Values
        //*** CPU Usage Value ***//
        private string _cpu_usage_value = "--";
        public string cpu_usage_value { get { return _cpu_usage_value; } set { _cpu_usage_value = value; } }

        //*** CPU Usage Suffix ***//
        private string _cpu_usage_suffix = "%";
        public string cpu_usage_suffix { get { return _cpu_usage_suffix; } set { _cpu_usage_suffix = value; } }

        //*** CPU Temprature Value ***//
        private string _cpu_temp_value = "--";
        public string cpu_temp_value { get { return _cpu_temp_value; } set { _cpu_temp_value = value; } }

        //*** CPU Temprature Suffix ***//
        private string _cpu_temp_suffix = "°C";
        public string cpu_temp_suffix { get { return _cpu_temp_suffix; } set { _cpu_temp_suffix = value; } }
        #endregion

        #region GPU Values
        //*** GPU Usage Value ***//
        private string _gpu_usage_value = "--";
        public string gpu_usage_value { get { return _gpu_usage_value; } set { _gpu_usage_value = value; } }

        //*** GPU Usage Suffix ***//
        private string _gpu_usage_suffix = "%";
        public string gpu_usage_suffix { get { return _gpu_usage_suffix; } set { _gpu_usage_suffix = value; } }

        //*** GPU Temprature Value ***//
        private string _gpu_temp_value = "--";
        public string gpu_temp_value { get { return _gpu_temp_value; } set { _gpu_temp_value = value; } }

        //*** GPU Temprature Suffix ***//
        private string _gpu_temp_suffix = "°C";
        public string gpu_temp_suffix { get { return _gpu_temp_suffix; } set { _gpu_temp_suffix = value; } }
        #endregion

        #region RAM Values
        //*** Ram Usage Value ***//
        private string _ram_usage_value = "--";
        public string ram_usage_value { get { return _ram_usage_value; } set { _ram_usage_value = value; } }

        //*** Ram Usage Suffix ***//
        private string _ram_usage_suffix = "%";
        public string ram_usage_suffix { get { return _ram_usage_suffix; } set { _ram_usage_suffix = value; } }
        #endregion

        #region Disk Values
        //*** Disk Read Value ***//
        private string _disk_read_value = "--";
        public string disk_read_value { get { return _disk_read_value; } set { _disk_read_value = value; } }

        //*** Disk Read Suffix ***//
        private string _disk_read_suffix = "B/s";
        public string disk_read_suffix { get { return _disk_read_suffix; } set { _disk_read_suffix = value; } }

        //*** Disk Write Value ***//
        private string _disk_write_value = "--";
        public string disk_write_value { get { return _disk_write_value; } set { _disk_write_value = value; } }

        //*** Disk Write Suffix ***//
        private string _disk_write_suffix = "B/s";
        public string disk_write_suffix { get { return _disk_write_suffix; } set { _disk_write_suffix = value; } }
        #endregion

        #region Network Values
        //*** Network Upload Value ***//
        private string _network_upload_value = "--";
        public string network_upload_value { get { return _network_upload_value; } set { _network_upload_value = value; } }

        //*** Network Upload Suffix ***//
        private string _network_upload_suffix = "B/s";
        public string network_upload_suffix { get { return _network_upload_suffix; } set { _network_upload_suffix = value; } }

        //*** Network Download Value ***//
        private string _network_download_value = "--";
        public string network_download_value { get { return _network_download_value; } set { _network_download_value = value; } }

        //*** Network Download Suffix ***//
        private string _network_download_suffix = "B/s";
        public string network_download_suffix { get { return _network_download_suffix; } set { _network_download_suffix = value; } }
        #endregion

        #endregion
        /******************************************************************/

        /******************************************************************/
        #region Variable Listener
        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //*** Property Updater ***//
        private bool update_values
        {
            set
            {
                OnPropertyChanged("cpu_usage_value");
                OnPropertyChanged("cpu_usage_suffix");
                OnPropertyChanged("cpu_temp_value");
                OnPropertyChanged("cpu_temp_suffix");
                OnPropertyChanged("gpu_usage_value");
                OnPropertyChanged("gpu_usage_suffix");
                OnPropertyChanged("gpu_temp_value");
                OnPropertyChanged("gpu_temp_suffix");
                OnPropertyChanged("ram_usage_value");
                OnPropertyChanged("ram_usage_suffix");
                OnPropertyChanged("disk_read_value");
                OnPropertyChanged("disk_read_suffix");
                OnPropertyChanged("disk_write_value");
                OnPropertyChanged("disk_write_suffix");
                OnPropertyChanged("network_upload_value");
                OnPropertyChanged("network_upload_suffix");
                OnPropertyChanged("network_download_value");
                OnPropertyChanged("network_download_suffix");
            }
        }
        #endregion
        /******************************************************************/

        //*** Collect Resources ***//
        public async void Collect(Computer computer)
        {
            //Run async
            await Task.Run(() =>
            {
                //Set which values are scanned
                computer.IsCpuEnabled = true;
                computer.IsGpuEnabled = true;
                computer.IsMemoryEnabled = true;
                computer.IsStorageEnabled = true;
                computer.IsNetworkEnabled = true;

                //Start scanning values
                computer.Open();

                //Keep track of how many times looped
                int loop_counter = 0;

                update_values = true;

                //Keep scanning values forever
                while (true)
                {
                    //Scan each hardware type
                    foreach (IHardware hardware in computer.Hardware)
                    {
                        //Scan each hardware component for CPU's
                        if (hardware.HardwareType == HardwareType.Cpu)
                        {
                            //Force value update
                            hardware.Update();

                            //Scan for desired CPU sensors
                            foreach (var sensor in hardware.Sensors)
                            {
                                //Get CPU Usage value
                                if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("CPU Total"))
                                {
                                    cpu_usage_value = ((int)sensor.Value.GetValueOrDefault()).ToString();
                                    cpu_usage_suffix = "%";
                                }

                                //Get CPU Temperature value
                                if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("CPU Package"))
                                {
                                    cpu_temp_value = ((int)sensor.Value.GetValueOrDefault()).ToString();
                                    cpu_temp_suffix = "°C";
                                }
                            }
                        }

                        //Scan each hardware component for GPU's
                        else if (hardware.HardwareType == HardwareType.GpuNvidia)
                        {
                            //Force value update
                            hardware.Update();

                            //Scan for desired GPU sensors
                            foreach (var sensor in hardware.Sensors)
                            {
                                //Get GPU Usage value
                                if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("GPU Core"))
                                {
                                    gpu_usage_value = ((int)sensor.Value.GetValueOrDefault()).ToString();
                                    gpu_usage_suffix = "%";
                                }

                                //Get GPU Temperature value
                                if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("GPU Core"))
                                {
                                    gpu_temp_value = ((int)sensor.Value.GetValueOrDefault()).ToString();
                                    gpu_temp_suffix = "°C";
                                }
                            }
                        }

                        //Scan each hardware component for RAM
                        else if (hardware.HardwareType == HardwareType.Memory)
                        {
                            //Force value update
                            hardware.Update();

                            //Scan for desired RAM sensors
                            foreach (var sensor in hardware.Sensors)
                            {
                                //Get RAM Usage value
                                if (sensor.SensorType == SensorType.Load && sensor.Name == ("Memory"))
                                {
                                    ram_usage_value = ((int)sensor.Value.GetValueOrDefault()).ToString();
                                    ram_usage_suffix = "%";
                                }
                            }
                        }

                        //Scan each hardware component for Storage
                        else if (hardware.HardwareType == HardwareType.Storage)
                        {
                            //Force value update
                            hardware.Update();

                            //Scan for desired Disk sensors
                            foreach (var sensor in hardware.Sensors)
                            {
                                //Get Disk Usage value
                                if (sensor.SensorType == SensorType.Throughput && sensor.Name.Contains("Read Rate"))
                                {
                                    long temp_value = (long)sensor.Value.GetValueOrDefault();

                                    disk_read_value = ByteConversion(temp_value);
                                    disk_read_suffix = SuffixSelector(temp_value);
                                }

                                //Get Disk Usage value
                                if (sensor.SensorType == SensorType.Throughput && sensor.Name.Contains("Write Rate"))
                                {
                                    long temp_value = (long)sensor.Value.GetValueOrDefault();

                                    disk_write_value = ByteConversion(temp_value);
                                    disk_write_suffix = SuffixSelector(temp_value);
                                }
                            }

                        }

                        //Scan each hardware component for Network
                        else if (hardware.HardwareType == HardwareType.Network)
                        {
                            //Force value update
                            hardware.Update();

                            //Scan for desired Network sensors
                            foreach (var sensor in hardware.Sensors)
                            {
                                //Get Network Usage value
                                if (sensor.SensorType == SensorType.Throughput && sensor.Name.Contains("Upload Speed"))
                                {
                                    long temp_value = (long)sensor.Value.GetValueOrDefault();

                                    network_upload_value = ByteConversion(temp_value);
                                    network_upload_suffix = SuffixSelector(temp_value);
                                }

                                //Get Network Usage value
                                if (sensor.SensorType == SensorType.Throughput && sensor.Name.Contains("Download Speed"))
                                {
                                    long temp_value = (long)sensor.Value.GetValueOrDefault();

                                    network_download_value = ByteConversion(temp_value);
                                    network_download_suffix = SuffixSelector(temp_value);
                                }
                            }
                        }
                    }

                    update_values = true;

                    //Delay for 500 ms before looping again
                    Thread.Sleep(500);

                    //Reload periodicly
                    if (loop_counter % 300 == 0)
                    {
                        computer.Reset();
                        loop_counter = 0;
                    }

                    //Increment counter
                    loop_counter++;
                }
            });
        }

        //*** Convert Bytes ***//
        private string ByteConversion(long value)
        {
            if (value < 1024)
            {
                return value.ToString();
            }
            else if (value < (1024 * 1024))
            {
                return (value / 1024).ToString();
            }
            else if (value < (1024 * 1024 * 1024))
            {
                return (value / (1024 * 1024)).ToString();
            }
            else
            {
                return (value / (1024 * 1024 * 1024)).ToString();
            }
        }

        //*** Get Correct Suffix ***//
        private string SuffixSelector(long value)
        {
            if (value < 1024)
            {
                return "B/s";
            }
            else if (value < (1024 * 1024))
            {
                return "KB/s";
            }
            else if (value < (1024 * 1024 * 1024))
            {
                return "MB/s";
            }
            else
            {
                return "GB/s";
            }
        }
    }
}
