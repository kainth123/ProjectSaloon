using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSaloon.Models
{
    public class Beautician
    {

        [Key]

        public int BeauticianID { get; set; }
        public string BeauticianName { get; set; }
        public int ContactNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public int Salary { get; set; }
        //Foreign Key
        public int SaloonID { get; set; }
        public Saloon Saloon_obj { get; set; }
    }
}
