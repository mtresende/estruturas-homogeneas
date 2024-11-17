using System;
public class exercicio07 {
    public static void PreencheMatriz(ref int[,] m) {
        Random valor = new Random();

        for(int l = 0; l < 3; l++) {
            Console.WriteLine();
            for (int c = 0; c < 3; c++) {
                m[l, c] = valor.Next(1, 100);
                Console.Write(m[l, c] + " ");
            }
        }
    }

    public static bool RetornaPrimos(int n) {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++){
            if (n % i == 0)
                return false;
        }

        return true;
    }

    public static void rodar() {
        int[,] matriz = new int[3, 3];
        PreencheMatriz(ref matriz);

        Console.WriteLine();
        
        for(int l = 0; l < 3; l++) {
            for (int c = 0; c < 3; c++){
                int num = matriz[l, c];
                if (RetornaPrimos(num)){
                    Console.WriteLine("Número primo na posição: {0}, {1}", l, c);
                }
            }
        }
    }
}