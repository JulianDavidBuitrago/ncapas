using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Negocio;

namespace WebEjemplo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                GetDatos();
        }

        private void GetDatos()
        {
            List<Usuario> colec = UsuarioCN.GetUsuarios();
            foreach (var item in colec)
            {
                lblDatos.Text += "Nombres : " + item.nombres + "<br/>Apellidos : " + item.apellidos +
                    "<br/>DNI : " + item.dni + "<hr/>";
            }
        }
    }
}