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
    public partial class Agenda : Form
    {
        public static string conexaoBanco = "Server=phpmyadmin.uni9.marize.us;Database=db_user_11;Uid=user_11;Pwd=Twq7e9YE-11!";
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                conn.Open();
                try
                {
                    string sql = "SELECT V.DATA_SAIDA, V.MODELO, C.NOME " +
                                 "FROM db_user_11.veiculos as V " +
                                 "INNER JOIN db_user_11.clientes as C " +
                                 "ON C.IDCLIENTE = V.ID_CLIENTE;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        string Id = leitor.GetDateTime("DATA_SAIDA").ToString("d");
                        string Modelo = leitor.GetString("MODELO");
                        string Nome = leitor.GetString("NOME");

                        if (leitor.GetDateTime("DATA_SAIDA").Date == DateTime.Now.Date)
                        {
                            //informacao_data.Items.Add($"{leitor.GetDateTime("DATA_SAIDA"):dd/MM/yyyy} - {leitor.GetString("MODELO")} - {leitor.GetString("NOME")}");
                            informacao_data.Rows.Add(Id, Modelo, Nome);
                        }

                        informacao_data.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        informacao_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
