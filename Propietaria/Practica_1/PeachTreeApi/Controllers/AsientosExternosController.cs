using System.Collections.Generic;
using System.Threading.Tasks;
using _3thPartySoftware.DAL.SQL;
using _3thPartySoftware.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PeachTreeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsientosExternosController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> OnPost([FromBody] IEnumerable<AsientoExterno> asientoExterno)
        {
            var _dbContext = new PeachTreeDbContext();
            await _dbContext.AsientosExternos.AddRangeAsync(asientoExterno);
            await _dbContext.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT dbo.AsientosExternos ON");
            await _dbContext.SaveChangesAsync();
            await _dbContext.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT dbo.AsientosExternos OFF");
            await _dbContext.DisposeAsync();
            return StatusCode(201, "Asientos Guardados en base de datos");
        }
    }
}