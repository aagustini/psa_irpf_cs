using IrpfApp.PL;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class IrpfFachada
    {

        private ContribuinteDAO cadContribuinte;

        public IrpfFachada()
        {
            cadContribuinte = new ContribuinteDAOMemory();

        }


        public void salva(String nome, String cpf, int idade, int nroDep, double contrPrev, double totRend) //throws IrpfException
        {

            Contribuinte contr = new Contribuinte(nome, cpf, idade, nroDep, contrPrev, totRend);
            try
            {
                cadContribuinte.inserir(contr);
            }
            catch (DAOException e)
            {
                throw new IrpfException(e);
            }
        }

        public List<Contribuinte> getContribuintes()
        {
            try
            {
                return cadContribuinte.buscarTodos();
            }
            catch (Exception e)
            {
                throw new IrpfException(e);
            }
        }

        public List<Contribuinte> getContribuintesIdosos()
        {
            try
            {
                return cadContribuinte.buscarIdosos();
            }
            catch (Exception e)
            {
                throw new IrpfException(e);
            }
        }

        public double calcula(TipoCalculo t, String cpf) 
        {
            Contribuinte contribuinte;
            try
            {
                contribuinte = cadContribuinte.buscar(cpf);
            }
            catch (DAOException ex)
            {
                throw new IrpfException("Erro: " + ex.Message);
            }
            if (contribuinte == null)
            {
                throw new IrpfException("CPF inexistente: " + cpf);
            }
            CalculoIrpf ir = CalculoIrpfFactory.createInstance(t);
            contribuinte.defineCalculo(ir);
            return contribuinte.getImpostoDevido();
        }
    }

}
