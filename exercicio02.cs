using System;
public class exercicio02{
    public static void PreencheVetor(ref int[] vetor) {
        for(int i = 0; i < 10; i++) {
            Console.Write("Digite a nota do " + (i + 1) + "° aluno: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    public static void CalculaMedia(int[] vetor) {
        int totalNotas = 0, aprovados = 0;
        for(int i = 0; i < 10; i++) {
            totalNotas += vetor[i];

            if (vetor[i] >= 6) {
                aprovados++;
            }
        }

        Console.WriteLine("Média das notas: {0:f2}", (double)totalNotas / vetor.Length);
        Console.WriteLine("Alunos aprovados: " + aprovados);
    }

    public static void rodar() {
        int[] notasAlunos = new int[10];
        PreencheVetor(ref notasAlunos);
        CalculaMedia(notasAlunos);
    }
}