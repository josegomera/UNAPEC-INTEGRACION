using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3thPartySoftware.DAL.SQL;
using _3thPartySoftware.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace _3thPartyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsientosController : ControllerBase
    {

        [HttpPost]
        [Route("Seed")]
        public IActionResult SeedData()
        {
            var _dbContext = new ExternalSoftware();
            DataSeeder.SeedAsientos(_dbContext);
            return Ok();
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            var _dbContext = new ExternalSoftware();
            var asientos = await _dbContext.Asientos.ToListAsync();
            return Ok(asientos);
        }

        [HttpPost]
        [Route("SendAsientos")]
        public async Task<IActionResult> SendAsientosAsync()
        {
            try
            {
                var _dbContext = new ExternalSoftware();
                var asientos = await _dbContext.Asientos.ToListAsync();

                OnPost(asientos);
                return Ok();
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }


        public dynamic OnPost(IEnumerable<Asiento> data)
        {
            var client = new RestClient("https://localhost:5001/api/AsientosExternos");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Length", "1470");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "localhost:5001");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(data);
            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}