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
            bool invalidCru = false;
            
            matrice = new Ship[lenMat,lenMat];
            while (nbDestroyer < 1 || invalidDes == false)
            {
                Console.WriteLine("Entrez la premièere coordonnée (Un chiffre entre 1 et 8)");
                string UCoor = Console.ReadLine();
                int UnCoor = Convert.ToInt32(UCoor);
                Console.WriteLine("Entrez la Seconde coordonnée (Un chiffre entre 1 et 8)");
                string SCoor = Console.ReadLine();
                int SeCoor = Convert.ToInt32(SCoor);
                if ((UnCoor >1 && UnCoor<8 ) && (SeCoor >1 && SeCoor <8) )
                {
                    invalidDes = true;
                    nbDestroyer += 1;
                }
                Console.WriteLine("Coordonnée valide, Choisissez la direction de votre bateau \n 0 = North , 1 = South , 2 = West and 3= East ");
                string Direction = Console.ReadLine();
                switch (Direction)
                { 
                    case "0":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.DESTROYER,Ship.Directions.NORTH);
                        break;
                    case "1":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.DESTROYER,Ship.Directions.SOUTH);
                        break;
                    case "2":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.DESTROYER,Ship.Directions.WEST);
                        break;
                    case "3":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.DESTROYER,Ship.Directions.EAST);
                        break;
                }
            }
            while (nbCruiser < 1 || invalidCru == false)
            {
                Console.WriteLine("Entrez la premièere coordonnée (Un chiffre entre 1 et 8)");
                string UCoor = Console.ReadLine();
                int UnCoor = Convert.ToInt32(UCoor);
                Console.WriteLine("Entrez la Seconde coordonnée (Un chiffre entre 1 et 8)");
                string SCoor = Console.ReadLine();
                int SeCoor = Convert.ToInt32(SCoor);
                if ((UnCoor > 1 && UnCoor < 8) && (SeCoor > 1 && SeCoor < 8))
                {
                    invalidCru = true;
                    nbCruiser += 1;
                }

                Console.WriteLine(
                    "Coordonnée valide, Choisissez la direction de votre bateau \n 0 = North , 1 = South , 2 = West and 3= East ");
                string Direction = Console.ReadLine();
                switch (Direction)
                {
                    case "0":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.CRUISER, Ship.Directions.NORTH);
                        break;
                    case "1":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.CRUISER, Ship.Directions.SOUTH);
                        break;
                    case "2":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.CRUISER, Ship.Directions.WEST);
                        break;
                    case "3":
                        matrice[UnCoor, SeCoor] = new Ship(Ship.Types.CRUISER, Ship.Directions.EAST);
                        break;
                }
            }
        }
    }
}