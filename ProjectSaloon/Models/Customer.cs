using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSaloon.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int ContactNumber { get; set; }
        public int Expenses { get; set; }
        //Foreign Key
        public int BeauticianID { get; set; }
        public Beautician Beautician_obj { get; set; }
    }
}
