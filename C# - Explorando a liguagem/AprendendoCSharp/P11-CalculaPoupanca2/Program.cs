﻿using System;


class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 10 - Calcula Poupança");

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);

            //mes = mes +1;
            //mes += 1;
            mes++;
        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
        }

        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();
    }
}


