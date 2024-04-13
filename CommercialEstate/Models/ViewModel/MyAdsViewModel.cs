using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialEstate.Models.ViewModel
{
    public class MyAdsViewModel
    {
        public Users Users { get; set; }
        public Product Product { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }


    }
}
