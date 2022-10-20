using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pregunta1.Model;

namespace Pregunta1.Clases
{
    public class Empleado
    {
        //  CONECTION TO DB
        Caso01Entities db = new Caso01Entities();

        public void GuardarEmpleado(int codigo, string nombre, decimal horas, decimal salarioHora)
        {
            empleado obj = new empleado();
            obj.codigo_empleado = codigo;
            obj.Nombre = nombre;
            obj.Horas_laboradas = horas;
            obj.Salario_Hora = salarioHora;
            obj.Salario_Bruto = salarioHora * horas;

            db.empleado.Add(obj);
            db.SaveChanges();
        }
    }
}