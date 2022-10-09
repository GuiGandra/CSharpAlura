using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 8 - Condicionais2");

        int idadeJoa = 12;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;  

        if (idadeJoa >= 18 || acompanhado)
        {
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            Console.WriteLine("Só pode entrar maior de idade ou Acompanhado");
        }

        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();
    }
}


