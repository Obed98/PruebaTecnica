using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstclientes = PedirNombre();
            
            foreach (var item in lstclientes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            
        }

        public static List<string> PedirNombre()
        {
            bool continuarCiclo = true;
            string nombreCliente = "";
            List<string> clientes = new List<string>();
            while (continuarCiclo)
            {
                Console.WriteLine("Ingrese Nombre del Cliente");
                nombreCliente = Console.ReadLine();
                nombreCliente = nombreCliente.ToUpper();
                clientes.Add(nombreCliente);
                Console.WriteLine("Si desea ingresar otro cliente ingrese la letra S, sino desea continuar ingrese la letra N");
                continuarCiclo = Console.ReadLine().ToUpper().Equals("S") ? continuarCiclo:!continuarCiclo;
                Console.Clear();
            }
            
            return clientes.Where(x => x.Contains("RE")).ToList();
        }
    }
}
