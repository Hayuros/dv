using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public static class Cliente
    {
        public static Model.Cliente CriarCliente(
            string Nome,
            string StringAniversario,
            string Identificacao,
            string DiasRetorno
        )
        {
            Regex rgx = new Regex("^\\d{3}\\.\\d{3}\\.\\d{3}\\-\\d{2}$");
            if (!rgx.IsMatch(Identificacao))
            {
                throw new Exception("\nC.P.F. Inválido\nPor favor digite um cpf válido.\nEx: 000.000.000-00");
            }

            DateTime Aniversario;

            try
            {
                Aniversario = Convert.ToDateTime(StringAniversario);
            }
            catch
            {
                throw new Exception("\nData de Nascimento Inválida\nDigite uma data válida\nEx: dd/mm/aaaa");
            }

            return new Model.Cliente(Nome,
                Aniversario,
                Identificacao,
                Convert.ToInt32(DiasRetorno)
            );
        }

        public static IEnumerable<Model.Cliente> ListaCliente()
        {
            return Model.Cliente.GetClientes();
        }


        public static Model.Cliente GetCliente(int Id)
        {
            int TamanhoLista = Model.Cliente.GetConta();

            if (Id < 0 || TamanhoLista <= Id)
            {
                throw new Exception("\nO Id informado é inválido.");
            }

            return Model.Cliente.GetCliente(Id);
        }

        public static Model.Cliente AtualizarCliente(
            Model.Cliente cliente
        ) {
            return Model.Cliente.AtualizarCliente(cliente);
        }

        public static void ExcluirCliente(string StringId) {
            int Id = Convert.ToInt32(StringId);
            try
            {
                Model.Cliente.ExcluirCliente(Id);
            }
            catch (Exception e)
            {
                throw new Exception($"Está exclusão não foi permitida/Id Inválido." +e.Message);
            }
        }

    }//Término da classe cliente.
}
