using SinglePlayerTicTacToe.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SinglePlayerTicTacToe.Presentation
{
    internal class TIcTacToeMenu
    {
        public static bool Toggle = true;
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcom let's play!");
            Console.WriteLine(TicTacToeController.DisplayBoard());

            while (true) { 
                
                ExecuteGame(Toggle);
                Toggle = !Toggle;
            }
            
        }

        public static void ExecuteGame(bool player)
        {
            switch (player)
            {
                case true:
                    Player1();
                    break;

                case false:
                    ComputerPlays();
                    break;

                default:
                    break;
            }
        }

        public static void Player1()
        {
            Console.WriteLine("Player 1 turn 'x' :\n" +
                "Choose the box value to enter x, from the board\n");

            int index = int.Parse(Console.ReadLine());
            try
            {
                DeclareResult(TicTacToeController.TakeResponse(index, 'x') , "Player 1");
            }catch(Exception ex) 
            { Console.WriteLine(ex.Message);
                Player1();
            }
            
        }

        public static void ComputerPlays()
        {
            Console.WriteLine("Computer's turn");
            DeclareResult(TicTacToeController.Computer('o'), "Computer");
        }

        public static void DeclareResult(string result , string whoIsPlaying) {
            Console.WriteLine(TicTacToeController.DisplayBoard());
            if (result == "win")
            {
                Console.WriteLine($"{whoIsPlaying} won!");
                Environment.Exit(0);
            }
            else if (result == "draw")
            {
                Console.WriteLine("Game draw!");
                Environment.Exit(0);
            }
            return;
        }
    }
}
