namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hejsan, dags att välja hur lång sidan på din schackbräda skall vara: ");
            int boardLength = Convert.ToInt32(Console.ReadLine());
            string evenNumber = "";
            string oddNumber = "";
            int[,] board = new int[boardLength, boardLength];
        }
    }
}
