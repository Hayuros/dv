using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class LocacaoVeiculoPesado
    {
        public int Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao locacao { set; get; }
        public int IdVeiculoPesado { set; get; }
        public VeiculoPesado veiculoPesado { set; get; }
        public LocacaoVeiculoPesado()
        {

        }
        public LocacaoVeiculoPesado(
            Locacao locacao,
            VeiculoPesado veiculoPesado
        )
        {
            this.Id = Id;
            this.IdLocacao = locacao.Id;
            this.locacao = locacao;
            this.IdVeiculoPesado = veiculoPesado.Id;
            this.veiculoPesado = veiculoPesado;

            Context.locacoesVeiculosPesados.Add(this);
        }

        public static IEnumerable<Model.LocacaoVeiculoPesado> GetVeiculos(int IdLocacao)
        {
            return from Veiculo in Context.locacoesVeiculosPesados where Veiculo.IdLocacao == IdLocacao select Veiculo;
        }

        public static double GetTotal(int IdLocacao)
        {
            return (
                from Veiculo in Context.locacoesVeiculosPesados
                where Veiculo.IdLocacao == IdLocacao
                select Veiculo.veiculoPesado.Preco
            ).Sum();
        }

        public static int GetCount(int IdLocacao)
        {
            return GetVeiculos(IdLocacao).Count();
        }
    }
}