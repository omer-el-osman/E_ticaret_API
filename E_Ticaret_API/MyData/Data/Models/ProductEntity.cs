using Core;
using E_Ticaret_API.Data;
using E_Ticaret_API.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Data.Models
{
    public class ProductEntity : Ihelper<Product>
    {
        private readonly StoreContext db;

        public ProductEntity(StoreContext db)
        {
            this.db = db;
        }
   
         List<Product>  Ihelper<Product>.GetAll()
        {
            return db.Products.ToList(); ;
        }

        Product Ihelper<Product>.GetById(int id)
        {
            return db.Products.FirstOrDefault(p=>p.Id==id);
        }
    }
}
