using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SushiRestaurant
{
    internal class Pedido
    {
        private int id, numero;
        private string emailCliente, pagamento;
        private DateTime data;
        private decimal total;

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

        Conexao db = new Conexao();

        public void InserirPedido()
        {
            string inserir = $"INSERT INTO tblPedidos VALUES (null, '{numero}', (SELECT id FROM tblClientes WHERE email = '{MySqlHelper.EscapeString(emailCliente)}'), '{data.ToString("yyyy-MM-dd HH:mm:ss")}', '{MySqlHelper.EscapeString(pagamento)}', '{total.ToString().Replace(',', '.')}');";
            db.ExecutarComando(inserir);
        }

        public bool ExistePedido()
        {
            string consulta = $"SELECT id FROM tblPedidos WHERE numero = '{numero}' AND data = '{data.ToString("yyyy-MM-dd HH:mm:ss")}' AND idCliente = (SELECT id FROM tblClientes WHERE email = '{MySqlHelper.EscapeString(emailCliente)}');";
            return db.ExecutarConsulta(consulta).Rows.Count > 0;
        }

        public DataTable ListarPedidos()
        {
            string consulta = "SELECT p.id, p.numero, p.data, c.nome AS cliente, c.telefone, p.pagamento, p.total FROM tblPedidos p INNER JOIN tblClientes c ON c.id = p.idCliente ORDER BY p.data DESC;";
            return db.ExecutarConsulta(consulta);
        }
    }
}
