using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SKA.Models
{
    public class goods
    {
        [Required]
        public string Name { get; set; }
        [Range(0,Int32.MaxValue,ErrorMessage = "please type >0 number"),Required]
        public int Price { get; set; }
        public int num { get; set; }

        public int total
        {
            get
            {
                return num * Price;
            }
        }
    }
}
