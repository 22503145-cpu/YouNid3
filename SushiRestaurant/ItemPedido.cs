using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SushiRestaurant
{
    internal class ItemPedido
    {
        private int id, idPedido, quantidade;
        private string produto;
        private decimal preco;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetIdPedido(int idPedido)
        {
            this.idPedido = idPedido;
        }

        public int GetIdPedido()
        {
            return this.idPedido;
        }

        public void SetProduto(string produto)
        {
            this.produto = produto;
        }

        public string GetProduto()
        {
            return this.produto;
        }

        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }

        public decimal GetPreco()
        {
            return this.preco;
        }

        public void SetQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public int GetQuantidade()
        {
            return this.quantidade;
        }

        Conexao db = new Conexao();

        public void InserirItem()
        {
            string inserir = $"INSERT INTO tblItensPedido VALUES (null, (SELECT MAX(id) FROM tblPedidos), '{MySqlHelper.EscapeString(produto)}', '{preco.ToString().Replace(',', '.')}', '{quantidade}');";
            db.ExecutarComando(inserir);
        }

        public DataTable ListarItens()
        {
            string consulta = $"SELECT produto, quantidade, preco FROM tblItensPedido WHERE idPedido = '{this.idPedido}';";
            return db.ExecutarConsulta(consulta);
        }
    }
}
