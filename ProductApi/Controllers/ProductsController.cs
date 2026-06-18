using Dapper;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using System.Data;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IDbConnection _db;

        public ProductsController(IDbConnection db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _db.QueryAsync<Product>(
                "SELECT * FROM Products");

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _db.QueryAsync<Product>(
                $"SELECT * FROM Products WHERE Id={id}");

            return Ok(result);
        }
    }
}
