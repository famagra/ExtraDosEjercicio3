using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDos_Ejercicio3
{
    class Supervisor:Empleado
    {
        protected int NroGenteACargo { get; set; }

        public Supervisor(int nroGenteACargo, int nroEmpleado, string nombre, string fechaNacimiento) : base(nroEmpleado, nombre, fechaNacimiento)
        {
            this.NroGenteACargo = nroGenteACargo;
        }

        public override string Mostrar()
        {
            return $"SUPERVISOR {NroEmpleado} | NOMBRE {Nombre} | CANTIDAD DE EMPLEADOS {NroGenteACargo}\n";
        }

    }
}
