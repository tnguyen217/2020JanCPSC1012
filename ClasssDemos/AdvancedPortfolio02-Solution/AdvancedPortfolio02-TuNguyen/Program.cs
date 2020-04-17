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
                int playerRow = 0, playerColumn = 0, moves = 0;
                string[,] gameBoard = new string[7, 7];
                string player = "";
                bool endGame = false, valid = false;

                do
                {
                    bool result = false;
                    if (moves % 2 == 1)
                        player = "X";
                    else
                        player = "O";
                    do
                    {
                        //Determine the postition to place X and O tokens
                        PlayerPostion(player, out playerRow, out playerColumn);
                        //playerColumn = Column(player);

                        valid = CheckTakenSpot(gameBoard, playerRow, playerColumn, player);
                    } while (valid == true);

                    //Display New Blank Game Board
                    gameBoard = GameBoard(gameBoard, playerRow, playerColumn, player);

                    moves++;

                    //result is used to check if GameStatus() true
                    //If not, result will be Tie() true
                    //If not, continue the game until GameStatus() true of Tie() true
                    result = GameStatus(gameBoard, player, moves);
                    if (result == true)
                        endGame = true;
                    else
                    {
                        result = Tie(moves);
                        if (result == true)
                            endGame = true;
                    }
                } while (endGame == false);

                Console.Write("Would you like to play again (y/n)? ");
                answer = Console.ReadLine();
            } while (answer.ToUpper().Equals("Y"));
            Console.WriteLine("Good-bye and thanks for playing.");
        }

        //This method is used as a game board and display the moves of tokens
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

        //This method is used to prompt player tokens postition
        static public void PlayerPostion(string player, out int r, out int c)
        {
            string postion;
            r = 0; c = 0;
            bool valid = false;

            //determine which row tokens will be located
            do
            {
                Console.Write($"Enter cell row for player {player} Top (T), Middle (M) or Bottom (B): ");
                postion = Console.ReadLine();

                if (postion.ToUpper().Equals("T") || postion.ToUpper().Equals("M") || postion.ToUpper().Equals("B"))
                {
                    valid = true;
                    if (postion.ToUpper().Equals("T"))
                        r = 1;
                    else if (postion.ToUpper().Equals("M"))
                        r = 3;
                    else if (postion.ToUpper().Equals("B"))
                        r = 5;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Invalid entry for game location. Try again.");
                }

            } while (valid == false);

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

        }

        //This method is used to check if the spot is taken or not
        static public bool CheckTakenSpot(string[,] gameBoard, int r, int c, string player)
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

        //This method is used to check if player wins and display winning message
        static public bool GameStatus(string[,] gameBoard, string player, int moves)
        {
            bool endGame = false;

            for (int c = 1; c < 7; c += 2)
            {
                if (gameBoard[1, c] == player && gameBoard[1, c] == gameBoard[3, c] &&
                   gameBoard[1, c] == gameBoard[5, c] && gameBoard[3, c] == gameBoard[5, c])
                {
                    endGame = true;
                    Console.WriteLine($"Player {player} wins!");
                }
            }

            for (int r = 1; r < 7; r += 2)
            {
                if (gameBoard[r, 1] == player && gameBoard[r, 1] == gameBoard[r, 3] &&
                    gameBoard[r, 1] == gameBoard[r, 5] && gameBoard[r, 3] == gameBoard[r, 5])
                {
                    endGame = true;
                    Console.WriteLine($"Player {player} wins!");
                }
            }

            if ((gameBoard[1, 1] == player && gameBoard[3, 3] == player && gameBoard[5, 5] == player) ||
                (gameBoard[1, 5] == player && gameBoard[3, 3] == player && gameBoard[5, 1] == player))
            {
                endGame = true;
                Console.WriteLine($"Player {player} wins!");
            }

            return endGame;
        }

        //This method is used to check if player ties and display tie message
        static public bool Tie(int moves)
        {
            bool tie = false;

            if (moves == 9)
            {
                tie = true;
                Console.WriteLine("Tie!");
            }
            else
                tie = false;

            return tie;
        }
    }
}

