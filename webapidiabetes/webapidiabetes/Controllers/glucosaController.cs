using conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace webapidiabetes.Controllers
{
    [RoutePrefix("api/glucosa")]
    public class glucosaController : ApiController
    {
        dbDiabetes db = new dbDiabetes();


        [Route("{id:int}/obglucosa")]
        [HttpGet]
        public IEnumerable<MEDICION_GLUCOSA>GetGlucosa(int id)
        {
                var lst = db.MEDICION_GLUCOSA.Where(e => e.ID_PERSONA == id).ToList();
                return lst;   
        }

        [Route("saveglucosa")]
        [ResponseType(typeof(MEDICION_GLUCOSA))]
        public IHttpActionResult AgregarMedicion(MEDICION_GLUCOSA med)
        {
            if(ModelState.IsValid)
            {
                db.MEDICION_GLUCOSA.Add(med);
                db.SaveChanges();
                return Ok(med);
            }
            else
            {
                return BadRequest();
            }

        }
      

    }
}
