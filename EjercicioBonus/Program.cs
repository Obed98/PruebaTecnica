using System;

namespace EjercicioBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroMayor = NumeroMayor();
            Console.WriteLine($"El numero mayor de los numeros ingresados es {numeroMayor}");
        }
        public static int NumeroMayor()
        {
            int numero = 0;
            int[] arreglo = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un Numero");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
                numero = arreglo[i] > numero ? arreglo[i] : numero;
                Console.Clear();
            }
            return numero;
        }
    }
}
