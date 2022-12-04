using DesignPatternStrategy.BeforeStrategy;

public static class Program
{

    static void Main()
    {
        Inicio:
        Console.WriteLine("Para o Etendimento Fazer o Teste Antes do Strategy Aperte 1");
        Console.WriteLine("Para o Etendimento Fazer o Teste Pós Implementação do Strategy Aperte 2");
        var opcao = Console.ReadLine();
        if (int.Parse(opcao) == 1)
            BeforeStrategy();
        else if (int.Parse(opcao) == 2)
            AfterTheStrategy();
        else
        {
            Console.WriteLine("Opção Inválida");
            Console.ReadLine();
            Console.Clear();
            goto Inicio;
        }
    }

    static void BeforeStrategy()
    {
        Paciente paciente = new Paciente();

        Console.WriteLine("Por Favor, Informe o Nome do Paciente");
        paciente.Nome = Console.ReadLine();

        Console.WriteLine("Por Favor, Informe a Altura do Paciente");
        paciente.Altura = float.Parse(Console.ReadLine());

        Console.WriteLine("Por Favor, Informe o Peso do Paciente");
        paciente.Peso = float.Parse(Console.ReadLine());

        var imc = paciente.CalcularImc();
        Console.WriteLine($"O I.M.C do Paciente {paciente.Nome} é de {imc}");

        OpcaoPaciente:
        Console.WriteLine($"Deseja fazer o que com o Paciente {paciente.Nome} 1 - Prescerever Dieta; 2 - Prescrever Treinamento; 3 - Encaminhar Para Cirurgia Bariátrica");
        var opcao = Console.ReadLine();

        if (int.Parse(opcao) == 1)
        {
            Console.WriteLine("Informe a Dieta do Cliente");
            var dieta = Console.ReadLine();
            paciente.PrescreverDieta(dieta);
        }
        else if (int.Parse(opcao) == 2)
        {
            Console.WriteLine("Informe o Treino do Cliente");
            var treinamento = Console.ReadLine();
            paciente.PrescreverTreinamento(treinamento);
        }
        else if (int.Parse(opcao) == 3)
            paciente.EncaminharParaCirurgiaBariatrica();
        else
        {
            Console.WriteLine("Opção Inválida");
            Console.ReadLine();
            goto OpcaoPaciente;
        }
    }

    static void AfterTheStrategy()
    {

    }

}

