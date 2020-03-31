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
    [RoutePrefix("api/usuario")]
    public class usuarioController : ApiController
    {
        private dbDiabetes db = new dbDiabetes();
        [Route("allusuarios")]
        // GET: api/usuario
        public IQueryable<USUARIO> GetUSUARIO()
        {
            return db.USUARIO;
        }
        [Route("{id:int}/obusu")]
        [HttpGet]
        public IEnumerable<USUARIO> GetUs(int id)
        {
            using (dbDiabetes usu = new dbDiabetes())
            {
                var lst = usu.USUARIO.Where(e => e.ID_USUARIO == id).ToList();
                return lst;
            }
        }
        [Route("login")]
        [ResponseType(typeof(USUARIO))]
        public IHttpActionResult LogIn(USUARIO usu)
        {

            try
            {
                USUARIO user = db.USUARIO.First(e => e.TELEFONO == usu.TELEFONO && e.CONTRASENA == usu.CONTRASENA);

                return Ok(user);
            }
            catch
            {
                return NotFound();
            }
        }


        [Route("{id:int}/obperson")]
        [HttpGet]
        public IEnumerable <PERSONAS> Getperson(int id)
        {
                using (dbDiabetes person = new dbDiabetes())
                {
                    var lst = person.PERSONAS.Where(e => e.ID_PERSONA == id).ToList();
                    return lst;
                }    
        }

    }
}
