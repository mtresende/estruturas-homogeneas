using System;
public class exercicio10 {
    public static void PreencheMatriz(ref int[,] m) {
        Random num = new Random();
        for (int l = 0; l < 10; l++) {
            Console.WriteLine();
            for (int c = 0; c < 10; c++) {
                m[l, c] = num.Next(10, 99);
                Console.Write(m[l, c] + " ");
            }
        }
    }

    public static void TrocaLinha(int[,] m) {
        int[] linha2 = new int[10];
        int[] linha8 = new int[10];

        for (int c = 0; c < 10; c ++) {
            linha2[c] = m[1, c];
            linha8[c] = m[7, c];
        }

        for (int l = 0; l < 10; l++) {
            m[1, l] = linha8[l];
            m[7, l] = linha2[l];
            Console.WriteLine();
            for (int c = 0; c < 10; c++) {
                Console.Write(m[l, c] + " ");
            }
        }
    }

    public static void TrocaColuna(int[,] m) {
        int[] coluna4 = new int[10];
        int[] coluna10 = new int[10];

        for (int c = 0; c < 10; c++) {
            coluna4[c] = m[c, 3];
            coluna10[c] = m[c, 9];
        }

        for (int i = 0; i < 10; i++) {
            m[i, 3] = coluna10[i];
            m[i, 9] = coluna4[i];
            Console.WriteLine();
            for (int c = 0; c < 10; c++) {
                Console.Write(m[i, c] + " ");
            }
        }
    }

    public static void TrocaDiagonais(int[,] m){
        int[] diagonalP = new int[10];
        int[] diagonalS = new int[10];
        int l = 0, c = 0;

        Console.WriteLine("\n\nDiagonal Secundária: ");
        for(c = 9; c >= 0; c--) {
            diagonalS[l] = m[l, c];
            Console.Write(diagonalS[l] + " ");
            l++;

        }

        Console.WriteLine("\n\nDiagonal Principal: ");
        for(l = 0; l < 10; l++){
            diagonalP[l] = m[l, l];
            Console.Write(diagonalP[l] + " ");
        }

        l = 0;
        for(c = 9; c >= 0; c--) {
            m[l, c] = diagonalP[l];
            l++;
        }

        for(l = 0 ; l < 10; l++){
            m[l, l] = diagonalS[l];
        }

        Console.Write("\n\nDiagonais trocadas: ");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine();
            for (int j = 0; j < 10; j++) {
                Console.Write(m[i, j] + " ");
            }
        }

        
    }

    public static void rodar() {
        int[,] matiz = new int[10, 10];

        Console.Write("Matriz original: ");
        PreencheMatriz(ref matiz);

        Console.Write("\n\nTroca da linha 2 pela linha 8: ");
        TrocaLinha(matiz);

        Console.Write("\n\nTroca da coluna 4 pela coluna 10: ");
        TrocaColuna(matiz);

        TrocaDiagonais(matiz);
    }

}