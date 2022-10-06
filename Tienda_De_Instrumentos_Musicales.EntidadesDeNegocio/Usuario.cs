using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Rol")]
        [Required(ErrorMessage = "Rol es Obligatorio")]
        [Display(Name = "Rol")]
        public int IdRol { get; set; }

        [Required(ErrorMessage = "Nombre es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "Login es Obligatorio")]
        [StringLength(25, ErrorMessage = "Maximo 25 caracteres")]
        public String Login { get; set; }

        [Required(ErrorMessage = "Password es Obligatorio")]
        [DataType(DataType.Password)]
        [StringLength(32, ErrorMessage = "Password debe estar entre 5 y 32 caracteres", MinimumLength = 5)]
        public String Password { get; set; }

        [Required(ErrorMessage = "Estatus es Obligatorio")]
        public byte Estatus { get; set; }


        [Display(Name = "Fecha Registro")]
        public DateTime fechaRegistro { get; set; }
        public Rol Rol { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirmar el Password")]
        [StringLength(32, ErrorMessage = "Password debe estar entre 5 y 32 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password y confirmar password debe de ser iguales")]
        [Display(Name = "Confirmar Password")]
        public String Confirmpassword_aux { get; set; }

        public static implicit operator Usuario(List<Usuario> v)
        {
            throw new NotImplementedException();
        }
    }

    public enum Estatus_Usuario
    {
        ACTIVO = 1,
        INACTIVO = 2
    }
}
