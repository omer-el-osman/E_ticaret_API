using Core.entities;
using System.ComponentModel.DataAnnotations;

namespace E_Ticaret_API.entities
{
    public class Product:BaseEntity
    {

        public string name { get; set; }
        public string description { get; set; }

        public string picturUrl { get; set; }

        public decimal price { get; set; }

        public ProductType producttype { get; set; }
        public int productTypeid { get; set; }
    
        public ProductBrand productBrand {  get; set; }
        public int productBrandid { get; set; }
    }
}
