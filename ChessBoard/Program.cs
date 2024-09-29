using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            /*CHESSBOARD SIZE*/

            Console.Write("Hejsan! Skriv hur många rader ditt schackbräde ska ha: ");

            int boardLength;

            while (true) //Whileloop to keep the loop going if the users input is invalid.
            {
                if (int.TryParse(Console.ReadLine(), out boardLength)) //If statement to check if the input is valid.
                {
                    break; //Breaks out of loop if user input is valid
                }
                else
                {
                    Console.Write("Fel inmatning, skriv ett heltal: "); //If user input is invalid, prints message.
                }
            }
            Console.WriteLine($"Du valde {boardLength}.");

            /*CHESSBOARD SYMBOLS*/

            Console.Write($"Nu ska du välja 2 tecken separerade med \"/\", T.ex [◼︎/◻︎]: ");
            string userInputSymbol = Console.ReadLine();
            string[] parts = userInputSymbol.Split('/'); //Splits user input into an array.

            string symbol1;
            string symbol2;

            //Failsafe for user input (checks length of array)
            if (parts.Length == 2)
            {
                //Assign variables for symbols chosen by user
                symbol1 = parts[0];
                symbol2 = parts[1];

                Console.WriteLine($"Du valde {symbol1} och {symbol2}");
            }
            else
            {
                //If user input is invalid, program continues with default symbols
                Console.WriteLine("Fel inmatning, du får default-symbolerna [◼︎/◻︎]");
                symbol1 = "◼︎";
                symbol2 = "◻︎";
            }

            /*CHESSBOARD PRINT*/

            int row;
            int col;

            for (row = 0; row <= boardLength; row++) //Loop for the rows
            {
                for (col = 0; col <= boardLength; col++) //Loop for the columns
                {
                    if ((row + col) % 2 == 1) //checks if the sum of row and col is even, if it is prints symbol 1, if not prints symbol 2
                    {
                        Console.Write(symbol1);
                    }
                    else
                    {
                        Console.Write(symbol2);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
