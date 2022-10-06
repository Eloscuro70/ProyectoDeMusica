using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tienda_De_Instrumentos_Musicales.AccesoADatos;
using Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio;
namespace Tienda_De_Instrumentos_Musicales.LogicaDeNegocio
{
    public class ContactoBL
    {
        public async Task<int> CrearAsync(Contacto pContacto)
        {
            return await ContactoDAL.CrearAsync(pContacto);
        }
        public async Task<int> ModificarAsync(Contacto pContacto)
        {
            return await ContactoDAL.ModificarAsync(pContacto);
        }
        public async Task<int> EliminarAsync(Contacto pContacto)
        {
            return await ContactoDAL.EliminarAsync(pContacto);
        }
        public async Task<Contacto> ObtenerPorIdAsync(Contacto pContacto)
        {
            return await ContactoDAL.ObtenerPorIdAsync(pContacto);
        }
        public async Task<List<Contacto>> ObtenerTodosAsync()
        {
            return await ContactoDAL.ObtenerTodosAsync();
        }
        public async Task<List<Contacto>> BuscarAsync(Contacto pContacto)
        {
            return await ContactoDAL.BuscarAsync(pContacto);
        }
    }
}
