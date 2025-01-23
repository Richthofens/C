using System;
using System.Collections.Generic;

public class Bank
{
    public readonly List<string> b_Names = new List<string>();

    public void AddName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            b_Names.Add(name);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Conta {name} criada com sucesso!\n");
            Console.ResetColor();
        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nome Inválido. Tente Novamente.\n");
            Console.ResetColor();
        }
    }

    public void RemName(string name)
    {
        if (b_Names.Remove(name))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Conta {name} Removida com sucesso!\n");
            Console.ResetColor();
        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Conta '{name}' Não encontrada.\n");
            Console.ResetColor();
        }
        
    }
}



class Principal
{
    public static void AddConta(Bank bank)
    {
        Console.WriteLine("\nDigite o nome para criar uma conta");
        bool sair = true;

        while (sair)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine() ?? "";
            bank.AddName(name);

            Console.Write("Deseja sair: ");
            string opcao = Console.ReadLine() ?? "";

            if (opcao.ToUpper().Equals("S"))
            {  
                sair = false;
                Console.WriteLine("saindo...\n");
            }

        }


    }

    public static void RemoveAccount(Bank bank)
    {
        Console.Write("Digite o nome da conta a ser removida\n");
        string name = Console.ReadLine() ?? "0";
        bank.RemName(name);
    }

    public static void PrintNames(Bank bank)
    {        
        foreach (string name in bank.b_Names)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name);
        }
        Console.ResetColor();
        Console.WriteLine("\n");
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank();

        while (true)
        {
            Console.WriteLine("__Banco__");
            Console.WriteLine("1 - criar conta");
            Console.WriteLine("2 - apagar conta");
            Console.WriteLine("3 - ver contas");

            Console.Write("Escolha: ");
            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\nOpção 1");
                    Principal.AddConta(bank);
                    break;

                case "2":
                    Console.WriteLine("\nOpção 2");
                    Principal.RemoveAccount(bank);
                    break;

                case "3":
                    Console.WriteLine("\nOpção 3");
                    Principal.PrintNames(bank);
                    break;
                
                default:
                    Console.Write("sim");
                    break;
            }
        }
    }
}