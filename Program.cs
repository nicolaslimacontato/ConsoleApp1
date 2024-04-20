Console.WriteLine("Polimorfismo");
Setor setor = new Setor();
setor.SetorTabela();

Console.WriteLine("Identificação:");

int idSetor;
eqt1:
Console.Write("Digite o Id do setor: ");
if (!int.TryParse(Console.ReadLine(), out idSetor) || idSetor < 1 || idSetor > 3)
{
    Console.WriteLine("Id de setor inválido. Por favor, tente novamente.");
    goto eqt1;
}
eqt2:
Funcionario funcionario = setor.TesteFuncionario(idSetor);
if (funcionario != null)
{
    ControlePonto controlePonto = new ControlePonto();
eqt3:
    Console.Write("Registre o ponto:\n(E) Entrada\n(S) Saída\n");
    string registro = Console.ReadLine().ToUpper();
    if (registro == "E" || registro == "S")
    {
        if (registro == "E")
        {
            controlePonto.RegistraEntrada(funcionario);
        }
        else
        {
            controlePonto.RegistraSaida(funcionario);
        }
    }
    else
    {
        Console.WriteLine("Opção Inválida !");
        goto eqt3;
    }
}
else
{
    Console.WriteLine("Não existe esse id.");
    goto eqt2;
}

Console.WriteLine("Pressione qualquer tecla para encerrar !");
Console.ReadKey();