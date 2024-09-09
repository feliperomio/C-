// Inicializar variáveis - atribuições avaliadas
int quantidadeAtividades = 5;

int[] notasSophia = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] notasAndrew = new int[] { 92, 89, 81, 96, 90, 89 };
int[] notasEmma = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] notasLogan = new int[] { 90, 95, 87, 88, 96, 96 };

// Nomes dos alunos
string[] nomesAlunos = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] notasAlunos = new int[10];

string letraNotaAtual = "";

// Escrever o cabeçalho do relatório no console
Console.WriteLine("Aluno\t\tNota\n");

foreach (string nome in nomesAlunos)
{
    string alunoAtual = nome;

    if (alunoAtual == "Sophia")
       notasAlunos = notasSophia;

    else if (alunoAtual == "Andrew")
        notasAlunos = notasAndrew;

    else if (alunoAtual == "Emma")
        notasAlunos = notasEmma;

    else if (alunoAtual == "Logan")
        notasAlunos = notasLogan;

    // Inicializar/resetar a soma das notas das atividades
    int somaNotasAtividades = 0;

    // Inicializar/resetar a média calculada das notas das provas + pontos extras
    decimal notaAlunoAtual = 0;

    // Inicializar/resetar um contador para a quantidade de atividades avaliadas
    int atividadesAvaliadas = 0;

    // Percorrer o array de notas e realizar cálculos para o alunoAtual
    foreach (int nota in notasAlunos)
    {
        // Incrementar o contador de atividades
        atividadesAvaliadas += 1;

        if (atividadesAvaliadas <= quantidadeAtividades)
            // Adicionar a nota da prova à soma
            somaNotasAtividades += nota;

        else
            // Adicionar os pontos extras à soma - pontos de bônus equivalentes a 10% da nota da prova
            somaNotasAtividades += nota / 10;
    }

    notaAlunoAtual = (decimal)(somaNotasAtividades) / quantidadeAtividades;

    if (notaAlunoAtual >= 97)
        letraNotaAtual = "A+";

    else if (notaAlunoAtual >= 93)
        letraNotaAtual = "A";

    else if (notaAlunoAtual >= 90)
        letraNotaAtual = "A-";

    else if (notaAlunoAtual >= 87)
        letraNotaAtual = "B+";

    else if (notaAlunoAtual >= 83)
        letraNotaAtual = "B";

    else if (notaAlunoAtual >= 80)
        letraNotaAtual = "B-";

    else if (notaAlunoAtual >= 77)
        letraNotaAtual = "C+";

    else if (notaAlunoAtual >= 73)
        letraNotaAtual = "C";

    else if (notaAlunoAtual >= 70)
        letraNotaAtual = "C-";

    else if (notaAlunoAtual >= 67)
        letraNotaAtual = "D+";

    else if (notaAlunoAtual >= 63)
        letraNotaAtual = "D";

    else if (notaAlunoAtual >= 60)
        letraNotaAtual = "D-";

    else
        letraNotaAtual = "F";

    Console.WriteLine($"{alunoAtual}\t\t{notaAlunoAtual}\t{letraNotaAtual}");
}

// Necessário para executar no VS Code (mantém a janela de Saída aberta para visualizar os resultados)
Console.WriteLine("\n\rPressione a tecla Enter para continuar");
Console.ReadLine();