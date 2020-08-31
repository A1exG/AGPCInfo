using AGPCInfo.Client.Library.Helpers;
using Ninject;

namespace AGPCInfo.Client.UI
{
    public class Bootstrapper
    {
        private IKernel _kernel;
        public Bootstrapper()
        {
            IKernel kernel = new StandardKernel();
            _kernel = kernel;

            Init();
        }

        private Bootstrapper Init()
        {
            _kernel.Bind<IConfigHelper>().To<ConfigHelper>().InSingletonScope();
            _kernel.Bind<IPCInfoHelper>().To<PCInfoHelper>().InSingletonScope();
            _kernel.Bind<IPCConfiguration>().To<PCConfiguration>().InSingletonScope();
            _kernel.Bind<IWriterInFile>().To<WriterInFile>().InSingletonScope();


            return this;
        }

        public IKernel InitDependence()
        {
            return _kernel;
        }
    }
}
