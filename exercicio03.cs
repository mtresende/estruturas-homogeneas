using System;
public class exercicio03 {
    public static void PreencheVetor(int n) {
        int[] vetor = new int[n];
        int menor = 0;

        for (int i = 0; i < n; i++) {
            Console.Write("Digite o " + (i + 1) + "° valor do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());

            if (i >= 1) {
                if (vetor[i] < vetor[i - 1]) menor = i;
            }
        }

        Console.WriteLine("O menor elemento desse vetor está na posição: " + menor);
    }

    public static void rodar() {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        PreencheVetor(n);
    }
}