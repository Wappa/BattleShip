using System;
using static BattleShip.Ship;

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
            bool invalidDick = false;
            bool invalidSub = false;
            
            matrice = new Ship[lenMat,lenMat];
            while (nbDestroyer < 1 || invalidDes == false)
            {
                Console.WriteLine("Entrez la premièere coordonnée (Un chiffre entre 1 et 8)");
                string UCoor = Console.ReadLine();
                int UnCoor = Convert.ToInt32(UCoor);
                Console.WriteLine("Entrez la Seconde coordonnée (Un chiffre entre 1 et 8)");
                string SCoor = Console.ReadLine();
                int SeCoor = Convert.ToInt32(SCoor);
                if ((UnCoor >=1 && UnCoor<=8 ) && (SeCoor >=1 && SeCoor <=8) )
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
                if ((UnCoor >= 1 && UnCoor <= 8) && (SeCoor >= 1 && SeCoor <= 8))
                {
                    invalidCru = true;
                    nbCruiser += 1;
                }

                bool ExactC = true;

                while (ExactC)
                {
                    Console.WriteLine(
                        "Coordonnée valide, Choisissez la direction de votre bateau \n 0 = North , 1 = South , 2 = West and 3= East ");
                    string Direction = Console.ReadLine();
                    switch (Direction)
                    {
                        case "0":
                            if (UnCoor - 2 < 0)
                            {
                                Console.WriteLine("Invalid Position try again");
                                ExactC = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.CRUISER, Ship.Directions.NORTH);

                            break;
                        case "1":
                            if (UnCoor + 3 > matrice.Length || SeCoor + 3> matrice.Length)
                            {
                                Console.WriteLine("Invalid Position try again ");
                                ExactC = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.CRUISER, Ship.Directions.SOUTH);

                            ExactC = false;
                            break;

                        case "2":
                            if (SeCoor - 2 <= 0)
                            {
                                Console.WriteLine("Invalid Position try again");
                                ExactC = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.MINIDICK, Ship.Directions.WEST);

                            ExactC = false;
                            break;
                        case "3":
                            if (SeCoor + 2 >= lenMat)
                            {
                                Console.WriteLine("Invalid Position try again");
                                ExactC = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.MINIDICK, Ship.Directions.EAST);

                            ExactC = false;
                            break;
                    }   
                }

            }
            while (nbMinidick < 1 || invalidDick == false)
            {
                Console.WriteLine("Entrez la premièere coordonnée (Un chiffre entre 1 et 8)");
                string UCoor = Console.ReadLine();
                int UnCoor = Convert.ToInt32(UCoor);
                Console.WriteLine("Entrez la Seconde coordonnée (Un chiffre entre 1 et 8)");
                string SCoor = Console.ReadLine();
                int SeCoor = Convert.ToInt32(SCoor);
                if ((UnCoor >= 1 && UnCoor <= 8) && (SeCoor >= 1 && SeCoor <= 8))
                {
                    invalidDick = true;
                    nbMinidick += 1;
                }

                bool ExactM = true;
                while (ExactM)
                {
                    Console.WriteLine("Coordonnée valide, Choisissez la direction de votre bateau \n 0 = North , 1 = South , 2 = West and 3= East ");
                    string Direction = Console.ReadLine();
                    switch (Direction) 
                    { 
                        case "0":
                            if (UnCoor - 2 < 0) {
                                Console.WriteLine("Invalid Position try again"); 
                                ExactM = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.MINIDICK, Ship.Directions.NORTH); 
                            break;
                        case "1": 
                            if (UnCoor + 2 > matrice.Length ) 
                            { 
                                Console.WriteLine("Invalid Position try again "); 
                                ExactM = true;
                            }
                            else 
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.MINIDICK, Ship.Directions.SOUTH);

                            ExactM = false;
                            break;
                                                 
                        case "2": 
                            if (SeCoor - 2 <= 0) 
                            { 
                                Console.WriteLine("Invalid Position try again"); 
                                ExactM = true;
                            }
                            else 
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.MINIDICK, Ship.Directions.WEST);

                            ExactM = false;
                            break;
                        case "3": 
                            if (SeCoor + 2 >= lenMat)
                            {
                                Console.WriteLine("Invalid Position try again");
                                ExactM = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.MINIDICK, Ship.Directions.EAST);

                            ExactM = false;
                            break;
                    }
                }
            }

               
            while (nbSubmarine < 1 || invalidSub == false)
            {
                Console.WriteLine("Entrez la premièere coordonnée (Un chiffre entre 1 et 8)");
                string UCoor = Console.ReadLine();
                int UnCoor = Convert.ToInt32(UCoor);
                Console.WriteLine("Entrez la Seconde coordonnée (Un chiffre entre 1 et 8)");
                string SCoor = Console.ReadLine();
                int SeCoor = Convert.ToInt32(SCoor);
                if ((UnCoor >= 1 && UnCoor <= 8) && (SeCoor >= 1 && SeCoor <= 8))
                {
                    invalidSub = true;
                    nbSubmarine += 1;
                }
                bool ExactS = true;
                while (ExactS)
                { 
                    Console.WriteLine(
                        "Coordonnée valide, Choisissez la direction de votre bateau \n 0 = North , 1 = South , 2 = West and 3= East ");
                    string Direction = Console.ReadLine();
                    switch (Direction)
                    {
                        case "0":
                            if (UnCoor - 3 < 0)
                            {
                                Console.WriteLine("Invalid Position try again");
                                ExactS = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.SUBMARINE, Ship.Directions.NORTH);

                            ExactS = false;
                            break;
                        case "1":
                            if (UnCoor + 3 > matrice.Length )
                            {
                                Console.WriteLine("Invalid Position try again ");
                                ExactS = true;
                                 
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.SUBMARINE, Ship.Directions.SOUTH);
                            ExactS = false;
                            break;
                        case "2":
                            if (SeCoor - 3 <= 0)
                            {
                                Console.WriteLine("Invalid Position try again");
                                ExactS = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.SUBMARINE, Ship.Directions.WEST);

                            ExactS = false;
                            break;
                        case "3":
                            if (SeCoor+3 >= lenMat)
                            {
                                Console.WriteLine("Invalid Position try again");
                                ExactS = true;
                            }
                            else
                                matrice[UnCoor, SeCoor] = new Ship(Ship.Types.SUBMARINE, Ship.Directions.EAST);

                            ExactS = false;
                            break;
                    }
                }
                Console.WriteLine(matrice);
            }
           
        }
    }
}