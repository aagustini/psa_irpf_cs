using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class Contribuinte
    {
        private String nome;
        private String cpf;
        private int idade;
        //private int nroDep;
        private double contrPrev;
        private double totRend;
        private CalculoIrpf impostoDevido;

        public Contribuinte(String nome, String cpf, int idade,
                            int nroDep, double contrPrev, double totRend)
  //                      throws IllegalArgumentException
        {
        
        
        this.contrPrev = contrPrev;
        this.cpf = cpf;
        this.idade = idade;
        this.nome = nome;
        this.NroDep = nroDep;
        this.totRend = totRend;
        this.impostoDevido = new CalculoIrpfSimplificado(); // Assume como default
    }

    public void defineCalculo(CalculoIrpf calc)
    {
        impostoDevido = calc;
    }


    public override String ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(nome);
        sb.Append(",");
        sb.Append(cpf);
        sb.Append(",");
        sb.Append(idade);
        sb.Append(",");
        sb.Append(NroDep);
        sb.Append(",");
        sb.Append(contrPrev);
        sb.Append(",");
        sb.Append(totRend);
        return (sb.ToString());
    }

    public double getContrPrev()
    {
        return contrPrev;
    }

    public String getCpf()
    {
        return cpf;
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value;  }
    }

    //public void setIdade(int novaIdade)
    //    {
    //        idade = novaIdade;
    //    }

        public String getNome()
    {
        return nome;
    }

    public int NroDep { get; set; }
        
    public double getTotRend()
    {
        return totRend;
    }

    public double getImpostoDevido()
    {
        return (impostoDevido.calculaImposto(this));
    }
}
}
