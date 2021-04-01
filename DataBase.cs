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

        private static SQLiteConnection ConnectionDataBase() //metodo de criar conexão//
        {
            // Essa conexão pode ser feita de outra maneira se estivesse sob a estrutura de uma API
            connection = new SQLiteConnection("Data Source=C:\\Users\\joaog\\Documents\\Projeto carlos financeiro\\Gama_SistemaFinanceiro\\data_base\\bd_financeiro.db");
            connection.Open();
            return connection;
        }

        public static DataTable GetAllUsers() //metodo//
        {

            SQLiteDataAdapter da = null; //data adapter 
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDataBase().CreateCommand()) // criando um container da conexao com o banco//
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDataBase());
                    da.Fill(dt); //preenchido com conteudo da consulta//
                    ConnectionDataBase().Close();
                    return dt;
                }
            }catch(Exception ex)
            {
                ConnectionDataBase().Close();
                throw ex;
            }
        }

        public static DataTable consult(string sql) // metodo parametro
        {
            SQLiteDataAdapter da = null; //data adapter 
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDataBase().CreateCommand()) // criando um container da conexao com o banco//
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDataBase());
                    da.Fill(dt);
                    ConnectionDataBase().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConnectionDataBase().Close();
                throw ex;
            }

        }
    }
}
