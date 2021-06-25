using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class LocacaoVeiculoLeve
    {
        public int Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao locacao { set; get; }
        public int IdVeiculoLeve { set; get; }
        public VeiculoLeve veiculoLeve { set; get; }

        public LocacaoVeiculoLeve()
        {

        }
        public LocacaoVeiculoLeve(
            Locacao locacao,
            VeiculoLeve veiculoLeve
        )
        {
            this.Id = Context.locacoesVeiculosLeves.Count;
            this.IdLocacao = locacao.Id;
            this.locacao = locacao;
            this.IdVeiculoLeve = veiculoLeve.Id;
            this.veiculoLeve = veiculoLeve;

            Context.locacoesVeiculosLeves.Add(this);
        }

        public static IEnumerable<Model.LocacaoVeiculoLeve> GetVeiculos(int IdLocacao)
        {
            Context Context = new Context();
            return from Veiculo in Context.locacoesVeiculosLeves where Veiculo.IdLocacao == IdLocacao select Veiculo;
        }

        public static double GetTotal(int IdLocacao)
        {
            Context Context = new Context();
            return (
                from Veiculo in Context.locacoesVeiculosLeves
                where Veiculo.IdLocacao == IdLocacao
                select Veiculo.veiculoLeve.Preco
            ).Sum();
        }

        public static int GetCount(int IdLocacao)
        {
            return GetVeiculos(IdLocacao).Count();
        }
    }
}