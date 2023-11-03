using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Interfaz.menuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Interfaz.menuPrincipal();
                        break;
                    case 1:
                        opcion = Interfaz.sumar();
                        break;
                    case 2:
                        opcion = Interfaz.restar();
                        break;
                    case 3:
                        opcion = Interfaz.multiplicar();
                        break;
                    case 4:
                        opcion = Interfaz.dividir();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
