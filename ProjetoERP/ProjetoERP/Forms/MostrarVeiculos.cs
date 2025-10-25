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

namespace ProjetoERP
{
    public partial class MostrarVeiculos : Form
    {
        public static string conexaoBanco = "Server=phpmyadmin.uni9.marize.us;Database=db_user_11;Uid=user_11;Pwd=Twq7e9YE-11!";
        public MostrarVeiculos()
        {
            InitializeComponent();
        }

        private void MostrarVeiculos_Load(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                conn.Open();
                try
                {
                    string sql = "SELECT IDVEICULOS, DATA_ENTRADA, DATA_SAIDA, PLACA, MARCA, MODELO, COR, ANO_MODELO, " +
                                 "GROUP_CONCAT(DISTINCT S.SERVICO SEPARATOR '\n') AS SERVICO, " +
                                 "GROUP_CONCAT(DISTINCT OBSERVACAO SEPARATOR '\n') AS OBSERVACAO " +
                                 "FROM db_user_11.veiculos as V " +
                                 "INNER JOIN db_user_11.servicos as S " +
                                 "ON V.IDVEICULOS = S.ID_VEICULOS " +
                                 "INNER JOIN db_user_11.observacoes as O " +
                                 "ON V.IDVEICULOS = O.ID_VEICULOS " +
                                 "GROUP BY V.IDVEICULOS;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader leitor = cmd.ExecuteReader();
                    while(leitor.Read())
                    {
                        string id = leitor.GetInt32("IDVEICULOS").ToString();
                        //string dataEntrada = leitor.GetString("DATA_ENTRADA");
                        //string dataSaida = leitor.GetString("DATA_SAIDA");
                        string placa = leitor.GetString("PLACA");
                        string marca = leitor.GetString("MARCA");
                        string modelo = leitor.GetString("MODELO");
                        string cor = leitor.GetString("COR");
                        string anoModelo = leitor.GetString("ANO_MODELO");
                        string servico = leitor.GetString("SERVICO");
                        string observacao = leitor.GetString("OBSERVACAO");

                        grid_informacao.Rows.Add(id, placa, marca, modelo, cor, anoModelo, servico, observacao);
                        grid_informacao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        grid_informacao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
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
    }
}
