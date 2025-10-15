using MySql.Data.MySqlClient;
using ProjetoERP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoERP
{
    internal class Classes
    {
        public static string conexaoBanco = "Server=phpmyadmin.uni9.marize.us;Database=db_user_11;Uid=user_11;Pwd=Twq7e9YE-11!";

        public static string nomeUsuarioLogado = null;
        public static bool usuarioLogado = false;

        #region Consulta Usuario no banco
        public static bool VerificaUsuario(string usuarioEntrada, string senhaEntrada)
        {
            using(MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT usuario, senha FROM usuarios;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while(leitor.Read())
                    {
                        string usuario = leitor.GetString("usuario");
                        string senha = leitor.GetString("senha");

                        if(usuarioEntrada == usuario && senhaEntrada == senha)
                        {
                            usuarioLogado = true;
                            nomeUsuarioLogado = usuario;
                            return true;
                        }
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
            return false;
        }
        #endregion

        
    }
}
