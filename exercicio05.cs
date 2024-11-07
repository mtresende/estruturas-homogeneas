using System;
public class exercicio05{
    public static int[] SorteioVetor() {
        Random num = new Random();
        int[] v = new int[5];

        for(int i = 0; i < 5; i++) {
            v[i] = num.Next(10, 31);
        }

        for (int i = 0; i < 5; i++) {
            Console.Write(v[i] + " ");
        }
        Console.WriteLine();
        return v;
    }

    public static void AcertaValor(int[] v) {
        bool numCerto = false;
        while (!numCerto) {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++) {
                if (num == v[i]) {
                    Console.WriteLine("Acertou!");
                    numCerto = true;
                }
            }
            if(!numCerto) Console.WriteLine("Errou!");
        }
    }

    public static void Rodar() {
        int[] vetor = new int[5];
        vetor = SorteioVetor();
        AcertaValor(vetor);
    }
}