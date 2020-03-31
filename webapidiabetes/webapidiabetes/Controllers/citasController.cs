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
    [RoutePrefix("api/citas")]
    public class citasController : ApiController
    {
        private dbDiabetes db = new dbDiabetes();

        [Route("allcitas")]
        public IQueryable<CITAS> GetCITAS()
        {
            return db.CITAS;
        }

        [Route("{id:int}/obcitas")]
        // GET: api/citas/5
        [HttpGet]
        public IEnumerable<CITAS> Getcitas(int id)
        {
            using (dbDiabetes cita = new dbDiabetes())
            {
                var lst = cita.CITAS.Where(e => e.ID_PERSONA == id).ToList();
                return lst;
            }
        }
        

        // PUT: api/citas/5
        [Route("{id:int}/obesp")]
        [HttpGet]
        public IEnumerable<ESPECIALISTA> Getesp(int id)
        {
            using (dbDiabetes esp = new dbDiabetes())
            {
                var lst = esp.ESPECIALISTA.Where(e => e.ID_ESPECIALISTA == id).ToList();
                return lst;
            }
        }
        
        [Route("{id:int}/obtipo")]
        [HttpGet]
        public IEnumerable<TIPO_ESPECIALISTA> Gettipesp(int id)
        {
            using (dbDiabetes tipes = new dbDiabetes())
            {
                var lst = tipes.TIPO_ESPECIALISTA.Where(e => e.ID_TIPOESP == id).ToList();
                return lst;
            }
        }
        
        [Route("{id:int}/datoscita")]
        [HttpGet]
        public IEnumerable<DATOS_CITA>getdatcita(int id)
        {
            using (dbDiabetes tipda = new dbDiabetes())
            {
                var lst = tipda.DATOS_CITA.Where(e => e.ID_DATOSCITA == id).ToList();
                return lst;
            }
        }
        [Route("{id:int}/tipocita")]
        [HttpGet]
        public IEnumerable<TIPO_CITAS>gettipcita(int id)
        {
            using (dbDiabetes tpcita = new dbDiabetes())
            {
                var lst = tpcita.TIPO_CITAS.Where(e => e.ID_TIPO_CITAS == id).ToList();
                return lst;
            }
        }

    }
}
