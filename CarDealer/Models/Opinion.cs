using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Opinion
    {
        public int Id { get; set; }
        public string UserName{ get; set; }
        public string Email  { get; set; }
        public string Message { get; set; }
        public bool ExpectAnswer{ get; set; }
    
    }
}
