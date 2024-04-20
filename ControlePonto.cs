public class ControlePonto
{
    public void RegistraEntrada(Funcionario f)
    {
        DateTime agora = DateTime.Now;
        Console.WriteLine($"Data e Hora do registro de ENTRADA: {agora}\nFuncionário: {f.NomeFuncionario}\nCódigo Funcionário: {f.IdFuncionario}\nSetor: {f.NomeSetor}\nCargo: {f.CargoFuncionario}\nBom Trabalho !");
    }

    public void RegistraSaida(Funcionario f)
    {
        DateTime agora = DateTime.Now;
        Console.WriteLine($"Data e Hora do registro de SAÍDA: {agora}\nFuncionário: {f.NomeFuncionario}\nCódigo Funcionário: {f.IdFuncionario}\nSetor: {f.NomeSetor}\nCargo: {f.CargoFuncionario}\nBom Descanso !");
    }
}