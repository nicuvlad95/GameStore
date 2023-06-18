using NivelStocareDate;

using System.Configuration;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public class StocareFactory
    {
        static string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
        AdministrareGames_FisierText adminGames = new AdministrareGames_FisierText(numeFisier);

    }
}