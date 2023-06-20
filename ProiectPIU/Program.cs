using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Configuration;


namespace VideoGameStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoGameStore store = new VideoGameStore();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareGames_FisierText adminGames = new AdministrareGames_FisierText(numeFisier);
            int nrGames = 0;
            //VideoGame game = new VideoGame(nrGames, "");

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii jocului");
                Console.WriteLine("A. Afisare jocuri");
                Console.WriteLine("F. Afisare jocuri din fisier");
                Console.WriteLine("S. Salvare joc in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        int idGame = nrGames;

                        Console.WriteLine("Introdu numele jocului {0} : ", idGame);
                       // string nume = Console.ReadLine();
                       // game = new VideoGame(idGame, nume);
                       // nrGames++;

                        break;
                    case "A":
                        //game.Info();

                        break;
                    case "F":
                       // List<VideoGame> Games = adminGames.GetVideoGames( nrGames);
                        //AfisareGames(Games, nrGames);

                        break;
                    case "S":
                        //adaugare joc in fisier
                        //adminGames.AddGame(game);

                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");
            Console.ReadKey();

            void AfisareGames(VideoGame[] games, int nrgames)
            {
                Console.WriteLine("Jocurile sunt:");
                for (int contor = 0; contor < nrgames; contor++)
                {
                    string infoGames = string.Format("Jocul cu id-ul #{0} are numele: {1}",
                       games[contor].IdGame,
                       games[contor].Title ?? " NECUNOSCUT "
                       );



                    Console.WriteLine(infoGames);
                }
            }
        }

        }
    }



