using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = " El Nombre es Requerido")]
        [MaxLength(30, ErrorMessage = " El largo máximo es de 30 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = " La zona es Requerida")]
        public int Clasificacion { get; set; }

        [Required(ErrorMessage = " La imagen es Requerida")]
        [MaxLength(200, ErrorMessage = " El largo máximo es de 200 caracteres")]
        public int imagen {get; set;}

        [NotMapped]
        public string Descripcion { get; set; }
        public int Top_aux { get; set; }
        public List<Categoria> categoria { get; set; }
    }

    public enum Categoria_Musicales
    {
        PRIMERO = 1,
        SEGUNDO = 2,
        TERCERO = 3  
    }
}
