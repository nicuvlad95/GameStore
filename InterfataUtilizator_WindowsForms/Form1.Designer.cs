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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.Cart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
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
            this.iblName.Click += new System.EventHandler(this.label1_Click);
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
            this.btnAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAddGame.Location = new System.Drawing.Point(28, 289);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(113, 63);
            this.btnAddGame.TabIndex = 9;
            this.btnAddGame.Text = "AddGame";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListGames
            // 
            this.btnListGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnListGames.Location = new System.Drawing.Point(166, 289);
            this.btnListGames.Name = "btnListGames";
            this.btnListGames.Size = new System.Drawing.Size(235, 63);
            this.btnListGames.TabIndex = 10;
            this.btnListGames.Text = "ListGames";
            this.btnListGames.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "action",
            "aventure",
            "rpg",
            "mmorpg",
            "pazzle",
            "sport"});
            this.comboBox1.Location = new System.Drawing.Point(131, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 22;
            // 
            // dgvGames
            // 
            this.dgvGames.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(467, 91);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.RowHeadersWidth = 51;
            this.dgvGames.RowTemplate.Height = 24;
            this.dgvGames.Size = new System.Drawing.Size(769, 374);
            this.dgvGames.TabIndex = 23;
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.Color.LightCoral;
            this.Cart.Location = new System.Drawing.Point(1141, 13);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(95, 45);
            this.Cart.TabIndex = 24;
            this.Cart.Text = "Cart";
            this.Cart.UseMnemonic = false;
            this.Cart.UseVisualStyleBackColor = false;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 492);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Button Cart;
    }
}

