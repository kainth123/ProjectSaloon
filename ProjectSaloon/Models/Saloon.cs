using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSaloon.Models
{
    public class Saloon
    {
        [Key]
        public int SaloonID { get; set; }
        public string SaloonName { get; set; }
        public string SaloonAddress { get; set; }
        public int Contact_Number { get; set; }
    }
}
