using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedPortfolio02_TuNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            
            Pupose:     To create Tic-Tac-Toe Game 
              
            Input:      Players take turns to fill X or O the tiles to make 3-in-a-row to win
              
            Process:    Display the Game Title
                        Ask each player for the position of the X and O
                        Display the board game after every token 
                        Continue until the board tiles are all filled or one player make a 3-in-a-row
                        Determine which player win
                        Ask if the player want a rematch
                        If yes, clear and play
                        If no, display goodbye message
            
            Output:     Game board after every token
                        Win or Lose status
              
            Author:     Tu Nguyen
              
            Last modified date: 16.04.2020
            */

            string answer = "";
            do
            {
                Console.Clear();

                Console.WriteLine("********************");
                Console.WriteLine("* Tie-Tac-Toe Game *");
                Console.WriteLine("********************");

                Console.WriteLine("-------------");
                int playerRow = 0, playerColumn = 0, moves = 1;
                string[,] gameBoard = new string[7, 7];
                string player = "";
                bool endGame = false, valid = false;

                while (endGame == false)
                {
                    if (moves % 2 == 1)
                        player = "X";
                    else
                        player = "O";

                    do
                    {
                        //Determine the postition to place X and O tokens
                        playerRow = Row(player);
                        playerColumn = Column(player);

                        valid = CheckTakenCell(gameBoard, playerRow, playerColumn, player);
                    } while (valid == true);

                    //Display New Blank Game Board
                    gameBoard = GameBoard(gameBoard, playerRow, playerColumn, player);

                    moves++;

                    endGame = Win(gameBoard, playerRow, playerColumn, player, endGame);
                }


                Console.Write("Would you like to play again (y/n)? ");
                answer = Console.ReadLine();
            } while (answer.ToUpper().Equals("Y"));
            Console.WriteLine("Good-bye and thanks for playing.");
        }

        //This method is used as a game board
        static public string[,] GameBoard(string[,] gameBoard, int playerRow, int playerColumn, string player)
        {
            int r = 0, c = 0;

            for (r = 0; r < 7; r++)
            {
                if (r == 1 || r == 3 || r == 5)
                {
                    for (c = 0; c < 7; c++)
                    {
                        if (c == 0 || c == 2 || c == 4 || c == 6)
                            gameBoard[r, c] = "|";
                        else
                        {
                            if (gameBoard[r, c] == null)
                                gameBoard[r, c] = null;
                            if (r == playerRow && c == playerColumn)
                                gameBoard[r, c] = player;
                        }
                        Console.Write($"{gameBoard[r, c],-2}");
                    }
                }
                else
                    Console.WriteLine("\n-------------");
            }
            return gameBoard;
        }

        //This method is used to prompt player tokens to be placed in rows
        static public int Row(string player)
        {
            string postion;
            int r = 0;
            bool valid = false;

            //determine which row tokens will be located
            do
            {
                Console.Write($"Enter cell row for player {player} Top (T), Middle (M) or Bottom (B): ");
                postion = Console.ReadLine();

                if (postion.ToUpper().Equals("T"))
                {
                    valid = true;
                    r = 1;
                }
                else if (postion.ToUpper().Equals("M"))
                {
                    valid = true;
                    r = 3;
                }
                else if (postion.ToUpper().Equals("B"))
                {
                    valid = true;
                    r = 5;
                }
                else
                    Console.WriteLine("Invalid entry for game location. Try again.");
            } while (valid == false);

            return r;
        }

        //This method is used to prompt player O tokens to be placed in columns
        static public int Column(string player)
        {
            string postion;
            int c = 0;
            bool valid = false;

            //determine which column tokens will be located
            valid = false;
            do
            {
                Console.Write($"Enter cell row for {player} Left (L), Center (C) or Right (R): ");
                postion = Console.ReadLine();

                if (postion.ToUpper().Equals("L"))
                {
                    valid = true;
                    c = 1;
                }
                else if (postion.ToUpper().Equals("C"))
                {
                    valid = true;
                    c = 3;
                }
                else if (postion.ToUpper().Equals("R"))
                {
                    valid = true;
                    c = 5;
                }
                else
                    Console.WriteLine("Invalid entry for game location. Try again.");
            } while (valid == false);

            return c;
        }

        //This method is used to check if the cell is taken or not
        static public bool CheckTakenCell(string[,] gameBoard, int r, int c, string player)
        {
            bool valid = false;

            if (gameBoard[r, c] != null)
            {
                valid = true;
                Console.WriteLine("This spot is already taken. Try again.");
            }
            else
                valid = false;
            return valid;
        }

        static public bool Win(string[,] gameBoard, int playerRow, int playerColumn, string player, bool endGame)
        {
            if ((gameBoard[1, 1] == "X" && gameBoard[1, 3] == "X" && gameBoard[1, 5] == "X") ||
                (gameBoard[3, 1] == "X" && gameBoard[3, 3] == "X" && gameBoard[3, 5] == "X") ||
                (gameBoard[5, 1] == "X" && gameBoard[5, 3] == "X" && gameBoard[5, 5] == "X") ||
                (gameBoard[1, 1] == "X" && gameBoard[3, 1] == "X" && gameBoard[5, 1] == "X") ||
                (gameBoard[1, 3] == "X" && gameBoard[3, 3] == "X" && gameBoard[5, 3] == "X") ||
                (gameBoard[1, 5] == "X" && gameBoard[3, 5] == "X" && gameBoard[5, 5] == "X") ||
                (gameBoard[1, 1] == "X" && gameBoard[3, 3] == "X" && gameBoard[5, 5] == "X") ||
                (gameBoard[1, 5] == "X" && gameBoard[3, 3] == "X" && gameBoard[5, 1] == "X"))
            {
                endGame = true;
                Console.WriteLine("Player X wins!");
            }

            else if ((gameBoard[1, 1] == "O" && gameBoard[1, 3] == "O" && gameBoard[1, 5] == "O") ||
                    (gameBoard[3, 1] == "O" && gameBoard[3, 3] == "O" && gameBoard[3, 5] == "O") ||
                    (gameBoard[5, 1] == "O" && gameBoard[5, 3] == "O" && gameBoard[5, 5] == "O") ||
                    (gameBoard[1, 1] == "O" && gameBoard[3, 1] == "O" && gameBoard[5, 1] == "O") ||
                    (gameBoard[1, 3] == "O" && gameBoard[3, 3] == "O" && gameBoard[5, 3] == "O") ||
                    (gameBoard[1, 5] == "O" && gameBoard[3, 5] == "O" && gameBoard[5, 5] == "O") ||
                    (gameBoard[1, 1] == "O" && gameBoard[3, 3] == "O" && gameBoard[5, 5] == "O") ||
                    (gameBoard[1, 5] == "O" && gameBoard[3, 3] == "O" && gameBoard[5, 1] == "O"))
            {
                endGame = true;
                Console.WriteLine("Player O wins!");
            }

            else if (gameBoard[playerRow, playerColumn] == "X" && gameBoard[playerRow, playerColumn] == "O")
                Console.WriteLine("Tie!");

            return endGame;
        }
    }
}

