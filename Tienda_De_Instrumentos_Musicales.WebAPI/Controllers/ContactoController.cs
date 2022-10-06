using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio;
using Tienda_De_Instrumentos_Musicales.LogicaDeNegocio;

namespace Tienda_De_Instrumentos_Musicales.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactoController : ControllerBase
    {
        private ContactoBL contactoBL = new ContactoBL();

        [HttpGet]
        public async Task<IEnumerable<Contacto>> Get()
        {
            return await contactoBL.ObtenerTodosAsync();
        }

        [HttpGet("{id}")]
        public async Task<Contacto> Get(int id)
        {
            Contacto contacto = new Contacto();
            contacto.Id = id;
            return await contactoBL.ObtenerPorIdAsync(contacto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Contacto contacto)
        {
            try
            {
                await contactoBL.CrearAsync(contacto);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Contacto contacto)
        {
            if (contacto.Id == id)
            {
                await contactoBL.ModificarAsync(contacto);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                Contacto contacto = new Contacto();
                contacto.Id = id;
                await contactoBL.EliminarAsync(contacto);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("{Buscar}")]
        public async Task<List<Contacto>> Buscar([FromBody] object pContacto)
        {

            var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string strContacto = JsonSerializer.Serialize(pContacto);
            Contacto contacto = JsonSerializer.Deserialize<Contacto>(strContacto, option);
            return await contactoBL.BuscarAsync(contacto);
        }
    }
}
