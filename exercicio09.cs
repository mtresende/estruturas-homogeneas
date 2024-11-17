using System;
public class exercicio09 {
    public static int[,] MatrizTransposta (int[,] m) {
        int[,] novaMatriz = new int[3, 3];
        for (int l = 0; l < 3; l ++) {
            for (int c = 0; c < 3; c ++) {
                novaMatriz[l, c] = m[c, l];
            }
        }
        return novaMatriz;
    }

    public static void rodar(){
        int[,] matrizA = new int[3, 3];
        Random n = new Random();

        Console.Write("Matriz A:");
        for (int l = 0; l < 3; l++) {
            Console.WriteLine();
            for (int c = 0; c < 3; c++) {
                matrizA[l, c] = n.Next(10, 99);
                Console.Write(matrizA[l, c] + " ");
            }
        }
        
        int[,] matrizAT = MatrizTransposta(matrizA);

        Console.Write("\n\nMatriz AT:");
        for (int l = 0; l < 3; l++) {
            Console.WriteLine();
            for (int c = 0; c < 3; c++) {
                Console.Write(matrizAT[l, c] + " ");
            }
        }
    }
}