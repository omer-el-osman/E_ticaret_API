using Core;
using E_Ticaret_API.Data;
using E_Ticaret_API.entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Ihelper<Product> ihelper;

        public ProductController(Ihelper<Product> ihelper)
        {
            this.ihelper = ihelper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProduct()
        {
            var AllProduct= ihelper.GetAll();
            return Ok(AllProduct);
        }
        [HttpGet("([action]/{id}")]
        public async Task<IActionResult> GetByIdProduct(int id)
        {
            var Product =  ihelper.GetById(id);
            return Ok(Product); 
        }
    }
}
