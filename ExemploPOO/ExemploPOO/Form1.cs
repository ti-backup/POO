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
        List<Pessoa> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Pessoa>();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            Pessoa aluno = new Pessoa();
            aluno.Nome = "Jão";
            aluno.Nascimento = new DateTime(1981, 11, 22);

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Email = txtEmail.Text;
            if (rdoMasculino.Checked)
            {
                p.Sexo = "Masculino";
            }
            else
            {
                p.Sexo = "Feminino";
            }
            p.Nascimento = dtpNascimento.Value;

            lista.Add(p);
            ExibeRegistros();
        }

        private void ExibeRegistros()
        {
            String resultado = "";
            foreach (Pessoa temp in lista)
            {
                resultado += temp.Nome + Environment.NewLine;
            }
            txtResultado.Text = resultado;

            /*
            String resultado = "";
            for (int i = 0; i < lista.Count; i++)
            {
                resultado += lista.ElementAt(i).Nome + Environment.NewLine;
            }
            txtResultado.Text = resultado;
            */
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            String consulta = txtConsulta.Text;
            String resultado = "";
            foreach (Pessoa temp in lista)
            {
                if (temp.Nome.Contains(consulta))
                {
                    resultado += temp.Nome + Environment.NewLine;
                }
            }
            txtResultado.Text = resultado;
        }
    }
}
