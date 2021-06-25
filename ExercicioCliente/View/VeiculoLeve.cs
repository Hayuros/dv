using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoLeve
    {
        public static void CriarVeiculoLeve()
        {
            Console.WriteLine("Digite a Marca do Veículo");
            string Marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo do Veículo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Digite o Ano do Veículo");
            string Ano = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Veículo");
            string Preco = Console.ReadLine();
            Console.WriteLine("Digite a Cor do Veículo");
            string Cor = Console.ReadLine();

            Controller.VeiculoLeve.CriarVeiculoLeve(Marca, Modelo, Ano, Preco, Cor);
        }

        public static void ListaVeiculosLeves()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nListagem de Veiculos Leves");
            Console.WriteLine("*************************************");
            foreach (Model.VeiculoLeve veiculo in Controller.VeiculoLeve.ListaVeiculosLeves())
            {
                Console.WriteLine("===========================");
                Console.WriteLine(veiculo);
            }
            Console.WriteLine("===========================");
        }

        public static void AtualizarVeiculoLeve() {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nAtualização de Veículos Leves");
            Console.WriteLine("*************************************");
           Model.VeiculoLeve VeiculoLeve;
           try
           {
               Console.WriteLine("\nDigite o Id do Veículo Leve: ");
               string id = Console.ReadLine();
               VeiculoLeve = Controller.VeiculoLeve.GetVeiculoLeve(Convert.ToInt32(id));
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
               return;
           }
           Console.WriteLine("Digite o Campo para Alteração");
           Console.WriteLine("[1] - Marca do Veículo");
           Console.WriteLine("[2] - Modelo do Veículo");
           Console.WriteLine("[3] - Ano do Veículo");
           Console.WriteLine("[4] - Preço do Veículo");
           Console.WriteLine("[5] - Cor do Veículo");
           string campo = Console.ReadLine();

           Console.WriteLine("Digite o Valor de Alteração");
           string valor = Console.ReadLine();

           try
           {
               Controller.VeiculoLeve.AtualizarVeiculoLeve(VeiculoLeve);
           }
           catch (Exception e) 
           {
               Console.WriteLine(e.Message);
           }
        }

        public static void ExcluirVeiculoLeve() {
            try
            {
                Console.WriteLine("Digite o Id do VeiculoLeve");
                string Id = Console.ReadLine();
                Controller.VeiculoLeve.ExcluirVeiculoLeve(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}