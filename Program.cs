// Boletim 2.0 - obter nome do aluno, quantidade de notas e cada uma das notas.
// Depois, calcular a média dos alunos e informar se foi aprovado, ficou em recuperação ou reprovado.
float media = 0;
string nomeAluno;
int quantidadeNotas;
float soma = 0;

Console.WriteLine("Olá! Vamos descobrir se o aluno foi aprovado, reprovado ou ficou de recuperação na disciplina!");
Console.WriteLine("Digite o nome do aluno:");
nomeAluno = Console.ReadLine();
Console.WriteLine("Digite a quantidade de notas para compor a média:");
quantidadeNotas = int.Parse(Console.ReadLine());
float[] notas = new float[quantidadeNotas];
for (int i = 0; i < quantidadeNotas; i++){
    Console.WriteLine("Digite a " + (i+1) + "ª nota:");
    notas[i] = float.Parse(Console.ReadLine());
}
for (int i = 0; i < quantidadeNotas; i++){
    soma += notas[i];    
}

media = (soma / quantidadeNotas);
Console.WriteLine("Aluno: " + nomeAluno);

if(media >= 6){
    for (int i = 0; i < quantidadeNotas; i++){
        Console.WriteLine("N" + (i+1) + ": " + notas[i]);
    }
    Console.WriteLine($"Média: {media.ToString("N")} - Aprovado!!");
}
else if (media < 6 && media >= 5){
    for (int i = 0; i < quantidadeNotas; i++){
        Console.WriteLine("N" + (i+1) + ": " + notas[i]);
    }
    Console.WriteLine($"Média: {media.ToString("N")} - Em recuperação.");        
}   
else{
    for (int i = 0; i < quantidadeNotas; i++){
        Console.WriteLine("N" + (i+1) + ": " + notas[i]);
    }
    Console.WriteLine($"Média: {media.ToString("N")} - Reprovado."); 
}        
