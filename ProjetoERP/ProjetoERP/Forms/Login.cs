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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text;
            string senha = txt_Senha.Text;

            if(Classes.VerificaUsuario(usuario, senha))
            {
                this.Close();
            }
            else
            {
                txt_Usuario.Text = "";
                txt_Senha.Text = "";
                txt_Usuario.Focus();
                MessageBox.Show("Usuário ou senha Inválidos.");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Entrar_Click(null, null);
            }
        }
    }
}
