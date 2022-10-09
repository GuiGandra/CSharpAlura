using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeJoa = 12;
        int quantidadePessoas = 2;

        if (idadeJoa >= 18)
        {
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Pode entrar por estar acompanhado");
            }
            else
            {
                Console.WriteLine("Só pode entrar maior de idade ou Acompanhado");
            }

        }

        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();
    }
}


