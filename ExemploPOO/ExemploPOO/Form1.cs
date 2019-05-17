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
            ExibeRegistros("");
        }

        private void ExibeRegistros(String consulta)
        {
            // EXIBE RESULTADO NO TEXTBOX
            String resultado = "Nome\tE-mail\tNascimento\tIdade\tSexo" + Environment.NewLine;
            foreach (Pessoa temp in lista)
            {
                if (temp.Nome.Contains(consulta))
                {
                    resultado += temp.Nome
                        + "\t" + temp.Email
                        + "\t" + temp.Nascimento.ToShortDateString()
                        + "\t" + temp.Idade
                        + "\t" + temp.Sexo
                        + Environment.NewLine;
                }
            }
            txtResultado.Text = resultado;

            // EXIBE RESULTADO NO DATAGRIDVIEW
            dgvResultado.DataSource = null;
            dgvResultado.DataSource = lista;
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            ExibeRegistros(txtConsulta.Text);
        }
    }
}
