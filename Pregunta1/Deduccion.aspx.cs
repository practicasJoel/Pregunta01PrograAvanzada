using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pregunta1.Clases;

namespace Pregunta1
{
    public partial class Deduccion : System.Web.UI.Page
    {
        Deducciones ce = new Deducciones();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            int idEmpleado = Convert.ToInt32(txtEmpleado.Text);
            decimal cooperativa = Convert.ToDecimal(txtCooperativa.Text);
            decimal prestamo = Convert.ToDecimal(txtPrestamo.Text);
            decimal ahorro = Convert.ToDecimal(txtAhorro.Text);

            ce.GuardarDeduccion(codigo, idEmpleado, cooperativa, prestamo, ahorro);
        }
    }
}