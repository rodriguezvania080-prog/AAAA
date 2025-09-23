using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,desa=0;
            float nota;
            Console.WriteLine("Ingrese el numero de notas");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante:" +(i+1) );
                 nota = float.Parse(Console.ReadLine());
                if (nota< 12) {
                    desa++;
                }
                else{
                    
                }

            }
            Console.WriteLine("Hay " + desa + " estudiantes desaprobados");

        }
    }
}
