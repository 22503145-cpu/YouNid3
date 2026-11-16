using MySql.Data.MySqlClient; // instrução que disponibiliza classes do MySQL.
using System;
using System.Data;

namespace SushiRestaurant
{
    internal class Conexao
    {
        //Criação do objeto de conexão:
        MySqlConnection conn;

        //Criação do método de conexão:
        private void Conectar()
        {
            string dadosConexao = "Persist security info = false; server = localhost; database = SushiRestaurant; uid = root; pwd=;";
            try
            {
                conn = new MySqlConnection(dadosConexao);
                conn.Open();
            }
            catch(MySqlException ex)
            {
                throw new Exception($"A conexão não foi estabelecida.\n{ex.Message}");
            }
        }

        //Criação do método que executa comandos que não retornam valor do BD: INSERT/UPDATE/DELETE

        public void ExecutarComando(string sql)      //sql: conter INSERT, UPDATE ou DELETE
        {
            Conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Instrução não executada.\n{sql}\n{ex.Message}");      //se houver exceção
            }
            finally     //sempre será executado
            {
                conn.Close();
            }
        }

        // Método de execução de SELECT's:
        public DataTable ExecutarConsulta(string query)
        {
            Conectar();
            try
            {
                MySqlDataAdapter dados = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Instrução SELECT com erro.\n{query}\n{ex.Message}");      //se houver exceção
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
