using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    class Pessoa
    {
        private String _nome;

        public String Nome {
            set { _nome = value.ToUpper(); }
            get { return _nome; }
        }

        private DateTime _nascimento; 
        public DateTime Nascimento {
            set {
                _nascimento = value;
                CalculaIdade();
            }
            get { return _nascimento; }
        }

        public Byte Idade { private set; get; }
        public String Sexo { set; get; }
        public String Email { set; get; }

        public Pessoa()
        {
            Nome = "desconhecido";
            Idade = 0;
            Sexo = "desconhecido";
        }

        private void CalculaIdade()
        {
            DateTime hoje = DateTime.Now;
            Idade = Convert.ToByte((hoje.Year - Nascimento.Year));

            if (
                (hoje.Month < Nascimento.Month)
                ||
                (hoje.Month == Nascimento.Month && hoje.Day < Nascimento.Day)
                )
            {
                Idade--;
            }

            /*
            if (hoje.Month <= Nascimento.Month)
            {
                if (hoje.Month == Nascimento.Month)
                {
                    if (hoje.Day < Nascimento.Day)
                    {
                        Idade--;
                    }
                }
                else
                {
                    Idade--;
                }
            }
            */
        }
    }
}
