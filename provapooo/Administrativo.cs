using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapooo
{
    internal class Administrativo : Funcionario    
    {
        public string funçao { get; set; }

        public Administrativo(string função, string nome, string matricula, DateTime datanascimento, string sexo, double salario)

           : base(nome, matricula, datanascimento, sexo, salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.datanascimento = datanascimento;
            this.sexo = sexo;
            this.salario = salario;

        }
        public Administrativo()
        {

        }
        public override void AdicionarSalario(double valorsalario)
        {
            valorsalario = salario + 150 + (salario * 0.15);

        }
    }
}
