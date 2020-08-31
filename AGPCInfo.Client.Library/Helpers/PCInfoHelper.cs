using AGPCInfo.Client.Library.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;

namespace AGPCInfo.Client.Library.Helpers
{
    public class PCInfoHelper : IPCInfoHelper
    {
        private ConfigHelper _config;

        public PCInfoHelper(ConfigHelper config)
        {
            _config = config;
        }

        public OperativeSystemClientModel GetOperativeSystemName()
        {

            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(_config.GetKey("QueryOS"));

            OperativeSystemClientModel os = new OperativeSystemClientModel();

            foreach (ManagementObject obj in objectSearcher.Get())
            {
                os.OperativeSystemName = obj["Caption"].ToString();
            }
            return os;
        }


        public CPUClientModel GetCPU()
        {
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(_config.GetKey("QueryCPU"));

            CPUClientModel cpu = new CPUClientModel();

            foreach (ManagementObject obj in objectSearcher.Get())
            {
                cpu.CPUName = obj["Name"].ToString();
            }
            return cpu;
        }

        public RAMClientModel GetRam()
        {
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(_config.GetKey("QueryOS"));

            RAMClientModel ram = new RAMClientModel();

            foreach (ManagementObject obj in objectSearcher.Get())
            {
                var result = Convert.ToDouble(obj["TotalVisibleMemorySize"]);
                double res = Math.Round((result / (1024 * 1024)), 2);
                ram.TotalMemorySize = res;
            }
            return ram;
        }

        public List<DriveClientModel> GetDrive()
        {
            List<DriveClientModel> output = new List<DriveClientModel>();
            

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true && d.DriveType == DriveType.Fixed)
                {
                    DriveClientModel drive = new DriveClientModel();

                    drive.VolumeLabel = d.Name;
                    drive.TotalSize = SizeSuffix(d.TotalSize).ToString();
                    drive.TotalFreeSpace = SizeSuffix(d.TotalFreeSpace).ToString();

                    output.Add(drive);
                }
            }
            return output;
        }

        public List<GPUClientModel> GetGPU()
        {
            List<GPUClientModel> output = new List<GPUClientModel>();

            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(_config.GetKey("QueryGPU"));

            

            foreach (ManagementObject obj in objectSearcher.Get())
            {
                GPUClientModel gpu = new GPUClientModel();

                gpu.GPUName = obj["Name"].ToString();
                gpu.GPUDriverVersion = obj["DriverVersion"].ToString();

                output.Add(gpu);
            }
            return output;
        }

        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }
    }
}
