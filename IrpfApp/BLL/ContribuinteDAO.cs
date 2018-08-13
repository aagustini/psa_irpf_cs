using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL

{
    public interface ContribuinteDAO
    {
        void inserir(Contribuinte c);
        void alterar(Contribuinte c);
        Contribuinte buscar(String cpf);
        List<Contribuinte> buscarIdosos();
        List<Contribuinte> buscarTodos();
    }

}
