using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDos_Ejercicio3
{
    class Encargado:Empleado
    {
        protected int NroSucursalACargo { get; set; }

        public Encargado(int nroSucursalACargo, int nroEmpleado, string nombre, string fechaNacimiento) : base(nroEmpleado, nombre, fechaNacimiento)
        {
            this.NroSucursalACargo = nroSucursalACargo;
        }

        public override string Mostrar()
        {
            return $"ENCARGADO  {NroEmpleado} | NOMBRE {Nombre} | CANTIDAD SUCURSALES {NroSucursalACargo}\n";
        }
    }
}
