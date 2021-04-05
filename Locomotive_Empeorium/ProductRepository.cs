using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Locomotive_Empeorium
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }




        public IEnumerable<Products> GetProducts()
        {
           
                return _conn.Query<Products>("SELECT * FROM locomotive_database;");
          

           

        }
    }
}
