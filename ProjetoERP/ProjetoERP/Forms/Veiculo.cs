using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoERP.Forms
{
    public partial class Veiculo : Form
    {
        public static string conexaoBanco = "Server=phpmyadmin.uni9.marize.us;Database=db_user_11;Uid=user_11;Pwd=Twq7e9YE-11!";
        public Veiculo()
        {
            InitializeComponent();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            data_entrada.Text = DateTime.Now.ToString();
            data_saida.Text = DateTime.Now.ToString();
            txt_Placa.Text = "";
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            txt_Cor.Text = "";
            txt_anoModelo.Text = "";
            check_Revisao.Checked = false;
            check_Diagnostico.Checked = false;
            check_Geometria.Checked = false;
            check_Estetica.Checked = false;
            area_reclamacao.Text = "";
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sqlVeiculos = "INSERT INTO db_user_11.veiculos VALUES(" +
                                         "null, @dataEntrada, @dataSaida, @placa, @marca, @modelo, @cor, @anoModelo, @idCliente);";
                    DateTime dataEntrada = DateTime.ParseExact(data_entrada.Text, "dd/MM/yyyy", null);
                    DateTime dataSaida = DateTime.ParseExact(data_saida.Text, "dd/MM/yyyy", null);

                    MySqlCommand cmdVeiculos = new MySqlCommand(sqlVeiculos, conn, transaction);
                    cmdVeiculos.Parameters.AddWithValue("@dataEntrada", dataEntrada);
                    cmdVeiculos.Parameters.AddWithValue("@dataSaida", dataSaida);
                    cmdVeiculos.Parameters.AddWithValue("@placa", txt_Placa.Text);
                    cmdVeiculos.Parameters.AddWithValue("@marca", txt_Marca.Text);
                    cmdVeiculos.Parameters.AddWithValue("@cor", txt_Cor.Text);
                    cmdVeiculos.Parameters.AddWithValue("@modelo", txt_Modelo.Text);
                    cmdVeiculos.Parameters.AddWithValue("@anoModelo", txt_anoModelo.Text);
                    cmdVeiculos.Parameters.AddWithValue("@idCliente", txt_IdCliente.Text);
                    cmdVeiculos.ExecuteNonQuery();

                    long idVeiculos = cmdVeiculos.LastInsertedId;

                    List<string> selecionados = new List<string>();

                    if (check_Revisao.Checked) selecionados.Add("Revisão");
                    if (check_Geometria.Checked) selecionados.Add("Geometria");
                    if (check_Diagnostico.Checked) selecionados.Add("Diagnóstico");
                    if (check_Estetica.Checked) selecionados.Add("Estética");

                    foreach (var item in selecionados)
                    {
                        string sqlServicos = "INSERT INTO db_user_11.servicos VALUES(" +
                                             "null, @servico, @idVeiculos);";
                        MySqlCommand cmdServicos = new MySqlCommand(sqlServicos, conn, transaction);
                        cmdServicos.Parameters.AddWithValue("@servico", item);
                        cmdServicos.Parameters.AddWithValue("@idVeiculos", idVeiculos);
                        cmdServicos.ExecuteNonQuery();
                    }

                    string sqlObservacoes = "INSERT INTO db_user_11.observacoes VALUES(" +
                                             "null, @observacao, @idVeiculos);";
                    MySqlCommand cmdObservacao = new MySqlCommand(sqlObservacoes, conn, transaction);
                    cmdObservacao.Parameters.AddWithValue("@observacao", area_reclamacao.Text);
                    cmdObservacao.Parameters.AddWithValue("@idVeiculos", idVeiculos);
                    cmdObservacao.ExecuteNonQuery();

                    MessageBox.Show("Dados Inseridos Com Sucesso!");
                    transaction.Commit();

                    data_entrada.Value = DateTime.Now;
                    data_saida.Value = DateTime.Now;
                    txt_Placa.Text = "";
                    txt_Marca.Text = "";
                    txt_Modelo.Text = "";
                    txt_Cor.Text = "";
                    txt_anoModelo.Text = "";
                    txt_IdCliente.Text = "";

                    check_Diagnostico.Checked = false;
                    check_Estetica.Checked = false;
                    check_Geometria.Checked = false;
                    check_Revisao.Checked = false;
                    area_reclamacao.Clear();

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

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MostrarVeiculos m = new MostrarVeiculos();
            m.ShowDialog();
            
        }
    }
}
