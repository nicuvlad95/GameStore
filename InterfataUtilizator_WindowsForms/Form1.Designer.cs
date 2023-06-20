using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iblName = new System.Windows.Forms.Label();
            this.iblPublisher = new System.Windows.Forms.Label();
            this.iblDeveloper = new System.Windows.Forms.Label();
            this.iblReleaseDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnListGames = new System.Windows.Forms.Button();
            this.iblGenre = new System.Windows.Forms.Label();
            this.iblPrice = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.btnCauta = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iblName
            // 
            this.iblName.AutoSize = true;
            this.iblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.iblName.Location = new System.Drawing.Point(24, 24);
            this.iblName.Name = "iblName";
            this.iblName.Size = new System.Drawing.Size(53, 20);
            this.iblName.TabIndex = 0;
            this.iblName.Text = "Name";
            // 
            // iblPublisher
            // 
            this.iblPublisher.AutoSize = true;
            this.iblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.iblPublisher.Location = new System.Drawing.Point(24, 60);
            this.iblPublisher.Name = "iblPublisher";
            this.iblPublisher.Size = new System.Drawing.Size(79, 20);
            this.iblPublisher.TabIndex = 1;
            this.iblPublisher.Text = "Publisher";
            // 
            // iblDeveloper
            // 
            this.iblDeveloper.AutoSize = true;
            this.iblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.iblDeveloper.Location = new System.Drawing.Point(24, 91);
            this.iblDeveloper.Name = "iblDeveloper";
            this.iblDeveloper.Size = new System.Drawing.Size(85, 20);
            this.iblDeveloper.TabIndex = 2;
            this.iblDeveloper.Text = "Developer";
            // 
            // iblReleaseDate
            // 
            this.iblReleaseDate.AutoSize = true;
            this.iblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.iblReleaseDate.Location = new System.Drawing.Point(24, 123);
            this.iblReleaseDate.Name = "iblReleaseDate";
            this.iblReleaseDate.Size = new System.Drawing.Size(106, 20);
            this.iblReleaseDate.TabIndex = 3;
            this.iblReleaseDate.Text = "ReleaseDate";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(131, 91);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(270, 27);
            this.txtDeveloper.TabIndex = 5;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(131, 60);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(270, 27);
            this.txtPublisher.TabIndex = 6;
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAddGame.Location = new System.Drawing.Point(28, 289);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(113, 63);
            this.btnAddGame.TabIndex = 9;
            this.btnAddGame.Text = "AddGame";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListGames
            // 
            this.btnListGames.BackColor = System.Drawing.Color.Turquoise;
            this.btnListGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnListGames.Location = new System.Drawing.Point(166, 289);
            this.btnListGames.Name = "btnListGames";
            this.btnListGames.Size = new System.Drawing.Size(235, 63);
            this.btnListGames.TabIndex = 10;
            this.btnListGames.Text = "ListGames";
            this.btnListGames.UseVisualStyleBackColor = false;
            this.btnListGames.Click += new System.EventHandler(this.btnListGames_Click);
            // 
            // iblGenre
            // 
            this.iblGenre.AutoSize = true;
            this.iblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.iblGenre.Location = new System.Drawing.Point(24, 168);
            this.iblGenre.Name = "iblGenre";
            this.iblGenre.Size = new System.Drawing.Size(55, 20);
            this.iblGenre.TabIndex = 11;
            this.iblGenre.Text = "Genre";
            // 
            // iblPrice
            // 
            this.iblPrice.AutoSize = true;
            this.iblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.iblPrice.Location = new System.Drawing.Point(24, 228);
            this.iblPrice.Name = "iblPrice";
            this.iblPrice.Size = new System.Drawing.Size(48, 20);
            this.iblPrice.TabIndex = 14;
            this.iblPrice.Text = "Price";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 27);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(131, 222);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(270, 27);
            this.txtPrice.TabIndex = 21;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "action",
            "aventure",
            "rpg",
            "mmorpg",
            "pazzle",
            "sport",
            "racing",
            "FPS"});
            this.cbGenre.Location = new System.Drawing.Point(131, 168);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(270, 28);
            this.cbGenre.TabIndex = 22;
            // 
            // dgvGames
            // 
            this.dgvGames.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(467, 105);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.RowHeadersWidth = 51;
            this.dgvGames.RowTemplate.Height = 24;
            this.dgvGames.Size = new System.Drawing.Size(961, 265);
            this.dgvGames.TabIndex = 23;
            this.dgvGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGame_CellContentClick);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.LightGreen;
            this.btnCauta.Location = new System.Drawing.Point(951, 72);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(111, 30);
            this.btnCauta.TabIndex = 25;
            this.btnCauta.Text = "search";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(667, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 27);
            this.txtSearch.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 270);
            this.dataGridView1.TabIndex = 27;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(460, 693);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(284, 38);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Nr Total Games: 0";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.ForeColor = System.Drawing.Color.Red;
            this.lblPrice2.Location = new System.Drawing.Point(1211, 693);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(209, 38);
            this.lblPrice2.TabIndex = 29;
            this.lblPrice2.Text = "Total Price: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(471, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label2.Location = new System.Drawing.Point(471, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "GameStore";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1828, 806);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.iblPrice);
            this.Controls.Add(this.iblGenre);
            this.Controls.Add(this.btnListGames);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.iblReleaseDate);
            this.Controls.Add(this.iblDeveloper);
            this.Controls.Add(this.iblPublisher);
            this.Controls.Add(this.iblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iblName;
        private System.Windows.Forms.Label iblPublisher;
        private System.Windows.Forms.Label iblDeveloper;
        private System.Windows.Forms.Label iblReleaseDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnListGames;
        private System.Windows.Forms.Label iblGenre;
        private System.Windows.Forms.Label iblPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label lblTotal;
        private Label lblPrice2;
        private Label label1;
        private Label label2;
    }
}

