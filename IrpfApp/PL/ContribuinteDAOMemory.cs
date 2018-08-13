using IrpfApp.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.PL
{
    class ContribuinteDAOMemory : ContribuinteDAO
    {
        private static Dictionary<String, Contribuinte> dados;


        public void alterar(Contribuinte c)
        {
            throw new DAOException("update nao implementado");
        }

        public Contribuinte buscar(string cpf)
        {
            if (dados.ContainsKey(cpf))
                return dados[cpf];
            else
                throw new DAOException("CPF invalido");
        }

        public List<Contribuinte> buscarIdosos()
        {
            throw new DAOException("busca de idosos nao implementada");
        }

        public List<Contribuinte> buscarTodos()
        {
            List<Contribuinte> res = new List<Contribuinte>();
            foreach (Contribuinte c in dados.Values)
                res.Add(c);

            return res;
        }

        public void inserir(Contribuinte c)
        {
            dados[c.getCpf()] = c;
        }

        static ContribuinteDAOMemory()
        {
            dados = new Dictionary<string, Contribuinte>();

            dados["1"] = new Contribuinte("Huginho", "1", 55, 3, 1000, 23000);
            dados["2"] = new Contribuinte("Zezinho", "2", 47, 2, 2000, 42000);
            dados["3"] = new Contribuinte("Luizinhio", "3", 50, 0, 3000, 19000);
            dados["4"] = new Contribuinte("Donald", "4", 67, 3, 7000, 30000);
        }
    }
}
