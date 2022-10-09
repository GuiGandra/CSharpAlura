using System;


class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("4 - Conversões e Outros Tipos");

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // long é variavel de 64-bits
        long x = 2000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);


        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();
    }
}


