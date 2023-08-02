using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Instrumentation;
using System.Web.UI;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //Para acceder a SWAGGER: http://localhost:64447/swagger/ui/index
    public class ValuesController : ApiController
    {
        private List<Empleado> _empleados = new List<Empleado>()
        { 
            new Empleado(1, "Homero", "Simpson"),
            new Empleado(2, "Charles M.", "Burns"),
            new Empleado(3, "Seymour", "Skinner")
        };

        // GET api/values
        [ResponseType(typeof(List<Empleado>))]
        public IHttpActionResult Get()
        {
            return Ok(_empleados);
        }

        // GET api/values/5
        [ResponseType(typeof(Empleado))]
        public IHttpActionResult Get(int id)
        {
            var empleado = _empleados.Find(x => x.Id == id);
            if (empleado == null)
                return NotFound();
            else
                return Ok(empleado);
        }

        // POST api/values
        [ResponseType(typeof(Empleado))]
        public IHttpActionResult Post([FromBody] Empleado empleado)
        {
            _empleados.Add(empleado);
            return CreatedAtRoute("", new { id = empleado.Id}, empleado );
        }

    }
}
