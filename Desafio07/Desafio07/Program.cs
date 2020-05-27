using System;
using System.Collections.Generic;

namespace Desafio07
{
    class Program
    {
        private const int MAX_TENTATIVAS = 7;
        private const char CONTINUAR = 'S';

        private static List<Enigma> lista = new List<Enigma>();
        private static Enigma enigma;
        private static string tracos;
        private static string letrasUtilizadas;
        private static string resposta;
        private static string palavra;
        private static char continua;

        static void Main(string[] args)
        {
            PreencheLista();
            continua = 's';

            while (Char.ToUpper(continua) == CONTINUAR)
            {
                InicializaVariaveis();

                for (int tentativa = 1; tentativa <= MAX_TENTATIVAS; tentativa++)
                {
                    AtualizaTela(tentativa);
                    resposta = Console.ReadLine();

                    if (resposta.EhUmaLetra())
                        AtualizaPalavra();
                    else
                    {
                        if (resposta.Equals(enigma.Resposta))
                        {
                            Console.WriteLine("Resposta correta!");
                            break;
                        }
                        else
                            Console.WriteLine("Resposta incorreta!");
                    }

                    Console.Clear();
                }

                Console.Write("Deseja continuara a jogar? (S/N): ");
                continua = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }

        private static void PreencheLista()
        {
            lista.Add(new Enigma { Resposta = "Piramide de Gize", Dica = "Uma das sete maravilhas do mundo antigo" });
            lista.Add(new Enigma { Resposta = "Midoriya Izuku", Dica = "Principal personagem de Boku no Hero Academia" });
            lista.Add(new Enigma { Resposta = "Sweet Child O'Mine", Dica = "Música mais conhecida da banda Guns N' Roses" });
            lista.Add(new Enigma { Resposta = "Sociedade do Anel", Dica = "Primeira parte de O Senhor dos Anéis" });
            lista.Add(new Enigma { Resposta = "V de Vinganca", Dica = "Filme baseado em uma hq de Alan Moore" });
            lista.Add(new Enigma { Resposta = "Jovem Nerd", Dica = "Melhor canal nerd do Youtube" });
            lista.Add(new Enigma { Resposta = "Steve Jobs", Dica = "Um dos fundadores da Apple" });
            lista.Add(new Enigma { Resposta = "Bleach", Dica = "Nome do anime em que os shinigamis portam espadas" });
            lista.Add(new Enigma { Resposta = "Joker", Dica = "Principal vilão do Batman" });
            lista.Add(new Enigma { Resposta = "Ennio Morricone", Dica = "Compositor da trilha mais famosa de velho-oeste" });
        }

        static void InicializaVariaveis()
        {
            enigma = GetEnigmaAleatorio();
            tracos = GetTracos();
            letrasUtilizadas = "";
            resposta = "-";
            palavra = "";
            palavra = palavra.PadRight(enigma.Resposta.Length, ' ');
        }

        static Enigma GetEnigmaAleatorio()
        {
            Random random = new Random();
            int indice = random.Next(0, lista.Count - 1);
            return lista[indice];
        }

        static string GetTracos()
        {
            string tracos = "";
            tracos = tracos.PadRight(enigma.Resposta.Length, '_');
            tracos = tracos.SubstituiCaracteresNaMesmaPosicao(' ', enigma.Resposta);
            return tracos;
        }

        private static void AtualizaTela(int tentativa)
        {
            Console.WriteLine(palavra);
            Console.WriteLine(tracos);

            AtualizaLetrasUtilizadas();
            Console.WriteLine($"Letras utilizadas: {letrasUtilizadas}");

            Console.WriteLine($"Tentativa: {tentativa} de 7");

            if (tentativa == MAX_TENTATIVAS)
                Console.WriteLine($"Dica: {enigma.Dica}");

            Console.Write("Informe a letra: ");
        }

        private static void AtualizaLetrasUtilizadas()
        {
            if (resposta.EhUmaLetra())
            {
                if (!(letrasUtilizadas.Contains(resposta[0])))
                    letrasUtilizadas += resposta[0] + " ";
                else
                    Console.WriteLine($"Letra {resposta[0]} já utilizada.");
            }
        }

        private static void AtualizaPalavra()
        {
            if (!(letrasUtilizadas.Contains(resposta[0])))
                palavra = palavra.SubstituiCaracteresNaMesmaPosicao(resposta[0], enigma.Resposta);
        }
    }
}
