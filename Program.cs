string[] alunos = new string[10];
decimal [] nota = new decimal[4];
decimal[] media = new decimal[10]; 

for (int indice = 0; indice < alunos.Length; indice++)
{
    Console.WriteLine("Qual o nome do aluno(a)?");
    alunos[indice] = Console.ReadLine();

    for (int index = 0; index < nota.Length; index++)
    { 
        Console.WriteLine("Qual a nota?");
        nota[index] = decimal.Parse(Console.ReadLine());

    }

    Console.Clear();

    media[indice] = nota[0] + nota[1] + nota[2] + nota[3] / 4;
}

Console.WriteLine("Média dos alunos");

for (int indice = 0; indice < alunos.Length; indice++)
{
    Console.WriteLine($"{alunos[indice]}:{media[indice]}");
}