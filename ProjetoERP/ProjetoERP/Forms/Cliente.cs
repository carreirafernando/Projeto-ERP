using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT c.NOME, c.CPF, c.EMAIL, e.RUA, e.NUMERO, e.CEP, e.CIDADE, e.UF, t.TIPO, t.NUMEROTELEFONE " +
                                 "FROM db_user_11.clientes c " +
                                 "INNER JOIN db_user_11.endereco e " +
                                 "ON c.IDCLIENTE = e.ID_CLIENTE " +
                                 "INNER JOIN db_user_11.telefone t " +
                                 "ON c.IDCLIENTE = t.ID_CLIENTE " +
                                 "WHERE IDCLIENTE = @id;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        //int idCliente = leitor.GetInt32("IDCLIENTE");
                        string nome = leitor.GetString("NOME");
                        string cpf = leitor.GetString("CPF");
                        string email = leitor.GetString("EMAIL");

                        string rua = leitor.GetString("RUA");
                        string numero = leitor.GetString("NUMERO");
                        string cep = leitor.GetString("CEP");
                        string cidade = leitor.GetString("CIDADE");
                        string uf = leitor.GetString("UF");

                        string tipo = leitor.GetString("TIPO");
                        string numeroTelefone = leitor.GetString("NUMEROTELEFONE");

                        //txt_id.Text = idCliente.ToString();
                        txt_Nome.Text = nome.ToString();
                        txt_CPF.Text = cpf.ToString();
                        txt_Email.Text = email.ToString();
                        txt_Rua.Text = rua.ToString();
                        txt_Numero.Text = numero.ToString();
                        txt_CEP.Text = cep.ToString();
                        txt_Cidade.Text = cidade.ToString();
                        txt_UF.Text = uf.ToString();
                        txt_Telefone.Text = numeroTelefone.ToString();
                        txt_TipoTelefone.Text = tipo.ToString();
                    }
                }
                catch (Exception ex)
                {
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


