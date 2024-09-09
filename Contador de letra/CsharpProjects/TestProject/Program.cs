string str = "meu nome é felipe romio.";

// converte a mensagem em um array char
char[] frase = str.ToCharArray();

// Inverte os caracteres
Array.Reverse(frase);
int x = 0;

// conta as letras o's
    foreach (char i in frase) { 
        if (i == 'o') {
             x++; 
             } 
        }

// converte devolta para string
string mensagem = new String(frase);

Console.WriteLine(mensagem);
Console.WriteLine($"A letra 'o' se repete {x} vezes.");