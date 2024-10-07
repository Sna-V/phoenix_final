using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class SaleModel
    {
        public long Barcode {  get; set; }
        public int ProductId { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int QtyInStock { get; set; }
    }
}
