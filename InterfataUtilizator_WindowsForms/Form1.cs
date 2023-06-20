using VideoGameStore;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        private List<VideoGame> Games = new List<VideoGame> { };
        private Label[] iblsName;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                iblGenre.ForeColor = Color.Red;
                iblPrice.ForeColor = Color.Red;
                iblName.ForeColor = Color.Red;
                iblDeveloper.ForeColor = Color.Red;
                iblPublisher.ForeColor = Color.Red;
                return;
            }
            else
            {
                int id = 0;
                AdministrareGames_FisierText adminGames = new AdministrareGames_FisierText("games");

                VideoGame game = new VideoGame(id, txtName.Text, txtPublisher.Text, txtDeveloper.Text, dateTimePicker1.Value, cbGenre.Text, txtPrice.Value);

                adminGames.AddGame(game);
                ResetareControale();
            }
        }

        private void btnListGames_Click(object sender, EventArgs e)
        {
            dgvGames.DataSource = null;
            dgvGames.Columns.Clear();

            AdministrareGames_FisierText adminGames = new AdministrareGames_FisierText("games");
            Games = adminGames.GetVideoGames(10);
            
            var buyButton = new DataGridViewButtonColumn();
            buyButton.Name = "Buy";
            buyButton.HeaderText = "Buy";
            buyButton.UseColumnTextForButtonValue = true;
            buyButton.Text = "Buy";
            buyButton.FlatStyle = FlatStyle.Flat;
            buyButton.DefaultCellStyle.BackColor = Color.Orange;
            
            dgvGames.DataSource = Games;
            dgvGames.Columns.Add(buyButton);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cart_Click(object sender, EventArgs e)
        {
            var myCart = new Cart();
            myCart.Show();
        }
        private void ResetareControale()
        {
            txtName.Text = txtDeveloper.Text = txtPublisher.Text = txtPrice.Text = string.Empty;

        }
        private bool DateIntrareValide()
        {
            if (txtPrice.Value == 0 && cbGenre.Text == string.Empty && txtName.Text == string.Empty && txtDeveloper.Text == string.Empty && txtDeveloper.Text == string.Empty) return false;
            else return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            //AdministrareGames_FisierText adminGames = new AdministrareGames_FisierText("games");
            //List<VideoGame> games = adminGames.GetVideoGames(10);
            List<VideoGame> NewGames = new List<VideoGame>();

           foreach (VideoGame game in Games)
            {
                if (txtSearch.Text == game.Title)
                {

                    NewGames.Add(game);
                    dgvGames.DataSource = NewGames;


                }
                else continue;
            }

        }

    }
}

