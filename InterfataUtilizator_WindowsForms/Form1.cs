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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdministrareGames_FisierText adminGames = new AdministrareGames_FisierText("games");
            double id = new Random().NextDouble();
            VideoGame game = new VideoGame(id, txtName.Text, txtPublisher.Text, txtDeveloper.Text, dateTimePicker1.Value, comboBox1.Text, txtPrice.Value);
            adminGames.AddGame(game);
            ResetareControale();
        }

        private void btnListGames_Click(object sender, EventArgs e)
        {
            AdministrareGames_FisierText adminGames = new AdministrareGames_FisierText("games");
            List<VideoGame> games = adminGames.GetVideoGames(10);
            dgvGames.DataSource = games;
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
    }
  
}