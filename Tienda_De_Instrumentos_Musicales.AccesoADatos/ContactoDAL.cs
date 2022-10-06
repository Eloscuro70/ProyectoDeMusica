using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio;

namespace Tienda_De_Instrumentos_Musicales.AccesoADatos
{
    public class ContactoDAL
    {
        private static object Contacto;

        public static async Task<int> CrearAsync(Contacto pContacto)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pContacto);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> ModificarAsync(Contacto pContacto)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var contacto = await bdContexto.Contacto.FirstOrDefaultAsync(s => s.Id == pContacto.Id);
                contacto.Nombre = pContacto.Nombre;
                bdContexto.Update(contacto);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> EliminarAsync(Contacto pContacto)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var contacto = await bdContexto.Contacto.FirstOrDefaultAsync(s => s.Id == pContacto.Id);
                bdContexto.Contacto.Remove(contacto);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<Contacto> ObtenerPorIdAsync(Contacto pContacto)
        {
            var contacto = new Contacto();
            using (var bdContexto = new BDContexto())
            {
                contacto = await bdContexto.Contacto.FirstOrDefaultAsync(s => s.Id == pContacto.Id);
            }
            return contacto;
        }

        public static async Task<List<Contacto>> ObtenerTodosAsync()
        {
            var contactos = new List<Contacto>();
            using (var bdContexto = new BDContexto())
            {
                contactos = await bdContexto.Contacto.ToListAsync();
            }
            return contactos;
        }

        internal static IQueryable<Contacto> QuerySelect(IQueryable<Contacto> pQuery, Contacto pContacto)
        {
            if (pContacto.Id > 0)
                pQuery = pQuery.Where(s => s.Id == pContacto.Id);

            if (!string.IsNullOrWhiteSpace(pContacto.Nombre))
                pQuery = pQuery.Where(s => s.Nombre.Contains(pContacto.Nombre));

            pQuery = pQuery.OrderByDescending(s => s.Id).AsQueryable();
            return pQuery;
        }

        public static async Task<List<Contacto>> BuscarAsync(Contacto pContacto)
        {
            var contactos = new List<Contacto>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Contacto.AsQueryable();
                select = QuerySelect(select, pContacto);
                contactos = await select.ToListAsync();
            }
            return contactos;
        }
    }
}
