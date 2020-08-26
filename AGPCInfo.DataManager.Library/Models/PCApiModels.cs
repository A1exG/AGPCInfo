using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGPCInfo.DataManager.Library.Models
{
    public class PCApiModels
    {
        public string PCName { get; set; }
        public OperativeSystemAPIModel OperativeSystem { get; set; }
        public CPUAPIModel CPU { get; set; }
        public GPUAPIModel GPU { get; set; }
        public RAMAPIModel RAM { get; set; }
        public List<DriveAPIModel> Drive { get; set; }
    }
}
