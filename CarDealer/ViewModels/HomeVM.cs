using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Models;

namespace CarDealer.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Car> Cars { get; set; }
    }
}
