﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class CalculoIrpfCompleto : CalculoIrpf
    {
     
    public double calculaImposto(Contribuinte c)
    {
        double baseDeCalculo = c.getTotRend() - c.getContrPrev();
        double txDescDep = 0.0;
        if (c.Idade < 65)
        {
            if ((c.NroDep > 0) && (c.NroDep <= 2))
            {
                txDescDep = 0.02;
            }
            else if ((c.NroDep > 2) && (c.NroDep <= 5))
            {
                txDescDep = 0.035;
            }
            else if (c.NroDep > 5)
            {
                txDescDep = 0.05;
            }
        }
        else
        {
            if ((c.NroDep > 0) && (c.NroDep <= 2))
            {
                txDescDep = 0.03;
            }
            else if ((c.NroDep > 2) && (c.NroDep <= 5))
            {
                txDescDep = 0.045;
            }
            else if (c.NroDep > 5)
            {
                txDescDep = 0.06;
            }
        }
        double descDep = baseDeCalculo * txDescDep;
        baseDeCalculo = baseDeCalculo - descDep;
        double impPagar;
        if (baseDeCalculo <= 12000.0)
        {
            impPagar = 0;
        }
        else if ((baseDeCalculo >= 12000.0) && (baseDeCalculo < 24000.0))
        {
            impPagar = (baseDeCalculo - 12000.0) * 0.15;
        }
        else
        {
            double p1 = (23999.0 - 12000.0) * 0.15;
            double p2 = (baseDeCalculo - 23999.0) * 0.275;
            impPagar = p1 + p2;
        }
        return (impPagar);
    }

    private double calculoSimplificado(Contribuinte c)
    {
        double baseDeCalculo = c.getTotRend() - c.getContrPrev();
        double descPadrao = baseDeCalculo * 0.5;
        baseDeCalculo = baseDeCalculo - descPadrao;
        double impPagar;
        if (baseDeCalculo <= 12000.0)
        {
            impPagar = 0;
        }
        else if ((baseDeCalculo >= 12000.0) && (baseDeCalculo < 24000.0))
        {
            impPagar = (baseDeCalculo - 12000.0) * 0.15;
        }
        else
        {
            double p1 = (23999.0 - 12000.0) * 0.15;
            double p2 = (baseDeCalculo - 23999.0) * 0.275;
            impPagar = p1 + p2;
        }
        return (impPagar);
    }
}
}
