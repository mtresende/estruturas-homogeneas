using System;
public class exercicio06 {
    public static void TemperaturaOubutro(ref int[] v){
        Random temperatura = new Random();

        for(int i = 0; i < 31; i++) {
            v[i] = temperatura.Next(15, 41);
        } 
    }

    public static double MediaTemperatura(int[] v) {
        double total = 0;

        for(int i = 0; i < 31; i++) {
            total += v[i];
        }

        return total / v.Length;
    }

    public static void rodar() {
        int[] vetor = new int[31];
        int contador = 0, menorT = 41, maiorT = 0; 

        TemperaturaOubutro(ref vetor);
        double media = MediaTemperatura(vetor);

        for(int i = 0; i < 31; i++) {

            if (vetor[i] < menorT) {
                menorT = vetor[i];
            }

            if (vetor[i] > maiorT) {
                maiorT = vetor[i];
            }

            if (vetor[i] < media) {
                contador++;
            }
        }

        Console.WriteLine("Maior temperatura: {0}\nMenor temperatura: {1}", maiorT, menorT);
        Console.WriteLine("Temperatura média: {0:F2}", media);
        Console.WriteLine("Dias abaixo da temperatura média: " + contador);
    }
}