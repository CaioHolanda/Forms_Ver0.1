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
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
