using System.Collections.Generic;
using Model;
using System;
using Fake;
namespace Repository
{
    public class Context
    {
        public static DBFake<Cliente> clientes = new DBFake<Cliente>();
        public static DBFake<VeiculoPesado> veiculosPesados = new DBFake<VeiculoPesado>();
        public static DBFake<VeiculoLeve> veiculosLeves = new DBFake<VeiculoLeve>();
        public static DBFake<Locacao> locacoes = new DBFake<Locacao>();
        public static DBFake<LocacaoVeiculoPesado> locacoesVeiculosPesados = new DBFake<LocacaoVeiculoPesado>();
        public static DBFake<LocacaoVeiculoLeve> locacoesVeiculosLeves = new DBFake<LocacaoVeiculoLeve>();

        public void SaveChanges() {

        }

        public Context() {
            
        }
        /*
        string connUser = "bf07458e8e5095"; 
        string connPass = "236c2802"; 
        string connHost = "us-cdbr-east-04.cleardb.com"; 
        string connDb = "heroku_1fb931cf91c4b37"; 
        string connStr = $"server={​​​​connHost}​​​​​​​​​​​;Uid={​​​​​​​​​​​connUser}​​​​​​​​​​​;Pwd={​​​​​​​​​​​connPass}​​​​​​​​​​​;Database={​​​​​​​​​​​connDb}​​​​​​​​​​​;SSL Mode=None";
        options.UseMySql (connStr, mySqlOptionsAction : mysqlOptions => {
                mysqlOptions.EnableRetryOnFailure (
                maxRetryCount: 1,
                maxRetryDelay: TimeSpan.FromSeconds (30),
                errorNumbersToAdd: null
            );
        });
        */
    }
}