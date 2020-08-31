using AGPCInfo.Client.Library.Model;

namespace AGPCInfo.Client.Library.Helpers
{
    public class PCConfiguration : IPCConfiguration
    {
        private PCInfoHelper _pcInfoHelper;
        public PCConfiguration(PCInfoHelper pcInfoHelper)
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
