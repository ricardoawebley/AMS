using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementApplication.Shared.DomainModels
{
    public class Acquisition : BaseModel
    {
        public string AssetName { get; set; }
   
        public string AssetNumber { get; set; }
        public string SerialNumber { get; set; }
        public DateTime DateAquited { get; set; }
        public string  PurchesedFrom { get; set; }
        public string Details { get; set; }
        public double Cost { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Transfer> Transfers { get; set; }



    }
}
