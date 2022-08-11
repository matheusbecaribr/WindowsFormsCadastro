using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCadastro
{
    public partial class Cadastro : Form
    {
        public struct Usuar {
            public int codigo;
            public string nome;
            public string nivel;
            public string login;
            public string senha;
        }

        static public Usuar[] usuarios = new Usuar[10];
        static public int contUsuario = 0;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastrousuario = new CadastroUsuario();
            cadastrousuario.ShowDialog();
        }
    }
}
