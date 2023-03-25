using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa1PresentacionWeb
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            CapaWCF.Service service = new CapaWCF.Service();
            CapaWCF.UsuarioModel model = new CapaWCF.UsuarioModel();
            model.nombreUsuario = name.Text;
            model.SexoUsuario = sex.SelectedValue.ToString();
            model.fechaNacimientoUsuario = DateTime.Parse(fnac.Value.ToString());
            bool salida1, salida2;
            service.Agregar(model, out salida1, out salida2);
        }
    }
}