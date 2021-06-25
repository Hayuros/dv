using System;
using System.Collections.Generic;

namespace View
{
    public class Locacao
    {
        public static void CriarLocacao()
        {
            int opc;
            int opcLeve;
            int opcPesado;
            List<Model.VeiculoPesado> VeiculosPesados = new List<Model.VeiculoPesado>();
            List<Model.VeiculoLeve> VeiculosLeves = new List<Model.VeiculoLeve>();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("\nLocando um Veículo");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o Id do Cliente: ");
            string IdCliente = Console.ReadLine();
            Console.WriteLine("Digite a Data de Locação: ");
            string DataLocacao = Console.ReadLine();

            Console.WriteLine("Foram locados Veículos Leves?");
            Console.WriteLine("[1] - Sim.");
            opc = Convert.ToInt32(Console.ReadLine());
            if (opc == 1)
            {
                do
                {
                    Console.WriteLine("Digite o Id do Veículo Leve: ");
                    try
                    {
                        int IdVeiculo = Convert.ToInt32(Console.ReadLine());
                        Model.VeiculoLeve veiculo = Controller.VeiculoLeve.GetVeiculoLeve(IdVeiculo);
                        VeiculosLeves.Add(veiculo);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine("Informar outro Veículo? ");
                    Console.WriteLine("[1] - Sim.");
                    opcLeve = Convert.ToInt32(Console.ReadLine());
                } while (opcLeve == 1);
            }

            Console.WriteLine("Foram locados Veículos Pesados?");
            Console.WriteLine("[1] - Sim.");
            opc = Convert.ToInt32(Console.ReadLine());
            if (opc == 1)
            {
                do
                {
                    Console.WriteLine("Digite o Id do Veículo Pesado: ");
                    try
                    {
                        int IdVeiculo = Convert.ToInt32(Console.ReadLine());
                        Model.VeiculoPesado veiculo = Controller.VeiculoPesado.GetVeiculoPesado(IdVeiculo);
                        VeiculosPesados.Add(veiculo);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine("Informar outro Veículo? ");
                    Console.WriteLine("[1] - Sim.");
                    opcPesado = Convert.ToInt32(Console.ReadLine());
                } while (opcPesado == 1);
            }

            try
            {
                Controller.Locacao.CriarLocacao(IdCliente, DataLocacao, VeiculosLeves, VeiculosPesados);
            }
            catch (Exception e)
            {
                Console.WriteLine($"As informações digitadas estão Incorretas: {e.Message}");
            }
        }

        public static void ListarLocacoes()
        {
            foreach (Model.Locacao locacao in Controller.Locacao.GetLocacoes())
            {
                Console.WriteLine("===================================");
                Console.WriteLine(locacao);
            }
            Console.WriteLine("===================================");
        }

        // public static void AtualizarLocacao(){
        //     Console.WriteLine("*************************************");
        //     Console.WriteLine("\nAtualização de Locações");
        //     Console.WriteLine("*************************************");
        //    Model.Locacao locacao;
        //    try
        //    {
        //        Console.WriteLine("\nDigite o Id da Locação: ");
        //        string Id = Console.ReadLine();
        //        locacao = Controller.Locacao.GetLocacao(Convert.ToInt32(Id));
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return;
        //    }
        //    Console.WriteLine("Digite o Campo para Alteração");
        //    Console.WriteLine("[1] - CLiente");
        //    Console.WriteLine("[2] - Veículo Leve");
        //    Console.WriteLine("[3] - Veículo Pesado");
        //    string campo = Console.ReadLine();

        //    Console.WriteLine("Digite o Valor de Alteração");
        //    string valor = Console.ReadLine();

        //    try
        //    {
        //        Controller.Locacao.AtualizarLocacao(locacao, campo, valor);
        //    }
        //    catch (Exception e) 
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        // }

        public static void ExcluirLocacao() {
            try
            {
                Console.WriteLine("Digite o Id da Locação");
                string Id = Console.ReadLine();
                Controller.Locacao.ExcluirLocacao(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}