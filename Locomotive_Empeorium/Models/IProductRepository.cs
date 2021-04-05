using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locomotive_Empeorium
{
   public interface IProductRepository
    {
        public IEnumerable<Products> GetProducts();
    }
}
