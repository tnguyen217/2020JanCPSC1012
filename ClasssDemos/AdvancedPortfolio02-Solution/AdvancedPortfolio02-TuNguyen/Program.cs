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

                int r = 0, c = 0;
                int[,] positionX = new int[r, c];
                int[,] positionO = new int[r, c];

                //Display New Blank Game Board
                GameBoard();
                positionX = PositionPlayerX();
                positionO = PositionPlayerO();

                Console.Write("Would you like to play again (y/n)? ");
                answer = Console.ReadLine();
            } while (answer.ToUpper().Equals("Y"));
            Console.WriteLine("Good-bye and thanks for playing.");
        }

        //This method is used to draw a new game board
        static public void GameBoard()
        {
            string[,] gameBoard = new string[7, 7];
            int r = 0, c = 0;

            for (r = 0; r < 7; r++)
            {
                if (r == 0 || r == 2 || r == 4 || r == 6)
                    Console.WriteLine("\n-------------");
                else
                {
                    for (c = 0; c < 7; c++)
                    {
                        if (c == 0 || c == 2 || c == 4 || c == 6)
                            gameBoard[r, c] = "|";
                        Console.Write($"{gameBoard[r, c] + " ",2}");
                    }
                }
            }
        }

        //This method is used to prompt player X for its potions base on x and y axis
        static public int[,] PositionPlayerX()
        {
            string xPostion, yPostion;
            int r = 0, c = 0;
            bool valid = false;
            int[,] postionX = new int[r, c];

            //determine which row X will locate
            do
            {
                valid = false;
                Console.Write("Enter cell row for player X Top (T), Middle (M) or Bottom (B): ");
                yPostion = Console.ReadLine();

                if (yPostion.ToUpper().Equals("T"))
                    r = 1;
                else if (yPostion.ToUpper().Equals("M"))
                    r = 3;
                else if (yPostion.ToUpper().Equals("B"))
                    r = 5;
                else
                    Console.WriteLine("Invalid entry for game location. Try again.");
            } while (valid == true);

            //determine which column X will locate
            do
            {
                valid = false;
                Console.Write("Enter cell row for player X Left (L), Center (C) or Right (R): ");
                xPostion = Console.ReadLine();

                if (xPostion.ToUpper().Equals("T"))
                    c = 1;
                else if (xPostion.ToUpper().Equals("M"))
                    c = 3;
                else if (xPostion.ToUpper().Equals("B"))
                    c = 5;
                else
                    Console.WriteLine("Invalid entry for game location. Try again.");
            } while (valid == true);

            return postionX;
        }

        //This method is used to prompt player O for its potions base on x and y axis
        static public int[,] PositionPlayerO()
        {
            string xPostion, yPostion;
            int r = 0, c = 0;
            bool valid = false;
            int[,] postionX = new int[r, c];

            //determine which row O will locate
            do
            {
                valid = false;
                Console.Write("Enter cell row for player O Top (T), Middle (M) or Bottom (B): ");
                yPostion = Console.ReadLine();

                if (yPostion.ToUpper().Equals("T"))
                    r = 1;
                else if (yPostion.ToUpper().Equals("M"))
                    r = 3;
                else if (yPostion.ToUpper().Equals("B"))
                    r = 5;
                else
                    Console.WriteLine("Invalid entry for game location. Try again.");
            } while (valid == true);

            //determine which column O will locate
            do
            {
                valid = false;
                Console.Write("Enter cell row for player O Left (L), Center (C) or Right (R): ");
                xPostion = Console.ReadLine();

                if (xPostion.ToUpper().Equals("T"))
                    c = 1;
                else if (xPostion.ToUpper().Equals("M"))
                    c = 3;
                else if (xPostion.ToUpper().Equals("B"))
                    c = 5;
                else
                    Console.WriteLine("Invalid entry for game location. Try again.");
            } while (valid == true);

            return postionX;
        }
    }
}
