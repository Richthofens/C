using System;
// class Program
// {
//     public readonly int valor;

//     Program(int v)
//     {
//         valor = v;
//     }

//     public static void Main()
//     {
//         Console.Write("...: ");
//         int val = int.Parse(Console.ReadLine());
//         var a = new Program(val);

//         Console.Write($"Valor final: {a.valor}");
//     }
// }


public class Bank
{
    List<int> m_Banks = new List<int>();
    List<string> m_BanksName = new List<string>();
    
    public Bank()
    {
        for (int i = 0; i <= 0; i++) {Console.Write("Nome: "); string nome = Console.ReadLine(); m_BanksName.Add(nome);}
    }

    static void Main(string[] args)
    {
        Bank bank = new Bank();
    }
}
