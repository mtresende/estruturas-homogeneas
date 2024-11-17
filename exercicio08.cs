using System;
public class exercicio08 {
    public static void PreencheMatriz (ref int[,] m) {
        Random num = new Random();

        for (int l = 0; l < 5; l++){
            Console.WriteLine();
            for (int c = 0; c < 5; c++) {
                m[l, c] = num.Next(10, 100);
                Console.Write(m[l, c] + " ");
            }
        }
    }

    public static int SomaLinha(int[,] m){
        int soma = 0;

        for (int l = 0; l < 5; l++){
            for (int c = 0; c < 5; c++) {
                if (l == 2) {
                    soma += m[l, c];
                }
            }
        }
        
        return soma;
    }

    public static int SomaColuna(int[,] m) {
        int soma = 0;

        for (int l = 0; l < 5; l++){
            for (int c = 0; c < 5; c++) {
                if (c == 1) {
                    soma += m[l, c];
                }
            }
        }

        return soma;
    }

    public static int SomaDiagonalP (int[,] m) {
        int soma = 0;

        for (int i = 0; i < 5; i++) {
            int j = i;
            soma += m[i, j];
        }

        return soma;
    }

    public static int SomaDiagonalS (int[,] m) {
        int soma = 0;
        int c = 0;

        for (int l = 4; l >= 0; l--) {
            soma += m[l, c];
            c ++;
        }

        return soma;
    }

    public static int SomaTotalMatriz (int[,] m) {
        int soma = 0;

        for (int l = 0; l <= 4; l++) {
            for ( int c = 0; c <= 4; c++) {
                soma += m[l, c];
            }
        }

        return soma;
    }

    public static void rodar() {
        int[,] m = new int[5, 5];
        PreencheMatriz(ref m);
        int somaL = SomaLinha(m);
        int somaC = SomaColuna(m);
        int somaDP = SomaDiagonalP(m);
        int somaDS = SomaDiagonalS(m);
        int somaTotal = SomaTotalMatriz(m);

        Console.WriteLine("\nSoma da 3° linha: " + somaL);
        Console.WriteLine("Soma da 2° coluna: " + somaC);
        Console.WriteLine("Soma da diagonal principal: " + somaDP);
        Console.WriteLine("Soma da diagonal secundária: " + somaDS);
        Console.WriteLine("Soma de todos os elementos: " + somaTotal); 
    }
}