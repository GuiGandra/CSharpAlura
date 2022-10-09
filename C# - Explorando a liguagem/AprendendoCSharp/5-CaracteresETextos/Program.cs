using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 5 - Caracteres e Texto");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(21+ 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Curso de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos Disponiveis:
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle Enter pra Finalizar");
        Console.ReadLine();
    }
}