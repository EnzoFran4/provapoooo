using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapooo
{
    internal class Medico : Funcionario
    {
        public string crm { get; set; }
        public string especialidade { get; set; }
        public double horaextra { get; set; }
        public double periculosidade { get; set; }

        public Medico(string crm,string especialidade, double horaextra, double periculosidade, string nome, string matricula, DateTime datanascimento, string sexo, double salario)
            : base(nome, matricula, datanascimento, sexo, salario)
        {
            this.crm = crm;
            this.horaextra = horaextra;
            this.periculosidade = periculosidade;
            this.especialidade = especialidade;
        }
        public Medico()
        {

        }
        public override void AdicionarSalario(double valorsalario)
        {
           valorsalario = salario + (salario * 0.20);
            

        }
    }
}
