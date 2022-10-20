using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pregunta1.Model;

namespace Pregunta1.Clases
{
    public class Deducciones
    {
        //  CONECTION TO DB
        Caso01Entities db = new Caso01Entities();

        public void GuardarDeduccion(int codigo, int codigoEmpleado, decimal cooperativa, decimal prestamo, decimal ahorro)
        {
            deducciones obj = new deducciones();

            obj.codigo_deduccion = codigo;
            obj.empleado = codigoEmpleado;
            obj.cooperativa = cooperativa;
            obj.prestamo = prestamo;
            obj.ahorro = ahorro;

            db.deducciones.Add(obj);
            db.SaveChanges();
        }
    }
}