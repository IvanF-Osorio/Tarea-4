using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESCRIBA LOS VOTOS DEL PARTIDO 1");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCRIBA LOS VOTOS DEL PARTIDO 1");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCRIBA LOS VOTOS EN BLANCO");
            int Blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCRIBA LOS VOTOS ANULADOS");
            int Anulado = int.Parse(Console.ReadLine());
            int Poblacion = int.Parse(Console.ReadLine());
            double PorcenMayor = double.Parse(Console.ReadLine());
            int totalvotos = A + B + Blanco + Anulado;
            int PosiblesVotantes = (int)(Poblacion * (PorcenMayor / 100));
            double Astencion = PosiblesVotantes - totalvotos;
            if (A > B)
            {
                if (((totalvotos > Poblacion) || (A - B < totalvotos * 0.1)) && (totalvotos < Poblacion * 0.3))
                {
                    Console.WriteLine("las elecciones deben volverse a ejecutar");
                }
                else
                {
                    Console.WriteLine("El ganador es el partido 1");
                }
            }
            else
            {
                if (((totalvotos > Poblacion) || (B - A < totalvotos * 0.1)) && (totalvotos < Poblacion * 0.3))
                {
                    Console.WriteLine("las elecciones deben volverse a ejecutar");
                }
                else
                {
                    Console.WriteLine("El ganador es el partido 2");
                }
            }
        }
    }
}
