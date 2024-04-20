public class Setor
{
    private List<Funcionario> funcionariosAdministrativo;
    private List<Funcionario> funcionariosProducao;
    private List<Funcionario> funcionariosComercial;

    public Setor()
    {
        funcionariosAdministrativo = new List<Funcionario>
        {
            new Funcionario("Saphira", 1, "     Diretora", "Administrativo"),
            new Funcionario("Samael", 2, "     Gerente", "Administrativo")
        };

        funcionariosProducao = new List<Funcionario>
        {
            new Funcionario("Aquiel", 3, "        Coordenador", "Produção"),
            new Funcionario("Inférnia", 4, "Encarregada", "Produção")
        };

        funcionariosComercial = new List<Funcionario>
        {
            new Funcionario("Jaburú", 5, "        Vendedor", "Comercial"),
            new Funcionario("Dasdores", 6, "Compradora", "Comercial")
        };
    }

    public void SetorTabela()
    {
        Console.WriteLine("Id Setor\tNome Setor");
        Console.WriteLine("   1\t\tAdministrativo");
        Console.WriteLine("   2\t\tProdução");
        Console.WriteLine("   3\t\tComercial");
    }

    public Funcionario TesteFuncionario(int idSetor)
    {
        List<Funcionario> funcionarios;
        switch (idSetor)
        {
            case 1:
                funcionarios = funcionariosAdministrativo;
                Console.WriteLine("\nFuncionários do Setor Administrativo:\n");
                break;
            case 2:
                funcionarios = funcionariosProducao;
                Console.WriteLine("\nFuncionários do Setor Produção:\n");
                break;
            case 3:
                funcionarios = funcionariosComercial;
                Console.WriteLine("\nFuncionários do Setor Comercial:\n");
                break;
            default:
                return null;
        }

        
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"{funcionario.IdFuncionario}\t{funcionario.NomeFuncionario}\t{funcionario.CargoFuncionario}");
        }
        Console.WriteLine();
        Console.Write("Digite o ID do funcionário: ");
        if (int.TryParse(Console.ReadLine(), out int idFuncionario))
        {
            foreach (var funcionario in funcionarios)
            {
                if (funcionario.IdFuncionario == idFuncionario)
                {
                    return funcionario;
                }
            }
        }

        return null;
    }
}