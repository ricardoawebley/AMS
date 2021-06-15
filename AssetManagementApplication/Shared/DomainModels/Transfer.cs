using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementApplication.Shared.DomainModels
{
    public class Transfer : BaseModel
    {
        public int AcquisitionId { get; set; }
        public virtual Acquisition Acquisition { get; set; }
        public DateTime DateTransfered { get; set; }
    }
}
