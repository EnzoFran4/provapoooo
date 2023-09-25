using provapooo;


while (true)
{

    Console.WriteLine("Qual tipo de funcionário deseja cadastrar?");

    Console.WriteLine("1 - Médico");
    Console.WriteLine("2 - Administrativo");
    Console.WriteLine("3 - Comum");
    Console.WriteLine("4 - Sair");
    int opção = Convert.ToInt32(Console.ReadLine());
    

    if (opção == 1)
    {
        Medico c = new Medico();
        List<Medico> list = new List<Medico>();
        double periculosidade = 200;


        Console.WriteLine("Escreva o nome:");
           string nome = Console.ReadLine();
            Console.WriteLine("Escreva a matricula:");
            string matricula = Console.ReadLine();
            Console.WriteLine("Escreva a data de nascimento:");
            DateTime datanascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Escreva o sexo");
            string sexo = Console.ReadLine();
            Console.WriteLine("Escreva o CRM");
            string crm = Console.ReadLine();
            Console.WriteLine("Escreva o salario");
           double salario = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Escreva o valor da hora extra:");
          double horaextra = Convert.ToDouble(Console.ReadLine());
        c.AdicionarSalario(salario);
        
        

            
            

            Console.WriteLine("Funcionário cadastrado!");
            
            list.Add(c);
           
            
            




        
    }
    if (opção == 2)
    {
        Administrativo c = new Administrativo();

        
            Console.WriteLine("Escreva o nome:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Escreva a matricula:");
            string matricula = Console.ReadLine();
            Console.WriteLine("Escreva a data de nascimento:");
            DateTime datanascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Escreva o sexo:");
            string sexo = Console.ReadLine();
            Console.WriteLine("Escreva a função:");
            string funçao = Console.ReadLine();
            Console.WriteLine("Escreva o salario:");
            double salario = Convert.ToDouble(Console.ReadLine());
             c.AdicionarSalario(salario);
           

           List<Administrativo> administrativos = new List<Administrativo>();
            administrativos.Add(c);
          
        
    }
    if(opção == 3)
    {
        Funcionario c = new Funcionario();
        Console.WriteLine("Escreva o nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Escreva a matricula:");
        string matricula = Console.ReadLine();
        Console.WriteLine("Escreva a data de nascimento:");
        DateTime datanascimento = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Escreva o sexo:");
        string sexo = Console.ReadLine();
        Console.WriteLine("Escreva o salario:");
        double salario = Convert.ToDouble(Console.ReadLine());

        List<Funcionario> funcionario = new List<Funcionario>();
        funcionario.Add(c); 

    }
    if(opção == 4)
    {
        break;
    }
}

