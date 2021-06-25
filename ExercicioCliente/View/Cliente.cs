using System;
using System.Collections.Generic;

namespace View
{
    public static class Cliente
    {

        public static void CriarCliente()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nCadastro de Clientes!");
            Console.WriteLine("*************************************");
            Console.WriteLine("\nInforme o seu nome.");
            string Nome = Console.ReadLine();
            Console.WriteLine("\nInforme o seu aniversário.");
            string Aniversario = Console.ReadLine();
            Console.WriteLine("\nInforme o seu CPF.");
            string Identificacao = Console.ReadLine();
            Console.WriteLine("\nInforme a quantidade de dias de retorno.");
            string DiasRetorno = Console.ReadLine();
            try
            {
                Controller.Cliente.CriarCliente(Nome, Aniversario, Identificacao, DiasRetorno);
            }
            catch (Exception e)
            {
                Console.WriteLine($"As Informações digitadas estão incorretas: {e.Message}");
            }
        } //Término do programa de cadastro de clientes.

        public static void ListaCliente()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nListagem de Clientes");
            Console.WriteLine("*************************************");
            foreach (Model.Cliente cliente in Controller.Cliente.ListaCliente())
            {
                Console.WriteLine("=====================================");
                Console.WriteLine(cliente);
            }
            Console.WriteLine("=====================================");
        }//Término do programa de listagem dos clientes.

        public static void AtualizarCliente() {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nAtualização de Clientes");
            Console.WriteLine("*************************************");
           Model.Cliente cliente;
           try
           {
               Console.WriteLine("\nDigite o Id do cliente: ");
               string id = Console.ReadLine();
               cliente = Controller.Cliente.GetCliente(Convert.ToInt32(id));
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
               return;
           }
           Console.WriteLine("Digite o Campo para Alteração");
           Console.WriteLine("[1] - Nome");
           Console.WriteLine("[2] - C.P.F.");
           string campo = Console.ReadLine();

           Console.WriteLine("Digite o Valor de Alteração");
           string valor = Console.ReadLine();

           try
           {
               Controller.Cliente.AtualizarCliente(cliente);
           }
           catch (Exception e) 
           {
               Console.WriteLine(e.Message);
           }
        }

        public static void ExcluirCliente() {
            try
            {
                Console.WriteLine("Digite o Id do Cliente");
                string Id = Console.ReadLine();
                Controller.Cliente.ExcluirCliente(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    } //Término da classe cliente.
} //Término do namespace.