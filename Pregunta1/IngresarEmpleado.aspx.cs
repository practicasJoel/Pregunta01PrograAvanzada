using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pregunta1.Clases;

namespace Pregunta1
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        Empleado ce = new Empleado();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            decimal horas = Convert.ToDecimal(txtHorasL.Text);
            decimal salarioH = Convert.ToDecimal(txtSalarioXhora.Text);
            ce.GuardarEmpleado(codigo, nombre, horas, salarioH);
        }

    }
}