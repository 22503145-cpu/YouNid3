using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SushiRestaurant
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Cliente objCliente = new Cliente();
        Pedido objPedido = new Pedido();
        ItemPedido objItem = new ItemPedido();

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            MostrarDadosPedidos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MostrarDadosPedidos();
        }

        private void MostrarDadosPedidos()
        {
            try
            {
                dtgPedidos.DataSource = objPedido.ListarPedidos();
                dtgItens.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string idPedido = Convert.ToString(dtgPedidos.Rows[e.RowIndex].Cells["id"].Value);

            if (idPedido == "")
                return;

            objItem.SetIdPedido(int.Parse(idPedido));
            dtgItens.DataSource = objItem.ListarItens();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Filter = "Arquivo JSON (*.json)|*.json";

            if (janela.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(janela.FileName);
                    JavaScriptSerializer leitor = new JavaScriptSerializer();
                    dynamic dados = leitor.DeserializeObject(json);
                    int pedidosNovos = 0;

                    foreach (dynamic cliente in dados["clientes"])
                    {
                        objCliente.SetNome(cliente["nome"]);
                        objCliente.SetEmail(cliente["email"]);
                        objCliente.SetCpf(cliente["cpf"]);
                        objCliente.SetTelefone(cliente["telefone"]);
                        objCliente.SetDtNasc(DateTime.Parse(cliente["nascimento"]));
                        objCliente.SetCep(cliente["cep"]);
                        objCliente.SetRua(cliente["rua"]);
                        objCliente.SetNumero(cliente["numero"]);
                        objCliente.SetComplemento(cliente["complemento"]);
                        objCliente.SetBairro(cliente["bairro"]);
                        objCliente.SetCidade(cliente["cidade"]);
                        objCliente.SetUf(cliente["uf"]);

                        if (objCliente.ExisteCliente())
                            objCliente.AlterarCliente();
                        else
                            objCliente.InserirCliente();
                    }

                    foreach (dynamic pedido in dados["pedidos"])
                    {
                        objPedido.SetNumero(pedido["numero"]);
                        objPedido.SetEmailCliente(pedido["email"]);
                        objPedido.SetData(DateTime.Parse(pedido["data"]));
                        objPedido.SetPagamento(pedido["pagamento"]);
                        objPedido.SetTotal(Convert.ToDecimal(pedido["total"]));

                        if (!objPedido.ExistePedido())
                        {
                            objPedido.InserirPedido();

                            foreach (dynamic item in pedido["itens"])
                            {
                                objItem.SetProduto(item["produto"]);
                                objItem.SetPreco(Convert.ToDecimal(item["preco"]));
                                objItem.SetQuantidade(item["quantidade"]);
                                objItem.InserirItem();
                            }

                            pedidosNovos++;
                        }
                    }

                    MostrarDadosPedidos();
                    MessageBox.Show($"Dados IMPORTADOS com sucesso.\nPedidos novos: {pedidosNovos}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível importar o arquivo.\n{ex.Message}");
                }
            }
        }
    }
}
