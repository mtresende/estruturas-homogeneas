using System;
public class exercicio01 {
    public static void criaVetor(ref int[] vetor) {
        Random aleatorio = new Random();

        for (int i = 0; i < 15; i++) {
            vetor[i] = aleatorio.Next(0, 99);
        }

        Console.Write("Vetor 1°: ");
        for (int i = 0; i < 15; i++)
            Console.Write(vetor[i] + " ");
    }

    public static int[] novoVetor(int[] newVetor) {
        int[] vetorAtualizado = new int[8];
        int j = 0;
        
        for (int i = 0; i < 15; i++) {
            if (i % 2 == 0) {
                vetorAtualizado[j] = newVetor[i];
                j++;
            }
        }

        return vetorAtualizado;
    }

    public static void rodar() {
        int[] vetor = new int[15];

        criaVetor(ref vetor);

        int [] vetor2 = novoVetor(vetor);

        Console.Write("\nVetor 2°: ");
        for (int i = 0; i < 8; i++)
            Console.Write(vetor2[i] + " ");
    }
}