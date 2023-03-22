namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                int tentativa,
                    pontuacao,
                    numeroSecreto,
                    modoEscolhido;


                tentativa = 1;
                pontuacao = 1000;
                Console.Clear();
                Random instanciaNumeroRandom = new Random();
                numeroSecreto = Convert.ToInt16(instanciaNumeroRandom.Next(1, 21));
                Console.WriteLine(numeroSecreto);
                Console.WriteLine("========================================");
                Console.WriteLine("Bem-vindo(a) ao Jogo da Adivinhação");
                Console.WriteLine("========================================");
                Console.WriteLine("Escolha o nível de dificuldade: ");
                Console.WriteLine("(1) Fácil  (2) Médio  (3) Difícil");
                Console.Write("Escolha: ");
                modoEscolhido = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                switch (modoEscolhido)
                {
                    case 1:
                        Console.WriteLine("========================================");
                        Console.WriteLine("Modo facil, de um a quinze tentativas");
                        for (int tentativas = 15; tentativas > 0; tentativas--)
                        {
                            Console.WriteLine($"Tentativa {tentativa} de 15");
                            Console.WriteLine();
                            Console.WriteLine("========================================");
                            Console.WriteLine($"Qual é o seu {tentativa}° chute?");
                            int numeroUsuario = int.Parse(Console.ReadLine());
                            Console.WriteLine("========================================");
                            int calculoPontos = Math.Abs((numeroUsuario - numeroSecreto) / 2);
                            //se forigual q numero secreto
                            if (numeroUsuario == numeroSecreto)
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("Parabens voce acertou o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                break;
                            }
                            //se for menor q numero secreto
                            else if (numeroUsuario < numeroSecreto)
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("Seu chute foi menor que o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                tentativa++;
                            }
                            //se for maior numero secreto
                            else 
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("========================================");
                                Console.WriteLine("Seu chute foi maior que o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                tentativa++;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("========================================");
                        Console.WriteLine("Modo medio, de um a quinze tentativas");
                        for (int tentativas = 10; tentativas > 0; tentativas--)
                        {
                            Console.WriteLine($"Tentativa {tentativa} de 15");
                            Console.WriteLine();
                            Console.WriteLine("========================================");
                            Console.WriteLine($"Qual é o seu {tentativa}° chute?");
                            int numeroUsuario = int.Parse(Console.ReadLine());
                            Console.WriteLine("========================================");
                            int calculoPontos = Math.Abs((numeroUsuario - numeroSecreto) / 2);
                            //se forigual q numero secreto
                            if (numeroUsuario == numeroSecreto)
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("Parabens voce acertou o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                break;
                            }
                            //se for menor q numero secreto
                            else if (numeroUsuario < numeroSecreto)
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("Seu chute foi menor que o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                tentativa++;
                            }
                            //se for maior numero secreto
                            else
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("========================================");
                                Console.WriteLine("Seu chute foi maior que o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                tentativa++;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("========================================");
                        Console.WriteLine("Modo dificil, de um a quinze tentativas");
                        for (int tentativas = 5; tentativas > 0; tentativas--)
                        {
                            Console.WriteLine($"Tentativa {tentativa} de 15");
                            Console.WriteLine();
                            Console.WriteLine("========================================");
                            Console.WriteLine($"Qual é o seu {tentativa}° chute?");
                            Console.WriteLine();
                            int numeroUsuario = int.Parse(Console.ReadLine());
                            Console.WriteLine("========================================");
                            int calculoPontos = Math.Abs((numeroUsuario - numeroSecreto) / 2);
                            //se forigual q numero secreto
                            if (numeroUsuario == numeroSecreto)
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("Parabens voce acertou o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                break;
                            }
                            //se for menor q numero secreto
                            else if (numeroUsuario < numeroSecreto)
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("Seu chute foi menor que o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                tentativa++;
                            }
                            //se for maior numero secreto
                            else
                            {
                                pontuacao = pontuacao - calculoPontos;
                                Console.WriteLine("========================================");
                                Console.WriteLine("Seu chute foi maior que o numero secreto");
                                Console.WriteLine("Voce fez " + pontuacao + " pontos");
                                Console.WriteLine("========================================");
                                tentativa++;
                            }
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}