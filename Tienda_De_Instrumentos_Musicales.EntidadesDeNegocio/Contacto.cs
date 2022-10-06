using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }

        [Required(ErrorMessage = " La Descripcion es Requerida")]
        [MaxLength(200, ErrorMessage = " El largo máximo es de 200 caracteres")]
        public int Correo { get; set; }
        public int Telefono { get; set; }
        public List<Categoria> Categoria { get; set; }
    }
}
