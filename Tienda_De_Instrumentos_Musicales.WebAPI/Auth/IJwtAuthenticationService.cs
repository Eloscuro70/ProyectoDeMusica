using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio;

namespace Tienda_De_Instrumentos_Musicales.WebAPI.Auth
{
    public interface IJwtAuthenticationService
    {
        String Authenticate(Usuario pUsuario);
    }
}

