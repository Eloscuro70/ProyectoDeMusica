using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tienda_De_Instrumentos_Musicales.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio;

namespace Tienda_De_Instrumentos_Musicales.AccesoADatos.Tests
{
    [TestClass()]
    public class ContactoDALTests
    {
        private static Contacto contactoInicial = new Contacto { Id = 2 };

        [TestMethod()]
        public async Task T1CrearAsyncTest()
        {
            var contacto = new Contacto();
            contacto.Nombre = "Administrador";
            contacto.Correo = 200;
            contacto.Telefono = 50;
            int result = await ContactoDAL.CrearAsync(contacto);
            Assert.AreNotEqual(0, result);
            contactoInicial.Id = contacto.Id;
        }

        [TestMethod()]
        public async Task T2ModificarAsyncTest()
        {
            var contacto = new Contacto();
            contacto.Id = contactoInicial.Id;
            contacto.Nombre = "Admin";
            contacto.Correo = 200;
            contacto.Telefono = 50;
            int result = await ContactoDAL.ModificarAsync(contacto);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod()]
        public async Task T3ObtenerPorIdAsyncTest()
        {
            var contacto = new Contacto();
            contacto.Id = contactoInicial.Id;
            var resultContacto = await ContactoDAL.ObtenerPorIdAsync(contacto);
            Assert.AreEqual(contacto.Id, resultContacto.Id);
        }

        [TestMethod()]
        public async Task T4ObtenerTodosAsyncTest()
        {
            var resultContactos = await ContactoDAL.ObtenerTodosAsync();
            Assert.AreNotEqual(0, resultContactos.Count);
        }

        [TestMethod()]
        public async Task T5BuscarAsyncTest()
        {
            var contacto = new Contacto();
            contacto.Nombre = "a";
            contacto.Correo = 200;
            contacto.Telefono = 50;
            var resultContactos = await ContactoDAL.BuscarAsync(contacto);
            Assert.AreNotEqual(0, resultContactos.Count);
        }
        [TestMethod()]
        public async Task T6EliminarAsyncTest()
        {
            var contacto = new Contacto();
            contacto.Id = contactoInicial.Id;
            int result = await ContactoDAL.EliminarAsync(contacto);
            Assert.AreNotEqual(0, result);
        }
    }
}