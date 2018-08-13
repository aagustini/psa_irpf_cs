using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class CalculoIrpfFactory
    {
        public static CalculoIrpf createInstance(TipoCalculo t)
        {
            switch (t)
            {
                case TipoCalculo.SIMPLIFICADO:
                    return new CalculoIrpfSimplificado();
                case TipoCalculo.COMPLETO:
                    return new CalculoIrpfCompleto();
            }
            return null;
        }
    }
}
