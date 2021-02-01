using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSaloon.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
        //Foreign Key
        public int SaloonID { get; set; }
        public Saloon Saloon_obj { get; set; }
    }
}
