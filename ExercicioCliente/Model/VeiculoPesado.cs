using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class VeiculoPesado : Veiculo
    {
        public int Id { set; get; }
        public string Restricoes { set; get; }

        public VeiculoPesado(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base(Marca, Modelo, Ano, Preco)
        {
            this.Restricoes = Restricoes;

            Context.veiculosPesados.Add(this);
        }

        public override string ToString()
        {
            return "\nId: " + this.Id +
                    "\n" + base.ToString() +
                    "\nRestricoes: " + this.Restricoes;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            VeiculoPesado veiculoPesado = (VeiculoPesado)obj;
            return this.GetHashCode() == veiculoPesado.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static IEnumerable<Model.VeiculoPesado> GetVeiculoPesado()
        {
            return from VeiculoPesado in Context.veiculosPesados select VeiculoPesado;
        }

        public static int GetCount()
        {
            return GetVeiculoPesado().Count();
        }

        public static VeiculoPesado GetVeiculoPesado(int Id)
        {
            return (
                from VeiculoPesado in Context.veiculosPesados
                where VeiculoPesado.Id == Id
                select VeiculoPesado
            ).First();
        }

         public static VeiculoPesado AtualizarVeiculoPesado(
            VeiculoPesado veiculoPesado
        ) {
            Context.veiculosPesados.Update(veiculoPesado);
            return veiculoPesado;
        }

        public static VeiculoPesado ExcluirVeiculoPesado(int id) {
            VeiculoPesado veiculoPesado = GetVeiculoPesado(id);
            Context.veiculosPesados.Remove(veiculoPesado);
            return veiculoPesado;
        }
    }
}