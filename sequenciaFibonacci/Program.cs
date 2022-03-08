using System;

namespace sequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, posicaoDeParada, primeiroNumero, segundoNumero, somaDosNumeros;
            //Cinco variáveis do tipo inteiro i para percorrer o laço,
            //posicaoDeParada para indicar até onde o laço irá percorrer,
            //primeiroNumero da sequência de Fibonacci,
            //segundoNumero da sequência de Fibonacci,
            //somaDosNumeros para indicar a soma dos números da sequência

            Console.WriteLine("Por favor, Insiria posição de parada da sequência de Fibonacci: ");//Linha para pedir para inserir até onde o laço de repetição irá percorrer
            posicaoDeParada = Convert.ToInt32(Console.ReadLine());//A variável posiçãoDeParada recebe até o onde o laço de repetição irá percorrer
            primeiroNumero = 0;//Primeiro número recebe 0
            segundoNumero = 1;//Segundo número recebe 1
            for (i = 0; i < posicaoDeParada; i++)//Laço de repetição vai de 0 até posição de parada
            {
                Console.WriteLine($"O número {primeiroNumero}, está na posição {i + 1}");//É impresso o primeiroNumero pois ele inicia da posição 0
                somaDosNumeros = primeiroNumero + segundoNumero;//somaDosNumeros recebe primeiroNumero + segundoNumero
                primeiroNumero = segundoNumero;//primeiroNumero recebe segundoNumero
                segundoNumero = somaDosNumeros;//segundoNumero recebe a somaDosNumeros
            }
        }
    }
}
