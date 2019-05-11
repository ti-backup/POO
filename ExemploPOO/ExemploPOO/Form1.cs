using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            Pessoa aluno = new Pessoa();
            aluno.Nome = "Jão";
            aluno.Nascimento = new DateTime(1981, 11, 22);

            //aluno.Idade = 17;

            String textoIdade;
            if (aluno.Idade == 0)
            {
                textoIdade = "desconhecida";
            }
            else
            {
                textoIdade = aluno.Idade.ToString();
            }

            MessageBox.Show(
                "Aluno" + Environment.NewLine
                + "Nome: " + aluno.Nome + Environment.NewLine
                + "Idade: " + textoIdade + Environment.NewLine
                + "Sexo: " + aluno.Sexo + Environment.NewLine
                + "E-mail: " + aluno.Email
                );
        }
    }
}
