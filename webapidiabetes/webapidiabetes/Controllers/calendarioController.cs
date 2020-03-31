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
    [RoutePrefix("api/calendario")]
    public class calendarioController : ApiController
    {
        private dbDiabetes db = new dbDiabetes();
        [Route("obcalendar")]
        public IQueryable<CALENDARIO_7PASOS> GetCALENDARIO_7PASOS()
        {
            return db.CALENDARIO_7PASOS;
        }

        // GET: api/calendario/5
        [Route("{id:int}/obcalendar")]
        [HttpGet]
        public IEnumerable<CALENDARIO_7PASOS> Getcal(int id)
        {
            using (dbDiabetes cal = new dbDiabetes())
            {
                var lst = cal.CALENDARIO_7PASOS.Where(e => e.ID_CALENDARIO_7PASOS == id).ToList();
                return lst;
            }
        }
        

        [Route("{id:int}/obtipoact")]
        [HttpGet]
        public IEnumerable<TIPO_ACTIVIDAD> Getact(int id)
        {
            using (dbDiabetes act = new dbDiabetes())
            {
                var lst = act.TIPO_ACTIVIDAD.Where(e => e.ID_TIPO_ACTIVIDAD == id).ToList();
                return lst;
            }
        }


    }
}
