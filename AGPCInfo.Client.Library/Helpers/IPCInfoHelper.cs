using AGPCInfo.Client.Library.Model;
using System.Collections.Generic;

namespace AGPCInfo.Client.Library.Helpers
{
    public interface IPCInfoHelper
    {
        CPUClientModel GetCPU();
        List<DriveClientModel> GetDrive();
        GPUClientModel GetGPU();
        OperativeSystemClientModel GetOperativeSystemName();
        RAMClientModel GetRam();
    }
}