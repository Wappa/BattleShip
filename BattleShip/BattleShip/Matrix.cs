using System;

namespace BattleShip
{
    public class Matrix
    {
               private Ship[,] matrice;

        public Matrix(int nbSubmarine , int nbMinidick , int nbCruiser, int nbDestroyer, int lenMat)
        {
            nbSubmarine = 0;
            nbMinidick = 0;
            nbCruiser = 0;
            nbDestroyer = 0;
            bool invalidDes = false; 
            
            matrice = new Ship[lenMat,lenMat];
            while (nbDestroyer < 1 && invalidDes == false)
            {
                Console.WriteLine("Entrez la premièere coordonnée (Un chiffre entre 1 et 8)");
                string UnCoor = Console.ReadLine();
                Console.WriteLine("Entrez la Seconde coordonnée (Un chiffre entre 1 et 8)");
                string SeCoor = Console.ReadLine();
            }
        }
    }
}