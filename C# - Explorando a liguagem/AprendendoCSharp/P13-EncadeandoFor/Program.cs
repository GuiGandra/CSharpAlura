using System;


class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 13 - Ecadendo FOR");

        //*
        //**
        //***
        //****
        //*****

        // Com If e Break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("Guilherme");
                if(contadorColuna >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }


        // Sem If e Break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinhas; contadorColuna++)
            {
                Console.Write("Gandra");
            }
            Console.WriteLine();
        }

        //   EXERCICIO
        //for (int n = 1; n < 100; n++)
        //{
        //    if (n % 3 == 0)
        //    {
        //        Console.WriteLine(n);
        //    }
        //}

        //int fatorial = 1;
        //for (int i = 1; i < 11; i++)
        //{
        //    fatorial *= i;
        //    Console.WriteLine("O Fatorial de " + i + " = " + fatorial);
        //}

        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();
    }
}


