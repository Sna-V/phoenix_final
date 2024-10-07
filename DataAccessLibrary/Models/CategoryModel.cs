using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string Category {  get; set; }
        public string Status { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateBy { get; set; }
    }
}
