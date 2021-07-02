using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class UsuarioDALC
    {
        public List<Usuario> GetUsuarios()
        {
            using (DB_pruebasDBEntities db = new DB_pruebasDBEntities())
            {
                return db.Usuario.ToList();
            }
        }
    }
}
