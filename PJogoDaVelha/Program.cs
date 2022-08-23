using System;
namespace PJogoDaVelha
{
    internal class Program
    {
        static void Iniciar(char jogador, bool fimdejogo)
        {
            int contador = 0;
            char[,] matriz = new char[3, 3];
            while (fimdejogo == false)
            {
                RenderizarTabela(matriz);
                contador += LerEscolhaDoUsuario(matriz, jogador);
                RenderizarTabela(matriz);
                if (contador > 3)
                {
                    fimdejogo = VerificarFimDeJogo(matriz, fimdejogo, jogador, contador);
                }
                jogador = MudarVez(jogador);
            }
        }
        static char MudarVez(char jogador)
        {
            if (jogador == 'X')
                return 'O';
            else
                return 'X';
        }
        static bool VerificarFimDeJogo(char[,] matriz, bool fimdejogo, char jogador, int contador)
        {
            //Vitória Horizontal
            if (matriz[0, 0] == jogador && matriz[0, 1] == jogador && matriz[0, 2] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            if (matriz[1, 0] == jogador && matriz[1, 1] == jogador && matriz[1, 2] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            if (matriz[2, 0] == jogador && matriz[2, 1] == jogador && matriz[2, 2] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            //Vitória Vertical
            if (matriz[0, 0] == jogador && matriz[1, 0] == jogador && matriz[2, 0] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            if (matriz[0, 1] == jogador && matriz[1, 1] == jogador && matriz[2, 1] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            if (matriz[0, 2] == jogador && matriz[1, 2] == jogador && matriz[2, 2] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            //Vitória diagonal
            if (matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            if (matriz[0, 2] == jogador && matriz[1, 1] == jogador && matriz[2, 0] == jogador)
            {
                Console.WriteLine("O jogador " + jogador + " ganhou!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            if (contador > 8)
            {
                Console.WriteLine("\nTodas as casas foram ocupadas. DEU VELHA!!!");
                fimdejogo = true;
                return fimdejogo;
            }
            return fimdejogo;
        }
        static int LerEscolhaDoUsuario(char[,] matriz, char jogador = ' ')
        {
            bool verificaPosicao;
            int op;
            int contadorFimdeJogo = 0;
            do
            {
                Console.Write("\nVez do jogador: {0} !",jogador);
                Console.Write("\nInforme o número da casa em que você deseja jogar de 1 a 9 e que esteja disponível: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        verificaPosicao = ValidarEscolha(matriz[0, 0]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[0, 0] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 2:
                        verificaPosicao = ValidarEscolha(matriz[0, 1]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[0, 1] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 3:
                        verificaPosicao = ValidarEscolha(matriz[0, 2]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[0, 2] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 4:
                        verificaPosicao = ValidarEscolha(matriz[1, 0]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[1, 0] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 5:
                        verificaPosicao = ValidarEscolha(matriz[1, 1]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[1, 1] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 6:
                        verificaPosicao = ValidarEscolha(matriz[1, 2]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[1, 2] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 7:
                        verificaPosicao = ValidarEscolha(matriz[2, 0]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[2, 0] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 8:
                        verificaPosicao = ValidarEscolha(matriz[2, 1]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[2, 1] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    case 9:
                        verificaPosicao = ValidarEscolha(matriz[2, 2]);
                        if (verificaPosicao == true)
                        {
                            Console.WriteLine("Opção já foi escolhida! Por favor, jogar novamente!");
                            op = 10;
                        }
                        else
                        {
                            matriz[2, 2] = jogador;
                            contadorFimdeJogo++;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção de casa Inválida, por favor, digitar uma casa válida! Jogar novamente!");
                        break;
                }
            } while (op < 1 || op > 9);
            return contadorFimdeJogo;
        }
        static bool ValidarEscolha(char matriz)
        {
            if (matriz == 'O' || matriz == 'X')
                return true;
            else
                return false;
        }
        static void RenderizarTabela(char[,] matriz)
        {
            Console.Clear();
            Console.WriteLine("Tabela do jogo a ser seguida: ");
            Console.WriteLine("1|2|3");
            Console.WriteLine("4|5|6");
            Console.WriteLine("7|8|9");
            Console.WriteLine("\nTabela do jogo atual: ");

            //  Console.WriteLine(" " + matriz[0, 0] + " | " + matriz[0, 1] + " | " + matriz[0, 2] + "");
            // Console.WriteLine(" " + matriz[1, 0] + " | " + matriz[1, 1] + " | " + matriz[1, 2] + "");
            // Console.WriteLine(" " + matriz[2, 0] + " | " + matriz[2, 1] + " | " + matriz[2, 2] + "");

            Console.WriteLine($"[{matriz[0, 0]}][{matriz[0, 1]}][{matriz[0, 2]}]");
            Console.WriteLine($"[{matriz[1, 0]}][{matriz[1, 1]}][{matriz[1, 2]}]");
            Console.WriteLine($"[{matriz[2, 0]}][{matriz[2, 1]}][{matriz[2, 2]}]");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo da Velha");
            Console.WriteLine("Objetivo: O objetivo do jogo é fazer uma sequência de três símbolos iguais, seja em linha vertical, horizontal ou diagonal, enquanto tenta impedir que seu adversário faça o mesmo.\n");
            Console.WriteLine("Pressione ENTER para jogar!");
            Console.ReadKey();
            Console.Clear();
            Iniciar('X', false);
        }
    }
}