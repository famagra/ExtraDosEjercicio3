using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDos_Ejercicio3
{
    class Empleado
    {
        public int NroEmpleado { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }

        facuList lista = new facuList(5);

        public Empleado(int nroEmpleado, string nombre, string fechaNacimiento)
        {
            this.NroEmpleado = nroEmpleado;
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;
        }

        //metodos

        public virtual string Mostrar()
        {
            return $"EMPLEADO   {NroEmpleado} | NOMBRES {Nombre} | FECHA DE NACIMIENTO: {FechaNacimiento}\n";
        }

    }
}
