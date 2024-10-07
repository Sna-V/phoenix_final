using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class AddStockModel
    {
        public string Supplier { get; set; }
        public int ProductId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
    }
}
