using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
           //Comentário in-line(em linha)
           /*
                Comentário in-block(em bloco)
           */
        //declaração da variável. Ela sera do tipo inteira
        int operacao;

        //declaração das variaveis n1 e n2. Elas serão tipo double.
        double n1, n2;

        /*
        Para limpar a tela de comando a cada execução utilizaremos o comando Console.Clear();
        obs.: Clear->Limpar
         */
         Console.Clear();
         Console.WriteLine("Escolha uma das operações abaixo:");
         /*
         Para a exibição das opções de operação, Vamos usar o comando Console.Writeline e, nele usaremos um comando de quebra de linha \n(contra-barra n(new line)). Assim, as opções ficarão uma abaixo da outra
          */
          Console.WriteLine("1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
          operacao = int.Parse(Console.ReadLine());
          
              Console.WriteLine("Digite um numero:");
           n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite outro número:");
           n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
           n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
           n4 = double.Parse(Console.ReadLine());


        }
    }
}
