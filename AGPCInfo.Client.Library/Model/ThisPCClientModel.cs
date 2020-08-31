using System;
using System.Collections.Generic;

namespace AGPCInfo.Client.Library.Model
{
    public class ThisPCClientModel
    {
        public string PCName { get; set; } = Environment.MachineName;
        public OperativeSystemClientModel OperativeSystem { get; set; }
        public CPUClientModel CPU { get; set; }
        public List<GPUClientModel> GPU { get; set; }
        public RAMClientModel RAM { get; set; }
        public List<DriveClientModel> Drive { get; set; }
    }
}
