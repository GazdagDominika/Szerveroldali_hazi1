using Microsoft.AspNetCore.Mvc;
using Szerveroldali_hazi1.Data;
using Szerveroldali_hazi1.Entities;

namespace Szerveroldali_hazi1.Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Duna_Vizallas_Controller
    {
        Duna_VizallasContext ctx;

        public Duna_Vizallas_Controller(Duna_VizallasContext ctx)
        {
            this.ctx = ctx;
        }


        [HttpGet]
        public IEnumerable<Duna_Vizallas> Get() 
        { 
            return ctx.Vizallas;
        }

        [HttpPost]
        public void Post(Duna_Vizallas duna)
        {
            ctx.Vizallas.Add(duna);
            ctx.SaveChanges();
        }
    }
}
