using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tictactoe.");
            Console.WriteLine("Please press the Enter/Return Key");
            Console.ReadLine();
            var board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            char currentPlayer = 'X';

            while (true)
            {
                Console.Clear();
                Console.WriteLine("  {0} | {1} | {2}", board[0], board[1], board[2]);
                Console.WriteLine("------------");
                Console.WriteLine("  {0} | {1} | {2}", board[3], board[4], board[5]);
                Console.WriteLine("------------");
                Console.WriteLine("  {0} | {1} | {2}", board[6], board[7], board[8]);

                Console.WriteLine($"Player {currentPlayer}, please make a move.");
                string userInput = Console.ReadLine();
                //TODO Make sure user can only input #'s between 0-8 Couldn't figure this one out, I tried googling it and couldn't find anything on it.

                var move = int.Parse(userInput);
                board[move] = currentPlayer;



                if ((board[0] == currentPlayer) && (board[1] == currentPlayer) && (board[2] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;
                }
                if ((board[3] == currentPlayer) && (board[4] == currentPlayer) && (board[5] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;
                }
                if ((board[6] == currentPlayer) && (board[7] == currentPlayer) && (board[8] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;
                }
                if ((board[0] == currentPlayer) && (board[3] == currentPlayer) && (board[6] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;
                }
                if ((board[1] == currentPlayer) && (board[4] == currentPlayer) && (board[7] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;
                }
                if ((board[2] == currentPlayer) && (board[5] == currentPlayer) && (board[8] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;
                }
                if ((board[0] == currentPlayer) && (board[4] == currentPlayer) && (board[8] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;
                }
                if ((board[2] == currentPlayer) && (board[4] == currentPlayer) && (board[6] == currentPlayer))
                {
                    Console.WriteLine("You Won!!!");
                    Console.ReadLine();
                    break;

                }
                if (currentPlayer == 'X')
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }


                bool isboardFull = true;

                foreach (var spot in board)
                {
                    if (spot != 'X' && spot != 'O')
                    {
                        isboardFull = false;
                        break;
                    }
                }
                if (isboardFull)
                {
                    Console.WriteLine("Tie Game");
                }



            }
            Console.ReadLine();
        }
    }
}
