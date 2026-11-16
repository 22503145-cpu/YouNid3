using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SushiRestaurant
{
    internal class Pedido
    {
        // Atributos da classe - conforme os campos da tabela de pedidos (BD)
        private int id, numero;
        private string emailCliente, pagamento;
        private DateTime data;
        private decimal total;

        // Encapsulamento para todos os atributos

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetEmailCliente(string emailCliente)
        {
            this.emailCliente = emailCliente;
        }

        public string GetEmailCliente()
        {
            return this.emailCliente;
        }

        public void SetData(DateTime data)
        {
            this.data = data;
        }

        public DateTime GetData()
        {
            return this.data;
        }

        public void SetPagamento(string pagamento)
        {
            this.pagamento = pagamento;
        }

        public string GetPagamento()
        {
            return this.pagamento;
        }

        public void SetTotal(decimal total)
        {
            this.total = total;
        }

        public decimal GetTotal()
        {
            return this.total;
        }

        //Métodos do CRUD
        //1º passo: instanciar a classe de conexão:

        Conexao db = new Conexao();

        //2º passo: criar o método de InserirPedido:
        //O id do cliente é buscado pelo e-mail, e o total troca a vírgula por ponto porque o MySQL usa ponto nos decimais.
        public void InserirPedido()
        {
            string inserir = $"INSERT INTO tblPedidos VALUES (null, '{numero}', (SELECT id FROM tblClientes WHERE email = '{MySqlHelper.EscapeString(emailCliente)}'), '{data.ToString("yyyy-MM-dd HH:mm:ss")}', '{MySqlHelper.EscapeString(pagamento)}', '{total.ToString().Replace(',', '.')}');";
            db.ExecutarComando(inserir);
        }

        //3º passo: criar o método que verifica se o pedido já foi importado (para não duplicar):
        public bool ExistePedido()
        {
            string consulta = $"SELECT id FROM tblPedidos WHERE numero = '{numero}' AND data = '{data.ToString("yyyy-MM-dd HH:mm:ss")}' AND idCliente = (SELECT id FROM tblClientes WHERE email = '{MySqlHelper.EscapeString(emailCliente)}');";
            return db.ExecutarConsulta(consulta).Rows.Count > 0;
        }

        //4º passo: criar o método para retornar a lista de pedidos cadastrados:
        public DataTable ListarPedidos()
        {
            string consulta = "SELECT p.id, p.numero, p.data, c.nome AS cliente, c.telefone, p.pagamento, p.total FROM tblPedidos p INNER JOIN tblClientes c ON c.id = p.idCliente ORDER BY p.data DESC;";
            return db.ExecutarConsulta(consulta);
        }
    }
}
