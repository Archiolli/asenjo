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

    public partial class Dashboard : Form
    {
        string controle = "0123456789";
        ClassC c1;

        private Usuario _user;

        public Dashboard(Usuario user)
        {
            InitializeComponent();
            txtSaque.MaxLength = 4;
            _user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int saldo, saque, resto, cem, cinq, vinte, dez, cinco;
            saldo = Convert.ToInt32(lblSaldo.Text);
            c1 = new ClassC(saldo);

            lbl5.Text = " ";
            lbl10.Text = " ";
            lbl20.Text = " ";
            lbl50.Text = " ";
            lbl100.Text = " ";
            lbl5.Visible = true;
            lbl10.Visible = true;
            lbl20.Visible = true;
            lbl50.Visible = true;
            lbl100.Visible = true;


            if (rbtValorAlto.Checked == true)
            {
                if (txtSaque.Text != "")
                {
                    saque = Convert.ToInt32(txtSaque.Text);
                    resto = saque % 5;
                    if (resto == 0)
                    {
                        if (saque <= saldo)
                        {
                            if (saldo >= 100)
                            {
                                saldo = saldo - saque;
                                c1.setSaldo(saldo);
                                lblSaldo.Text = Convert.ToString(c1.getSaldo());

                                pic100.Visible = true;
                                resto = saque % 100;
                                cem = saque / 100;
                                lbl100.Text = cem + "x";
                                saque = resto;

                                if (saldo >= 50)
                                {
                                    pic50.Visible = true;
                                    resto = saque % 50;
                                    cinq = saque / 50;
                                    lbl50.Text = cinq + "x";
                                    saque = resto;

                                    if (saldo >= 20)
                                    {
                                        pic20.Visible = true;
                                        resto = saque % 20;
                                        vinte = saque / 20;
                                        lbl20.Text = vinte + "x";
                                        saque = resto;

                                        if (saldo >= 10)
                                        {
                                            pic10.Visible = true;
                                            resto = saque % 10;
                                            dez = saque / 10;
                                            lbl10.Text = dez + "x";
                                            saque = resto;

                                            if (saldo >= 5)
                                            {
                                                pic5.Visible = true;
                                                resto = saque % 5;
                                                cinco = saque / 5;
                                                lbl5.Text = cinco + "x";
                                                saque = resto;
                                            }
                                            else
                                            {
                                                lbl5.Text = "0" + "x";
                                            }
                                        }
                                        else
                                        {
                                            lbl10.Text = "0" + "x";
                                        }
                                    }
                                    else
                                    {
                                        lbl20.Text = "0" + "x";
                                    }
                                }
                                else
                                {
                                    lbl50.Text = "0" + "x";
                                }
                            }
                            else
                            {
                                lbl100.Text = "0" + "x";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Você não tem saldo sulficiente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Apenas valores multiplos de 5!");
                    }
                }
                else
                {
                }

            }
            else if (rbtValorBaixo.Checked == true)
            {
                if (txtSaque.Text != "")
                {
                    saque = Convert.ToInt32(txtSaque.Text);
                    resto = saque % 5;
                    if (resto == 0)
                    {
                        if (saque <= saldo)
                        {
                            if (saldo >= 20)
                            {
                            saldo = saldo - saque;
                            c1.setSaldo(saldo);
                            lblSaldo.Text = Convert.ToString(c1.getSaldo());

                            
                                pic20.Visible = true;
                                resto = saque % 20;
                                vinte = saque / 20;
                                lbl20.Text = vinte + "x";
                                saque = resto;

                                if (saldo >= 10)
                                {
                                    pic10.Visible = true;
                                    resto = saque % 10;
                                    dez = saque / 10;
                                    lbl10.Text = dez + "x";
                                    saque = resto;

                                    if (saldo >= 5)
                                    {
                                        pic5.Visible = true;
                                        resto = saque % 5;
                                        cinco = saque / 5;
                                        lbl5.Text = cinco + "x";
                                        saque = resto;
                                    }
                                    else
                                    {
                                        lbl5.Text = "0" + "x";
                                    }
                                }
                                else
                                {
                                    lbl10.Text = "0" + "x";
                                }
                            }
                            else
                            {
                                lbl20.Text = "0" + "x";
                            }

                        }
                        else
                        {
                            lbl100.Text = " ";
                            lbl50.Text = " ";
                            lbl20.Text = " ";
                            lbl10.Text = " ";
                            lbl5.Text = " ";
                            MessageBox.Show("Você não tem sulficiente");
                        }
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Apenas valores multiplos de 5!");
            }


            if (lbl5.Text == "0x" || lbl5.Text == " ")
            {
                pic5.Visible = false;
                lbl5.Visible = false;
            }
            if (lbl10.Text == "0x" || lbl10.Text == " ")
            {
                pic10.Visible = false;
                lbl10.Visible = false;
            }
            if (lbl20.Text == "0x" || lbl20.Text == " ")
            {
                pic20.Visible = false;
                lbl20.Visible = false;
            }
            if (lbl50.Text == "0x" || lbl50.Text == " ")
            {
                pic50.Visible = false;
                lbl50.Visible = false;
            }
            if (lbl100.Text == "0x" || lbl100.Text == " ")
            {
                pic100.Visible = false;
                lbl100.Visible = false;
            }
            
        }


        private void txtSaque_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Conta_Load(object sender, EventArgs e)
        {

        }

        private void txtSaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!controle.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbl100_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
