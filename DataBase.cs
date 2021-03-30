using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Gama_SistemaFinanceiro
{
    class DataBase
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection ConnectionDataBase()
        {
            connection = new SQLiteConnection("Data Source = C: \\Users\\joaog\\Documents\\Projeto carlos financeiro\\Gama_SistemaFinanceiro\\data_base\\bd_financeiro.db");
            connection.Open();
            return connection;


        }


    }
}
