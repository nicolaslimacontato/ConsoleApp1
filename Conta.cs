using System;
using System;


public class Conta
{
    public Conta()
    {
        Saldo = 0.0f;
        Limite = 5000.0f;
    }
    public float Saldo { get; set; }
    public float Limite { get; set; }

    public float Sacar(float valor)
    {
        Saldo -= valor; // Subtrair o valor do saldo
        return Saldo; // Retornar o novo valor do saldo
    }
    public float Depositar(float valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine($"O valor do depósito deve ser maior que zero.");
            return Saldo; // Retornar o saldo atual sem fazer a operação de depósito
        }

        Tarifar();
        Saldo += valor; // Adicionar o valor ao saldo
        return Saldo; // Retornar o novo valor do saldo
    }
    public float Tarifar()
    {
        Saldo -= 0.10f; // Subtrai a tarifa do saldo
        return Saldo; // Retorna o novo valor do saldo após a tarifa
    }
}