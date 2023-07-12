using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;


            usuario = txtUsuario.Text;
            senha = txtUsuario2.Text;

            if (usuario == "Jonatas" && senha == "123")
            {

                MessageBox.Show(" Você se conectou");
                panelSaldo.Visible = true;


            }
            else
            {

                MessageBox.Show(" Está incorreto...");

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
