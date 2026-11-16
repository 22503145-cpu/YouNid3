using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SushiRestaurant
{
    internal class Cliente
    {
        private int id;
        private string nome, email, cpf, telefone, cep, rua, numero, complemento, bairro, cidade, uf;
        private DateTime dtnasc;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetCpf()
        {
            return this.cpf;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetTelefone()
        {
            return this.telefone;
        }

        public void SetDtNasc(DateTime dtnasc)
        {
            this.dtnasc = dtnasc;
        }

        public DateTime GetDtNasc()
        {
            return this.dtnasc;
        }

        public void SetCep(string cep)
        {
            this.cep = cep;
        }

        public string GetCep()
        {
            return this.cep;
        }

        public void SetRua(string rua)
        {
            this.rua = rua;
        }

        public string GetRua()
        {
            return this.rua;
        }

        public void SetNumero(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public void SetComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public string GetComplemento()
        {
            return this.complemento;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string GetBairro()
        {
            return this.bairro;
        }

        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string GetCidade()
        {
            return this.cidade;
        }

        public void SetUf(string uf)
        {
            this.uf = uf;
        }

        public string GetUf()
        {
            return this.uf;
        }

        Conexao db = new Conexao();

        public void InserirCliente()
        {
            string inserir = $"INSERT INTO tblClientes VALUES (null, '{MySqlHelper.EscapeString(nome)}', '{MySqlHelper.EscapeString(email)}', '{MySqlHelper.EscapeString(cpf)}', '{MySqlHelper.EscapeString(telefone)}', '{dtnasc.ToString("yyyy-MM-dd")}', '{MySqlHelper.EscapeString(cep)}', '{MySqlHelper.EscapeString(rua)}', '{MySqlHelper.EscapeString(numero)}', '{MySqlHelper.EscapeString(complemento)}', '{MySqlHelper.EscapeString(bairro)}', '{MySqlHelper.EscapeString(cidade)}', '{MySqlHelper.EscapeString(uf)}');";
            db.ExecutarComando(inserir);
        }

        public void AlterarCliente()
        {
            string alterar = $"UPDATE tblClientes SET nome = '{MySqlHelper.EscapeString(nome)}', cpf = '{MySqlHelper.EscapeString(cpf)}', telefone = '{MySqlHelper.EscapeString(telefone)}', dtnasc = '{dtnasc.ToString("yyyy-MM-dd")}', cep = '{MySqlHelper.EscapeString(cep)}', rua = '{MySqlHelper.EscapeString(rua)}', numero = '{MySqlHelper.EscapeString(numero)}', complemento = '{MySqlHelper.EscapeString(complemento)}', bairro = '{MySqlHelper.EscapeString(bairro)}', cidade = '{MySqlHelper.EscapeString(cidade)}', uf = '{MySqlHelper.EscapeString(uf)}' WHERE email = '{MySqlHelper.EscapeString(email)}';";
            db.ExecutarComando(alterar);
        }

        public bool ExisteCliente()
        {
            string consulta = $"SELECT id FROM tblClientes WHERE email = '{MySqlHelper.EscapeString(email)}';";
            return db.ExecutarConsulta(consulta).Rows.Count > 0;
        }
    }
}
