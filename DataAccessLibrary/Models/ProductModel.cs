using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Product { get; set; }
        public long Barcode { get; set; }
        public double SellPrice { get; set; }
        public int QtyInStock { get; set; }
        public string PhotoUrl { get; set; }
        public string Category { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateBy { get; set; }
    }
}
