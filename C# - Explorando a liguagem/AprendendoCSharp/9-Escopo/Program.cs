using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 9 - Escopo");

        int idadeJoa = 12;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João esta acompanhado";
        }
        else
        {
            textoAdicional = "João não esta acompanhado";
        }

        if (idadeJoa >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            Console.WriteLine("Só pode entrar maior de idade");
        }

        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();


        //Treino
        //double salario = 3300.0;

        //if (salario >= 1900.0 && salario <= 2800.0)
        //{
        //    Console.WriteLine("o IR é de 7.5%");
        //    Console.WriteLine("pode deduzir na declaração o valor de R$ 142");
        //}
        //if (salario >= 2800.01 && salario <= 3751.0)
        //{
        //    Console.WriteLine("o IR é de 15%");
        //    Console.WriteLine("pode deduzir R$ 350");
        //}
        //else if (salario >= 3751.01 && salario <= 4664.0)
        //{
        //    Console.WriteLine("o IR é de 22.5% ");
        //    Console.WriteLine("pode deduzir R$ 636");
        //}

           //    ULTILIZAÇÃO DE SWITCH
            //int mes = 10;

            //switch (mes)
            //{
            //    case 1:
            //        Console.WriteLine("O mês é Janeiro");
            //        break;
            //    case 2:
            //        Console.WriteLine("O mês é Fevereiro");
            //        break;
            //    case 3:
            //        Console.WriteLine("O mês é Março");
            //        break;
            //    case 4:
            //        Console.WriteLine("O mês é Abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("O mês é Maio");
            //        break;
            //    case 6:
            //        Console.WriteLine("O mês é Junho");
            //        break;
            //    case 7:
            //        Console.WriteLine("O mês é Julho");
            //        break;
            //    case 8:
            //        Console.WriteLine("O mês é Agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("O mês é Setembro");
            //        break;
            //    case 10:
            //        Console.WriteLine("O mês é Outubro");
            //        break;
            //    case 11:
            //        Console.WriteLine("O mês é Novembro");
            //        break;
            //    case 12:
            //        Console.WriteLine("O mês é Dezembro");
            //        break;
            //    default:
            //        Console.WriteLine("Mês inválido");
            //        break;
            //}
            //Console.ReadLine();
        }
    }




