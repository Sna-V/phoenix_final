using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class InvoiceModel
    {
        public int SaleId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string RepName { get; set; }
        public DateTime SaleDate { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SubTotal { get; set; }

        public double Total { get; set; }



        public string RowNumber1 { get; set; }
        public string Description1 { get; set; }
        public string Quantity1 { get; set; }
        public string Price1 { get; set; }
        public string SubTotal1 { get; set; }
    }
}
