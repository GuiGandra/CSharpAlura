using System;


class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mes

        //mes1
        //investimento = investimento + investimento * 0.005;
        ////mes 2
        //investimento = investimento + investimento * 0.005;
        ////mes 3
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        int mes = 1;

        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
            
            //mes = mes +1;
            //mes += 1;
            mes++;
        }


        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();
    }
}


