using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_1.Business.Dtos.Responses
{
    public class GetAllProductResponse
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountRate { get; set; }
        public double DiscountedPrice => UnitPrice - (UnitPrice * DiscountRate / 100);
    }
}
