using conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapidiabetes.Controllers
{
    [RoutePrefix("api/web")]
    public class paginawebController : ApiController
    {
        dbDiabetes db = new dbDiabetes();

        [Route("{id:int}/contar")]
        [HttpGet]
        public int getweb(int ed)
        {
            var lst = db.PERSONAS.Select(e => e.EDAD == ed).Count();
            return lst;
        }




    }
}
