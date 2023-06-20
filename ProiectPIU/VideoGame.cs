using System;


namespace VideoGameStore
{
    public class VideoGame
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int IdGame { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public VideoGame(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            IdGame = Convert.ToInt32(dateFisier[0]);
            Title = dateFisier[1];
            Publisher = dateFisier[2];
            Developer = dateFisier[3];
            ReleaseDate = DateTime.Parse(dateFisier[4]);
            Genre = dateFisier[5];
            Price = Convert.ToDecimal(dateFisier[6]);
        }

        public VideoGame( int idGame, string title, string publisher="", string developer="", DateTime releaseDate=default(DateTime), string genre="", decimal price=0)
        {
            IdGame = idGame; 
            Title = title;
            Publisher = publisher;
            Developer = developer;
            ReleaseDate = releaseDate;
            Genre = genre;
            Price = price;
        }
        public void Info()
        {
            Console.WriteLine(IdGame + " " + Title);
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectGamePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdGame.ToString(),
                Title ?? " NECUNOSCUT ",
                Publisher ?? "NECUNOSCUT",
                Developer ?? "Necunoscut",
                ReleaseDate.ToString(),
                Genre ?? "Necunoscut",
                Price.ToString()
                );

            return obiectGamePentruFisier;
        }
    }
}
