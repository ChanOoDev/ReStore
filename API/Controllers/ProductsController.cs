using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(StoreContext context) : ControllerBase
    {
      
        private readonly StoreContext _context=context;
        [HttpGet]
        public ActionResult<List<Product>> GetProducts(){
            var products=_context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id){
            var product=_context.Products.Find(id);
            return Ok(product);
        }
    }
}