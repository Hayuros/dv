using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class Cliente
    {
        public int Id { set; get; } // Identificador Único (ID)

        public string Nome { set; get; } // Nome

        public DateTime Aniversario { set; get; } // Data de Nascimento

        public string Identificacao { set; get; } // C.P.F.

        public int DiasRetorno { set; get; } // Dias para Devolução

        public Cliente() {

        }
        public Cliente(string Nome,
            DateTime Aniversario,
            string Identificacao,
            int DiasRetorno)
        {
            this.Id = Context.clientes.Count;
            this.Nome = Nome;
            this.Aniversario = Aniversario;
            this.Identificacao = Identificacao;
            this.DiasRetorno = DiasRetorno;
            
            Context.clientes.Add(this);
        }

        public override string ToString()
        {
            return String.Format("Id: {0}\nNome: {1}\nData de Nascimento {2:d}\nDias para Devolução: {3}\nQuantidade de Locações: {4}",
                this.Id,
                this.Nome,
                this.Aniversario,
                this.DiasRetorno,
                Locacao.GetCount(this.Id)
            );
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
            Cliente cliente = (Cliente)obj;
            return this.GetHashCode() == cliente.GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }

        public static IEnumerable<Cliente> GetClientes()
        {
            return from cliente in Context.clientes select cliente;
        }

        public static int GetConta()
        {
            return GetClientes().Count();
        }

        public static void AddCliente(Cliente cliente)
        {
            Context.clientes.Add(cliente);
        }

        public static Cliente GetCliente(int Id)
        {
            IEnumerable<Cliente> query = from cliente in Context.clientes where cliente.Id == Id select cliente;

            return query.First();

        }

        public static Cliente AtualizarCliente(
            Cliente cliente
        ) {
            Context.clientes.Update(cliente);
            return cliente;
        } 

        public static Cliente ExcluirCliente(int id) {
            Cliente cliente = GetCliente(id);
            Context.clientes.Remove(cliente);
            return cliente;
        }
    } //Término da classe cliente.
}