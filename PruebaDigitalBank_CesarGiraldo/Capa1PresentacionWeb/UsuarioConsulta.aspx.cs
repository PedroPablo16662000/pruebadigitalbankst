using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa1PresentacionWeb
{
    public partial class UsuarioConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CapaWCF.Service service = new CapaWCF.Service();

            usuariosGrid.DataSource = service.Consultar();
            usuariosGrid.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}