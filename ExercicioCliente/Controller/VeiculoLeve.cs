using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoLeve
    {
        public static Model.VeiculoLeve CriarVeiculoLeve(
            string Marca,
            string Modelo,
            string Ano,
            string Preco,
            string Cor
        )
        {
            int ConverteAno = Convert.ToInt32(Ano);
            double ConvertePreco = Convert.ToDouble(Preco);

            if (ConverteAno < 1990)
            {
                throw new Exception("Este carro é muito Antigo");
            }

            if (ConvertePreco < 0)
            {
                throw new Exception("O valor não pode ser Negativo");
            }

            return new Model.VeiculoLeve(
             Marca,
             Modelo,
             ConverteAno,
             ConvertePreco,
             Cor
            );
        }


        public static IEnumerable<Model.VeiculoLeve> GetVeiculoLeves() {
            return Model.VeiculoLeve.GetVeiculoLeve();
        }

        public static Model.VeiculoLeve GetVeiculoLeve(int Id)
        {
            int TamanhoLista = Model.VeiculoLeve.GetCount();

            if (Id < 0 || TamanhoLista <= Id)
            {
                throw new Exception("O Id informado é Inválido");
            }

            return Model.VeiculoLeve.GetVeiculoLeve(Id);
        }

        public static IEnumerable<Model.VeiculoLeve> ListaVeiculosLeves()
        {
            return Model.VeiculoLeve.GetVeiculoLeve();
        }

        public static Model.VeiculoLeve AtualizarVeiculoLeve(
            Model.VeiculoLeve veiculoLeve
        ) {
            return Model.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve);
        }

        public static void ExcluirVeiculoLeve(string StringId) {
            int Id = Convert.ToInt32(StringId);
            try
            {
                Model.VeiculoLeve.ExcluirVeiculoLeve(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Está exclusão não foi permitida/Id Inválido." +e.Message);
            }
        }
    }
}