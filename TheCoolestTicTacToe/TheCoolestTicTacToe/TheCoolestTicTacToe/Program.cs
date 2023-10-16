// See https://aka.ms/new-console-template for more information
// string firstNumber = "10";
// string secondNumber = "2";
//jeff jeffory = new jeff(1,2);
//jeffory.addStuff(int.Parse(firstNumber), int.Parse(secondNumber));
//string myStringThing = " my name is stephenie"; 
//Console.WriteLine(jeffory.addStuff(int.Parse(firstNumber), int.Parse(secondNumber)));
//var something = "works?";
// public class jeff
// {
    // short firstshort;
    // short secondshort;

    // public jeff (short one, short two)
    // {
        // firstshort = one;
        // secondshort = two;
    // }
    // public int addStuff(int NumberOne, int NumberTwo)
    // {
        // return NumberOne + NumberTwo;
    // }
    // public int addStuff(int NumberOne, int NumberTwo, int NumberThree)
    // {
        // return NumberOne + NumberTwo + NumberThree;
    // }
    // public int addStuff(string NumberOne, string NumberTwo)
    // {
        // var addedInt = int.Parse(NumberOne) + int.Parse(NumberTwo);
        // return addedInt;
    // }
    
// }
using System.Xml.Serialization;

Board game = new Board();
int spot;
string winner = " ";

        do
        {
            game.Display();
            Console.Write($"Player {game.player.Turn()}, enter your move (1-9): ");
            while (!int.TryParse(Console.ReadLine(), out spot))//this line from GPT
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                Console.Write($"Player {game.player.Turn()}, enter your move (1-9): ");
            }

            if (game.PlaceMark(spot))
            {
                winner = game.CheckWin();
            }
        } while (winner == " " && !game.IsBoardFull());

    game.Display();

        if (winner != " ")
        {
            Console.WriteLine($"Player {winner} wins!");
        }
        else
        {
            Console.WriteLine("It's a cat's game!");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

public class Player
 {
        protected string turn = "X";

        public string Turn()
        {
            return turn;
        }
         public void setTurn(string nturn)
        {
            turn = nturn;
        }
 }

public class Board
{
    private string[] spaces = {"1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public Player player = new Player();
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Hello Tic Tac Toe!");
        Console.WriteLine("PLAYER 1: X    PLAYER 2: O");
        Console.WriteLine($" {spaces[0]} | {spaces[1]} | {spaces[2]} ");
        Console.WriteLine("-------------");
        Console.WriteLine($" {spaces[3]} | {spaces[4]} | {spaces[5]} ");
        Console.WriteLine("-------------");
        Console.WriteLine($" {spaces[6]} | {spaces[7]} | {spaces[8]} ");
        Console.WriteLine("");
    }
    public bool PlaceMark(int spot) // parameters include mark and places
    {
        // validate legal placement of the mark
        bool valid = isValidPlacement(spot);
        // update the board spaces attribute to include the mark
        if (valid)
        {
            spaces[spot -1] = player.Turn();
            if(player.Turn() == "X")
                player.setTurn("O");
            else
                player.setTurn("X");

            return true;
        } 
        return false;       
    }
    public bool isValidPlacement(int spot)
    {
         if(spot < 1 || spot > 9 || spaces[spot -1] != " ")
            {
                Console.WriteLine("Invalid spot chosen (try again): ");
                return false;
            }
        return true;
    }
    public void ClearBoard()
    {
        for(int i =0; i<spaces.Length; i++)
        {
            spaces[i] = $"{i+1}";
        }
    }
     public string CheckWin()
    {
        //rows
        for (int i = 0; i < 3; i++)
        {
            if (spaces[i * 3] == spaces[i * 3 + 1] && spaces[i * 3 + 1] == spaces[i * 3 + 2])
            {
                return spaces[i * 3];
            }
        }
        //columns
        for (int i = 0; i < 3; i++)
        {
            if (spaces[i] == spaces[i + 3] && spaces[i + 3] == spaces[i + 6])
            {
                return spaces[i];
            }
        }
        //diagonals
        if ((spaces[0] == spaces[4] && spaces[4] == spaces[8]) ||
            (spaces[2] == spaces[4] && spaces[4] == spaces[6]))
        {
            return spaces[4];
        }
        return " ";
    }
    public bool IsBoardFull()
    {
        foreach (string s in spaces)
        {
            if (s == " ")
            {
                return false;
            }
        }
        return true;
    }
}













