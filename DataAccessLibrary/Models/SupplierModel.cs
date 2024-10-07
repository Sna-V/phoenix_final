using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class SupplierModel
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateBy { get; set; }
    }
}
