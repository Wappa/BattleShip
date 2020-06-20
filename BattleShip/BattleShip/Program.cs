using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix game = new Matrix(1,1,1,1,8);
            //Print2DArray(game);
        }
        

        public static void Print2DArray(Matrix matrix)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrix);
                }
                Console.WriteLine();
            }
        }
        
    }
}