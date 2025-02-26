using Microsoft.AspNetCore.Mvc;
using Szerveroldali_hazi1.Data;
using Szerveroldali_hazi1.Entities.Dto;
using Szerveroldali_hazi1.Entities.Entity;

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
        public IEnumerable<Duna_Vizallas_View_Dto> Get() 
        {
            return ctx.Vizallas.Select(t => new Duna_Vizallas_View_Dto
            {
                Month = t.Date.ToString("yyyy.MM"),
                average_value = t.Value
            }) ; 
        }

        [HttpPost]
        public void Post(Duna_Vizallas_CreateUpdate_Dto dto)
        {

            var vizallas = new Duna_Vizallas
            {
                Date = dto.Date,
                Value = dto.Value
            };

            ctx.Vizallas.Add(vizallas);
            ctx.SaveChanges();
        }
    }
}
