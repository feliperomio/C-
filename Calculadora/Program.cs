using System;

class Program{

    static void Main(string[] args) {
        double resultado;


        Console.WriteLine("Calculadora \n");

        Console.WriteLine("Informe o primeiro número: ");
        double primeiroNumero = Double.Parse(Console.ReadLine());
     

        Console.WriteLine("Informa a operação desejada: ");
        string op = Console.ReadLine();

        Console.WriteLine("Informe o segundo número: ");
        double segundoNumero = Double.Parse(Console.ReadLine()); ;

        switch (op)
        {
            case "-":
                resultado = primeiroNumero - segundoNumero;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case "+":
                resultado = primeiroNumero + segundoNumero;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case "*":
                resultado = primeiroNumero * segundoNumero;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case "/":
                resultado = primeiroNumero / segundoNumero;
                Console.WriteLine("Resultado: " + resultado);
                break;

        }

    }
}