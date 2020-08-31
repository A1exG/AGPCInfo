using AGPCInfo.Client.Library.Model;
using System.IO;

namespace AGPCInfo.Client.Library.Helpers
{
    public class WriterInFile : IWriterInFile
    {
        public void WriteInFile(ThisPCClientModel pc)
        {
            using (StreamWriter w = new StreamWriter("config.txt", false))
            {
                w.WriteLine("****************************************************************************************");

                w.WriteLine("Имя ПК - {0}", pc.PCName);
                w.WriteLine("****************************************************************************************");

                w.WriteLine("Операционная система - {0}", pc.OperativeSystem.OperativeSystemName);
                w.WriteLine("****************************************************************************************");

                w.WriteLine("Процессор - {0}", pc.CPU.CPUName);
                w.WriteLine("****************************************************************************************");

                foreach (var drive in pc.Drive)
                {
                    w.WriteLine("Диск - {0}. Объём - {1}. Свободное место - {2}", drive.VolumeLabel, drive.TotalSize, drive.TotalFreeSpace);
                }
                w.WriteLine("****************************************************************************************");

                foreach (var gpu in pc.GPU)
                {
                    w.WriteLine("Видеокарта - {0}. Версия драйвера - {1}", gpu.GPUName, gpu.GPUDriverVersion);
                }
                w.WriteLine("****************************************************************************************");

                w.WriteLine("Оперативная память. Всего - {0}", pc.RAM.TotalMemorySize);
                w.WriteLine("****************************************************************************************");
            }
        }
    }
}
