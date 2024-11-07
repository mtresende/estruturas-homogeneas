using System;
public class exercicio04 {
    public static void PreencheVetor(ref int[] v1, ref int[] v2) {
        Random num = new Random();

        for(int i = 0; i < 10; i++) {
            v1[i] = num.Next(1, 100);
            v2[i] = num.Next(1, 100);
        }

        Console.Write("Vetor 1: ");
        for(int i = 0; i < 10; i++) {
            Console.Write(v1[i] + " ");
        }

        Console.Write("\nVetor 2: ");
        for(int i = 0; i < 10; i++) {
            Console.Write(v2[i] + " ");
        }
    }

    public static void GeraVetor(int[] v1, int[] v2) {
        int[] novoVetor = new int[20];
        int indice1 = 0;
        int indice2 = 0;

        Console.Write("\nNovo vetor: ");
        for (int i = 0; i < 20; i++) {
            if (i % 2 != 0) {
                novoVetor[i] = v1[indice1];
                indice1++;
            } else {
                novoVetor[i] = v2[indice2];
                indice2++;
            }

            Console.Write(novoVetor[i] + " ");
        }
    }

    public static void rodar() {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];

        PreencheVetor(ref vetor1, ref vetor2);
        GeraVetor(vetor1, vetor2);
    }
}