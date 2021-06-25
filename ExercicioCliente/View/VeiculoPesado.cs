using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoPesado
    {
        public static void CriarVeiculoPesado()
        {
            Console.WriteLine("Digite a Marca do Veículo");
            string Marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo do Veículo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Digite o Ano do Veículo");
            string Ano = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Veículo");
            string Preco = Console.ReadLine();
            Console.WriteLine("Digite as Restrições do Veículo");
            string Restricoes = Console.ReadLine();

            Controller.VeiculoPesado.CriarVeiculoPesado(Marca, Modelo, Ano, Preco, Restricoes);
        }

        public static void ListaVeiculosPesados()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nListagem de Veículos Pesados");
            Console.WriteLine("*************************************");
            foreach (Model.VeiculoPesado veiculo in Controller.VeiculoPesado.ListaVeiculoPesado())
            {
                Console.WriteLine("===========================");
                Console.WriteLine(veiculo);
            }
            Console.WriteLine("===========================");
        }

        public static void AtualizarVeiculoPesado() {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nAtualização de Veiculos Pesados");
            Console.WriteLine("*************************************");
           Model.VeiculoPesado VeiculoPesado;
           try
           {
               Console.WriteLine("\nDigite o Id do Veiculo Pesado: ");
               string id = Console.ReadLine();
               VeiculoPesado = Controller.VeiculoPesado.GetVeiculoPesado(Convert.ToInt32(id));
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
           Console.WriteLine("[5] - Restrições do Veículo");
           string campo = Console.ReadLine();

           Console.WriteLine("Digite o Valor de Alteração");
           string valor = Console.ReadLine();

           try
           {
               Controller.VeiculoPesado.AtualizarVeiculoPesado(VeiculoPesado);
           }
           catch (Exception e) 
           {
               Console.WriteLine(e.Message);
           }
        }

        public static void ExcluirVeiculoPesado() {
            try
            {
                Console.WriteLine("Digite o Id do VeiculoPesado");
                string Id = Console.ReadLine();
                Controller.VeiculoPesado.ExcluirVeiculoPesado(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}