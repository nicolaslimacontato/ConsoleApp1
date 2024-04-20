public class Funcionario
{
    public Funcionario(string nome, int id, string cargo, string setor)
    {
        NomeFuncionario = nome;
        IdFuncionario = id;
        CargoFuncionario = cargo;
        NomeSetor = setor;
    }
    public int IdFuncionario { get; }
    public string NomeFuncionario { get; }
    public string CargoFuncionario { get; }
    public string NomeSetor { get; }
}