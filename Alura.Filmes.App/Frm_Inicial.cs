using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms_Ver01_Biblioteca;

namespace Alura.Filmes.App.Forms
{
    public partial class Frm_Inicial : Form
    {
        public Frm_Inicial()
        {
            InitializeComponent();
            desconectarToolStripMenuItem.Enabled = false;
        }
        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();
            if (F.DialogResult == DialogResult.OK)
            {
                string senha = F.senha;
                string login = F.login;
                if (Cls_Uteis.validaSenhaLogin(senha)==true)
                {
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_CadastroUsers C=new Frm_CadastroUsers();
                    TabPage TB = new TabPage();
                    TB.Name = "Cadastro";
                    TB.Text = "Cadastro de Registros";
                    TB.ImageIndex= 6;
                    C.Dock = DockStyle.Fill;
                    TB.Controls.Add(C);
                    Tbc_Aplicacoes.Controls.Add(TB);
                }
                else
                {
                    MessageBox.Show("Senha Inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tbc_Aplicacoes.TabPages.Clear();
            desconectarToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
