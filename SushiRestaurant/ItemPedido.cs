using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SushiRestaurant
{
    internal class ItemPedido
    {
        // Atributos da classe - conforme os campos da tabela de itens do pedido (BD)
        private int id, idPedido, quantidade;
        private string produto;
        private decimal preco;

        // Encapsulamento para todos os atributos

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

        //Métodos do CRUD
        //1º passo: instanciar a classe de conexão:

        Conexao db = new Conexao();

        //2º passo: criar o método de InserirItem:
        //O item é ligado ao último pedido inserido: (SELECT MAX(id) FROM tblPedidos).
        public void InserirItem()
        {
            string inserir = $"INSERT INTO tblItensPedido VALUES (null, (SELECT MAX(id) FROM tblPedidos), '{MySqlHelper.EscapeString(produto)}', '{preco.ToString().Replace(',', '.')}', '{quantidade}');";
            db.ExecutarComando(inserir);
        }

        //3º passo: criar o método para retornar a lista de itens de um pedido:
        public DataTable ListarItens()
        {
            string consulta = $"SELECT produto, quantidade, preco FROM tblItensPedido WHERE idPedido = '{this.idPedido}';";
            return db.ExecutarConsulta(consulta);
        }
    }
}
