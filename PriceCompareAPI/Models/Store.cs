using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCompareAPI.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
