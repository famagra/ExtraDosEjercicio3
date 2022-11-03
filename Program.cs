using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDos_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroEmpleado = 100;
            facuList lista = new facuList(3);

            bool salir = false;

            while (!salir)
            {

                try
                {
                    Console.WriteLine("------MENU PRINCIPAL------");
                    Console.WriteLine("  1. AGREGAR");
                    Console.WriteLine("  2. ELIMINAR");
                    Console.WriteLine("  3. BUSCAR");
                    Console.WriteLine("  4. LISTAR");
                    Console.WriteLine("  5. SALIR");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    switch (opcion)
                    {

                        case 1:
                            Console.WriteLine("  ------SUBMENU EMPLEADO------\n");
                            Console.WriteLine("\t1. AGREGAR EMPLEADO");
                            Console.WriteLine("\t2. AGREGAR SUPERVISOR");
                            Console.WriteLine("\t3. AGREGAR ENCARGADO");
                            Console.WriteLine("\t4. VOLVER AL MENU PRINCIPAL");

                            int opcionB = Convert.ToInt32(Console.ReadLine());

                            switch (opcionB)
                            {
                                case 1:
                                    nroEmpleado++;
                                    Console.WriteLine("AGREGANDO UN EMPLEADO\n");
                                    Console.WriteLine("INGRESE EL NOMBRE:");
                                    string nombre = Console.ReadLine();
                                    Console.WriteLine("INGRESE LA FECHA DE NACIMIENTO:");
                                    string fecha = Console.ReadLine();
                                    Empleado e1 = new Empleado(nroEmpleado, nombre, fecha);
                                    lista.push(e1);
                                    Console.Clear();
                                    break;
                                case 2:
                                    nroEmpleado++;
                                    Console.WriteLine("AGREGANDO UN EMPLEADO\n");
                                    Console.WriteLine("INGRESE EL NOMBRE:");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("INGRESE LA FECHA DE NACIMIENTO:");
                                    fecha = Console.ReadLine();
                                    Console.WriteLine("INGRESE CANTIDAD EMPLEADOS A CARGO:");
                                    int cantEmpleadosACargo = int.Parse(Console.ReadLine());
                                    Empleado s1 = new Supervisor(cantEmpleadosACargo, nroEmpleado, nombre, fecha);
                                    lista.push(s1);
                                    Console.Clear();
                                    break;
                                case 3:
                                    nroEmpleado++;
                                    Console.WriteLine("AGREGANDO UN EMPLEADO\n");
                                    Console.WriteLine("INGRESE EL NOMBRE:");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("INGRESE LA FECHA DE NACIMIENTO:");
                                    fecha = Console.ReadLine();
                                    Console.WriteLine("INGRESE CANTIDAD DE SUCURSALES A CARGO:");
                                    int cantSucursalesACargo = int.Parse(Console.ReadLine());
                                    Empleado encargado1 = new Encargado(cantSucursalesACargo,nroEmpleado, nombre, fecha);
                                    lista.push(encargado1);
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Ingrese un valor entre 1 y 4");
                                    Console.Clear();
                                    break;

                            }
                            
                            break;

                        case 2:
                            Console.WriteLine("ELIMINE UN EMPLEADO\n");
                            Console.WriteLine("Ingese el codigo: ");
                            int insert = int.Parse(Console.ReadLine());
                            string resultadoEliminar = lista.eliminar(insert);
                            Console.WriteLine(resultadoEliminar);
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 3:
                            Console.WriteLine("BUSCAR EN EMPLEADO POR NOMBRE\n");
                            Console.WriteLine("INGRESE EL NOMBRE: ");
                            string nombreBuscado = Console.ReadLine();
                            string resultado = lista.buscar1(nombreBuscado);
                            Console.WriteLine(resultado);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("LISTAR EMPLEADOS\n");
                            lista.MostrarLista();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("Saliendo...");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadLine();

        }
    }
}
