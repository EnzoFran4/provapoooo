using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapooo
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public string matricula { get; set; }
        public DateTime datanascimento { get; set; }
        public string sexo { get; set; }
        public double salario { get; set; }

        public Funcionario(string nome, string matricula, DateTime datanascimento, string sexo, double salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.datanascimento = datanascimento;
            this.sexo = sexo;
            this.salario = salario;
        }
        public Funcionario()
        {

        }
        public virtual void AdicionarSalario(double valorsalario)
        {
            valorsalario = salario;


        }
    }
}
