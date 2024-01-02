using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alura.Filmes.App
{
    public partial class Frm_CadastroUsers : UserControl
    {
        public Frm_CadastroUsers()
        {
            InitializeComponent();
            Lbl_Id_Tag.Text = "Identificação:";
            Lbl_Id_Value.Text = "?????";
            Lbl_Password.Text = "Senha:";
            Lbl_Service.Text = "Serviço:";
            Lbl_User.Text = "Usuário:";
            Grp_Usuario.Text = "Comentários";
            
        }
    }
}
