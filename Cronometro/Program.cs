// Cronômetro (Stopwath)

using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar: ");

            // Recuperar um valor digitado pelo usuário:
            // Trará o valor digitado e converte para minúsculo.
            // Temos que isolar o tempo (só o s ou só o m), pega-se o último digito usando:
            // Substring.

            string data = Console.ReadLine().ToLower(); // data = dados digitados
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // pega uma parte de nossa
                                                                        // cadeia de caracteres, aqui
                                                                        // pegou o último caracter digitado
            int time = int.Parse(data.Substring(0, data.Length - 1)); //aqui eu pego todos caracteres, menos 1
            //Console.WriteLine(data);
            //Console.WriteLine(type);
            //Console.WriteLine(time);

            // Definir o tempo que vai contar. A base será sempre em segundos.
            // Só mudará o multiplicador. É o tempo x segundo.

            int multiplier = 1; // equivale 1 minuto a 60 segundos.

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (type == 0) ;
            {
                System.Environment.Exit(0);
            }
            Start(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.Write("Ready...");
            Thread.Sleep(1000);
            Console.Write("Set...");
            Thread.Sleep(1000);
            Console.Write("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        public static void Start(int time) // Função Start dispara nosso cronômetro.
        {
            int currentTime = 0;

            // ele sempre executa algo dada uma condição - ela tem que passar - ser true.
            // Deve ter um incremento nesta função. Queremos percorrer de 0 até n.
            // enquanto o tempo atual for diferente do que se quer contar (n),
            // ele executa essa função. (currentTime = tempo atual)

            while (currentTime != time) //while trabalha alinhado ao clock do computador.
            {
                Console.Clear();
                currentTime++; // se não fica em loop infinito.
                Console.WriteLine(currentTime); // exibe o tempo atual
                Thread.Sleep(1000);// dormir por 1 segundo.
            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);// dormir para voltar ao menu
            Menu();

        }
    }
}


// Não foi realizado neste momento os tratamentos de erros.
