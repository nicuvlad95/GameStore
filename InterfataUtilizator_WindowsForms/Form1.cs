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
using System.Runtime.CompilerServices;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        private List<VideoGame> Games = new List<VideoGame> { };

        private List<VideoGame> NewListGames = new List<VideoGame> { };




        public Form1()
        {
            InitializeComponent();

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
            AfisareGames();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareGames();
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



        private void btnCauta_Click(object sender, EventArgs e)
        {

            List<VideoGame> NewGames = new List<VideoGame>();

            foreach (VideoGame game in Games)
            {
                if (txtSearch.Text.ToLower() == game.Title.ToLower())
                {

                    NewGames.Add(game);
                    dgvGames.DataSource = NewGames;
                }

            }

        }
        private void dgvGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                NewListGames.Add(Games[e.RowIndex]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = NewListGames;
                lblTotal.Text = $"Nr Total Games:{NewListGames.Count.ToString()}";
                lblPrice2.Text = $"Total price:{CalculeazaPretulTotal()}";
            };

        }

        private int CalculeazaPretulTotal()
        {
            int total = 0;
            foreach (VideoGame game in NewListGames)
            {
                total = total + Convert.ToInt32(game.Price);
            }
            return total;

        }


        private void AfisareGames()
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


    }
}

