using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class UsuarioCN
    {
        public static List<Usuario> GetUsuarios()
        {
            UsuarioDALC obj = new UsuarioDALC();
            return obj.GetUsuarios();
        }
    }
}
