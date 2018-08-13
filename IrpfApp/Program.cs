using IrpfApp.BLL;
using System;

namespace IrpfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IrpfFachada fachada = new IrpfFachada();

            foreach (Contribuinte c in fachada.getContribuintes())
            {
                Console.WriteLine(c);
                Console.WriteLine("\timposto devido: " + fachada.calcula(TipoCalculo.SIMPLIFICADO, c.getCpf()));
            }

            Console.ReadKey();
        }

    }
}
