using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoERP.Forms
{
    public partial class Cliente : Form
    {
        public static string conexaoBanco = "Server=phpmyadmin.uni9.marize.us;Database=db_user_11;Uid=user_11;Pwd=Twq7e9YE-11!";
        public Cliente()
        {

            InitializeComponent();
            tipo_tel.Items.Add("Selecione...");
            tipo_tel.Items.Add("Cel");
            tipo_tel.Items.Add("Com");
            tipo_tel.Items.Add("Tel");
            tipo_tel.SelectedIndex = 0;
        }

        public void LimparCampos()
        {
            txt_Nome.Clear();
            txt_CPF.Clear();
            txt_Email.Clear();
            txt_Rua.Clear();
            txt_Numero.Clear();
            txt_CEP.Clear();
            txt_Cidade.Clear();
            txt_UF.Clear();
            txt_Telefone.Clear();
            //txt_TipoTelefone.Clear();
        }

        public class Pessoa
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Email { get; set; }
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Cep { get; set; }
            public string Cidade { get; set; }
            public string Uf { get; set; }
            public string Tipo { get; set; }
            public string NumeroTelefone { get; set; }

            public string Informacoes { get; set; }
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            box_Resultado.Items.Clear();
            box_Resultado.Items.Add("ID  -  NOME");
            box_Resultado.Items.Add("");
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sqlConsulta = "SELECT C.IDCLIENTE, C.NOME, C.CPF, C.EMAIL, E.RUA, E.NUMERO, E.CEP, E.CIDADE, E.UF, T.TIPO, T.NUMEROTELEFONE " +
                                         "FROM db_user_11.clientes as C " +
                                         "INNER JOIN db_user_11.endereco as E " +
                                         "ON C.IDCLIENTE = E.ID_CLIENTE " +
                                         "INNER JOIN db_user_11.telefone as T " +
                                         "ON C.IDCLIENTE = T.ID_CLIENTE";
                    MySqlCommand cmd = new MySqlCommand(sqlConsulta, conn, transaction);
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while(leitor.Read())
                    {
                        Pessoa pessoa = new Pessoa
                        {
                            Id = leitor.IsDBNull(leitor.GetOrdinal("IDCLIENTE")) ? "" : leitor.GetInt32("IDCLIENTE").ToString(),
                            Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? "" : leitor.GetString("NOME"),
                            Cpf = leitor.IsDBNull(leitor.GetOrdinal("CPF")) ? "" : leitor.GetString("CPF"),
                            Email = leitor.IsDBNull(leitor.GetOrdinal("EMAIL")) ? "" : leitor.GetString("EMAIL"),
                            Rua = leitor.IsDBNull(leitor.GetOrdinal("RUA")) ? "" : leitor.GetString("RUA"),
                            Numero = leitor.IsDBNull(leitor.GetOrdinal("NUMERO")) ? "" : leitor.GetString("NUMERO"),
                            Cep = leitor.IsDBNull(leitor.GetOrdinal("CEP")) ? "" : leitor.GetString("CEP"),
                            Cidade = leitor.IsDBNull(leitor.GetOrdinal("CIDADE")) ? "" : leitor.GetString("CIDADE"),
                            Uf = leitor.IsDBNull(leitor.GetOrdinal("UF")) ? "" : leitor.GetString("UF"),
                            Tipo = leitor.IsDBNull(leitor.GetOrdinal("TIPO")) ? "" : leitor.GetString("TIPO"),
                            NumeroTelefone = leitor.IsDBNull(leitor.GetOrdinal("NUMEROTELEFONE")) ? "" : leitor.GetString("NUMEROTELEFONE"),
                            Informacoes = $"{leitor.GetInt32("IDCLIENTE").ToString()}  - {leitor.GetString("NOME")}"
                        };


                        box_Resultado.Items.Add(pessoa);
                    }

                    
                    box_Resultado.DisplayMember = "Informacoes";

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    if(txt_Nome.Text != "" && txt_CPF.Text != "")
                    {
                        // Inserir Clientes
                        string sqlCliente = "INSERT INTO db_user_11.clientes VALUES(" +
                                            "NULL, @nome, @cpf, @email);";
                        MySqlCommand cmdCliente = new MySqlCommand(sqlCliente, conn, transaction);
                        cmdCliente.Parameters.AddWithValue("@nome", txt_Nome.Text);
                        cmdCliente.Parameters.AddWithValue("@cpf", txt_CPF.Text);
                        cmdCliente.Parameters.AddWithValue("@email", txt_Email.Text);
                        cmdCliente.ExecuteNonQuery();
                        long idCliente = cmdCliente.LastInsertedId;

                        // Inserir endereço
                        string sqlEndereco = "INSERT INTO db_user_11.endereco VALUES(" +
                                             "null, @rua, @numero, @cep, @cidade, @uf, @idCliente);";
                        MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conn, transaction);
                        cmdEndereco.Parameters.AddWithValue("@rua", txt_Rua.Text);
                        cmdEndereco.Parameters.AddWithValue("@numero", txt_Numero.Text);
                        cmdEndereco.Parameters.AddWithValue("@cep", txt_CEP.Text);
                        cmdEndereco.Parameters.AddWithValue("@cidade", txt_Cidade.Text);
                        cmdEndereco.Parameters.AddWithValue("@uf", txt_UF.Text);
                        cmdEndereco.Parameters.AddWithValue("@idCliente", idCliente);
                        cmdEndereco.ExecuteNonQuery();

                        // Inserir telefone
                        string sqlTelefone = "INSERT INTO db_user_11.telefone VALUES(" +
                                             "null, @tipo, @numerotelefone, @idCliente);";
                        MySqlCommand cmdTelefone = new MySqlCommand(sqlTelefone, conn, transaction);
                        cmdTelefone.Parameters.AddWithValue("@tipo", tipo_tel.Text);
                        cmdTelefone.Parameters.AddWithValue("@numerotelefone", txt_Telefone.Text);
                        cmdTelefone.Parameters.AddWithValue("@idCliente", idCliente);
                        cmdTelefone.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Dados Inseridos com Sucesso");
                        LimparCampos();
                    }
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void box_Resultado_DoubleClick(object sender, EventArgs e)
        {
            if (box_Resultado.SelectedItem is Pessoa pessoaSelecionada)
            {
                txt_id.Text = pessoaSelecionada.Id;
                txt_Nome.Text = pessoaSelecionada.Nome;
                txt_CPF.Text = pessoaSelecionada.Cpf;
                txt_Email.Text = pessoaSelecionada.Email;
                txt_Telefone.Text = pessoaSelecionada.NumeroTelefone;

                tipo_tel.SelectedItem = pessoaSelecionada.Tipo;

                if (tipo_tel.SelectedItem == null && !string.IsNullOrEmpty(pessoaSelecionada.Tipo))
                {
                    tipo_tel.Items.Add(pessoaSelecionada.Tipo);
                    tipo_tel.SelectedItem = pessoaSelecionada.Tipo;
                }

                txt_Rua.Text = pessoaSelecionada.Rua;
                txt_Numero.Text = pessoaSelecionada.Numero;
                txt_CEP.Text = pessoaSelecionada.Cep;
                txt_Cidade.Text = pessoaSelecionada.Cidade;
                txt_UF.Text = pessoaSelecionada.Uf;
            }

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sqlCliente = "UPDATE db_user_11.clientes " +
                                        "SET NOME = @nome, EMAIL = @email, CPF = @cpf " +
                                        "WHERE IDCLIENTE = @idCliente;";
                    MySqlCommand cmdCliente = new MySqlCommand(sqlCliente, conn, transaction);
                    cmdCliente.Parameters.AddWithValue("@nome", txt_Nome.Text);
                    cmdCliente.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmdCliente.Parameters.AddWithValue("@cpf", txt_CPF.Text);
                    cmdCliente.Parameters.AddWithValue("@idCliente", txt_id.Text);
                    cmdCliente.ExecuteNonQuery();

                    string sqlEndereco = "UPDATE db_user_11.endereco " +
                                        "SET RUA = @rua, NUMERO = @numero, CEP = @cep, CIDADE = @cidade, UF = @uf " +
                                        "WHERE ID_CLIENTE = @idCliente;";
                    MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conn, transaction);
                    cmdEndereco.Parameters.AddWithValue("@rua", txt_Rua.Text);
                    cmdEndereco.Parameters.AddWithValue("@numero", txt_Numero.Text);
                    cmdEndereco.Parameters.AddWithValue("@cep", txt_CEP.Text);
                    cmdEndereco.Parameters.AddWithValue("@cidade", txt_Cidade.Text);
                    cmdEndereco.Parameters.AddWithValue("@uf", txt_UF.Text);
                    cmdEndereco.Parameters.AddWithValue("@idCliente", txt_id.Text);
                    cmdEndereco.ExecuteNonQuery();

                    string sqlTelefone = "UPDATE db_user_11.telefone " +
                                         "SET TIPO = @tipo, NUMEROTELEFONE = @numerotelefone " +
                                         "WHERE ID_CLIENTE = @idCliente;";
                    MySqlCommand cmdTelefone = new MySqlCommand(sqlTelefone, conn, transaction);
                    cmdTelefone.Parameters.AddWithValue("@tipo", tipo_tel.Text);
                    cmdTelefone.Parameters.AddWithValue("@numerotelefone", txt_Telefone.Text);
                    cmdTelefone.Parameters.AddWithValue("@idCliente", txt_id.Text);
                    cmdTelefone.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Dados atualizados com sucesso!");
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}


