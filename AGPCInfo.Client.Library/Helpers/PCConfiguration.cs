using AGPCInfo.Client.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace AGPCInfo.Client.Library.Helpers
{
    public class PCConfiguration
    {
        private PCInfoHelper _pcInfoHelper;
        public PCConfiguration (PCInfoHelper pcInfoHelper)
        {
            _pcInfoHelper = pcInfoHelper;
        }
        public ThisPCClientModel GetConfiguration()
        {
            ThisPCClientModel pc = new ThisPCClientModel();

            pc.OperativeSystem = _pcInfoHelper.GetOperativeSystemName();
            pc.CPU = _pcInfoHelper.GetCPU();
            pc.GPU = _pcInfoHelper.GetGPU();
            pc.RAM = _pcInfoHelper.GetRam();
            pc.Drive = _pcInfoHelper.GetDrive();

            return pc;
        }
    }
}
