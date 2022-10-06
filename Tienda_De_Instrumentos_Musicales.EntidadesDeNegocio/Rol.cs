using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public String Nombre { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }
        public List<Usuario> Usuario { get; set; }
    }
}
