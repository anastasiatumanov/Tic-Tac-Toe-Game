// Author: Anastasia Tumanov 
// File Name: main.cs
// Project Name: MP2-2
// Creation Date: Nov 6, 2021
// Modified Date: Nov, 2021
// Description: This program is built for two users who wish to play a game of Tic-Tac-Toe. The users take turns simply entering a space on which they wish to have their game board piece on, until there is a result of three in a row.  

using System; 

public class Program 
{
  static int userChoice;
  static char choice = '-';
  static bool player1 = true;

  static char num1 = '1';
  static char num2 = '2';
  static char num3 = '3';
  static char num4 = '4';
  static char num5 = '5';
  static char num6 = '6';
  static char num7 = '7';
  static char num8 = '8';
  static char num9 = '9';

  static string message = "";

  //Store the status of active gameplay
  static bool gameDone = false;

  public static void Main(string[] args) 
  {
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;

    Console.Clear();
    Console.WriteLine("| Tic-Tac-Toe |");
    Console.WriteLine("===============\n");
    Console.WriteLine("Press ENTER to continue...");
    Console.ReadLine();

    while(gameDone == false)
    {
      DisplayBoard();
      GetSpace(player1);
      num1 = PlaceSpace(userChoice, num1, player1);
      num2 = PlaceSpace(userChoice, num2, player1);
      num3 = PlaceSpace(userChoice, num3, player1);
      num4 = PlaceSpace(userChoice, num4, player1);
      num5 = PlaceSpace(userChoice, num5, player1);
      num6 = PlaceSpace(userChoice, num6, player1);
      num7 = PlaceSpace(userChoice, num7, player1);
      num8 = PlaceSpace(userChoice, num8, player1);
      num9 = PlaceSpace(userChoice, num9, player1);
      CheckWinner();
      Console.Clear();
    }

    DisplayResults();
  }

  private static void DisplayBoard()
  {
    Console.WriteLine("┌-----------╗");
    Console.Write("| ");
    if (num1 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num1);
    }
    else if (num1 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num1);
    }
    else
    {
      Console.Write(num1);
    }
    Console.ForegroundColor = ConsoleColor.Black;

    Console.Write(" | ");

    if (num2 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num2);
    }
    else if (num2 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num2);
    }
    else
    {
      Console.Write(num2);
    }
    Console.ForegroundColor = ConsoleColor.Black;

    Console.Write(" | ");

    if (num3 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num3);
    }
    else if (num3 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num3);
    }
    else
    {
      Console.Write(num3);
    }
    Console.ForegroundColor = ConsoleColor.Black;

    Console.WriteLine(" |");

    // Start of a new line of code
    Console.WriteLine("+-----------+");
    Console.Write("| ");

    if (num4 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num4);
    }
    else if (num4 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num4);
    }
    else
    {
      Console.Write(num4);
    }
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(" | ");
    if (num5 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num5);
    }
    else if (num5 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num5);
    }
    else
    {
      Console.Write(num5);
    }
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(" | ");

    if (num6 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num6);
    }
    else if (num6 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num6);
    }
    else
    {
      Console.Write(num6);
    }
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(" |");
    Console.WriteLine("+-----------+");
    Console.Write("| ");

    if (num7 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num7);
    }
    else if (num7 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num7);
    }
    else
    {
      Console.Write(num7);
    }
    
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(" | ");
    if (num8 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num8);
    }
    else if (num8 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num8);
    }
    else
    {
      Console.Write(num8);
    }

    Console.ForegroundColor = ConsoleColor.Black;

    Console.Write(" | ");

    if (num9 == 'X')
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(num9);
    }
    else if (num9 == 'O')
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write(num9);
    }
    else
    {
      Console.Write(num9);
    }

    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(" |");
    Console.WriteLine("+-----------+");
  }

  private static int GetSpace(bool player)
  {
    if (player1 == true)
    {
      Console.Write("Player 1, choose your space: ");
    }
    else if (player1 == false)
    {
      Console.Write("Player 2, choose your space: ");
    }
    
    userChoice = Convert.ToChar(Console.ReadLine());

    return userChoice;
  }

  private static char PlaceSpace (int userChoice, char num, bool player)
  {
    if (userChoice == (int)num)
    {
      if (num != 'X' && num != 'O')
      {
        if (player1)
        {
          num = 'X';
          player1 = false;
        }
        else
        {
          num = 'O';
          player1 = true;
        }
      }
    } 
    return num;
  }

  private static void CheckWinner()
  {
    if (num1 == 'X' && num2 == 'X' && num3 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num1 == 'O' && num2 == 'O' && num3 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num4 == 'X' && num5 == 'X' && num6 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num4 == 'O' && num5 == 'O' && num6 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num7 == 'X' && num8 == 'X' && num9 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num7 == 'O' && num8 == 'O' && num9 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num1 == 'X' && num4 == 'X' && num7 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num1 == 'O' && num4 == 'O' && num7 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num2 == 'X' && num5 == 'X' && num8 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num2 == 'O' && num5 == 'O' && num8 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num3 == 'X' && num6 == 'X' && num9 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num3 == 'O' && num6 == 'O' && num9 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num1 == 'X' && num5 == 'X' && num9 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num1 == 'O' && num5 == 'O' && num9 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num3 == 'X' && num5 == 'X' && num7 == 'X')
    {
      message = "Player 1 Won!!!!";
      gameDone = true;
    }
    else if (num3 == 'O' && num5 == 'O' && num7 == 'O')
    {
      message = "Player 2 Won!!!!";
      gameDone = true;
    }
    else if (num1 != '1' && num2 != '2' && num3 != '3' && num4 != '4' && num5 != '5' && num6 != '6' && num7 != '7' && num8 != '8' && num9 != '9')
    {
      message = "It's a tie!!!! Good job!";
      gameDone = true;
    }
  }
  private static void DisplayResults()
  {
    Console.WriteLine("The game has ended...");
    Console.WriteLine("Click ENTER to see who won...");
    Console.ReadLine();
    Console.WriteLine(message);
  }
}
