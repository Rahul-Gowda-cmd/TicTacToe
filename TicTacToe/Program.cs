﻿using System;

namespace TicTacToe
{
    class Program
    {
        static void ChooseLetter()
        {
            string computerChoose;
            Console.WriteLine("Plaese enter Your Letter(X/O) : ");
            string userChoose = Console.ReadLine();
            if (userChoose == "X" || userChoose == "x")
            {
                computerChoose = "O";
            }
            else if (userChoose == "O" || userChoose == "o")
            {
                computerChoose = "X";
            }
            else
                Console.WriteLine("Wrong input,Please type again");
        }
        static void CreateEmptyBoard()
        {
            Char[] board = new char[10];
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' ';
            }
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}  |  {1}   |  {2} ", board[1], board[2], board[3]);
            Console.WriteLine("____|______|____");
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}  |  {1}   |   {2}  ", board[4], board[5], board[6]);
            Console.WriteLine("____|______|____");
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}  |  {1}   |   {2}  ", board[7], board[8], board[9]);
            Console.WriteLine("____|______|____");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            CreateEmptyBoard();
            ChooseLetter();

        }
    }
}
