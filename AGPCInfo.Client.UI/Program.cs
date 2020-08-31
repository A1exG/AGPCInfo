using AGPCInfo.Client.Library.Helpers;
using Ninject;
using System;
using System.Management;

namespace AGPCInfo.Client.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper bootstrapper = new Bootstrapper();

            var kernel = bootstrapper.InitDependence();

            var pcConfiguration = kernel.Get<IPCConfiguration>();

            var pc = pcConfiguration.GetConfiguration();

            var writer = kernel.Get<IWriterInFile>();

            writer.WriteInFile(pc);
        }
    }
}
