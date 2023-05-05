using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANCO
{
    public partial class Login : Form
    {
        Usuario user = new Usuario();
        public Login()
        {
            InitializeComponent();
            txtCpf.MaxLength = 11;
        }
        

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            user.setCpf(txtCpf.Text);
            user.setSenha(txtSenha.Text);
            UsuarioBLL.login(user);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                Dashboard form2 = new Dashboard(user);
                form2.Show();
                Hide();
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            UsuarioBLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            UsuarioBLL.desconecta();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}


