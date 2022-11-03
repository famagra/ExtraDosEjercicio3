using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDos_Ejercicio3
{
    class facuList
    {
        private Empleado[] arreglo;
        private int contador;
        private int tamañoArreglo;

        public facuList(int tamaño)
        {
            arreglo = new Empleado[tamaño];
            tamañoArreglo = tamaño;
            contador = 0;
        } //constructor

        public void push(Empleado insertar)
        {

            if (contador <= tamañoArreglo - 1)
            {
                //inserto el valor
                arreglo[contador] = insertar;
                contador++;
            }
            else
            {
                //se duplica el array al tamaño doble
                int n2 = tamañoArreglo * 2;
                Empleado[] arregloNuevo = new Empleado[n2];

                for (int i = 0; i < tamañoArreglo; i++)
                {
                    arregloNuevo[i] = arreglo[i];//pasan los valor del vector viejo al nuevo

                }
                tamañoArreglo = n2;                     //cambio de asignación de variables
                arreglo = arregloNuevo;     //cambio de asignación de variables
                push(insertar);             //vuelvo a llamar a la misma función.

            }
        } //INSERTAR

        public void MostrarLista()
        {
            foreach (Empleado e in arreglo)
            {
                if(e!= null)
                Console.Write(e.Mostrar());

            }
        } //MOSTRAR

        public string buscar1(string nombreBuscado)
        {
            
            for (int i = 0; i < contador; i++)
            {
                if (arreglo[i].Nombre == nombreBuscado)
                {
                    return $"EXISTE UN EMPLEADO CON EL NOMBRE {nombreBuscado}";
                }
            }

            return "NO EXISTE EMPLEADO CON ESE NOMBRE";

        } //BUSCAR

        public string eliminar(int numeroBuscado)
        {
            return "no implmentad";
            

        }
    
    }
}
