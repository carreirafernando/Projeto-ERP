using ProjetoERP.Forms;
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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            label_Data.Text = DateTime.Now.ToString("D").ToUpper();
            
        }

        #region Abrir Form no painel
        private void AbrirFormNoPainel(Form formFilho)
        {
            panel_Principal.Controls.Clear();
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panel_Principal.Controls.Add(formFilho);
            formFilho.Show();
        }
        #endregion

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            while(!Classes.usuarioLogado)
            {
                login.ShowDialog();
            }

            label_Usuario.Text = $"{Classes.nomeUsuarioLogado.ToUpper()[0]}{Classes.nomeUsuarioLogado.Substring(1)}";
        }

        private void btn_Inicial_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new ProjetoERP.Forms.Inicio());
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new ProjetoERP.Forms.Cliente());
        }

        private void Btn_Veiculo_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new ProjetoERP.Forms.Veiculo());
        }

        private void btn_Agenda_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new ProjetoERP.Forms.Agenda());
        }
    }
}
