namespace WindowsFormsApp2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPreostalo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNovi = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtPretraziId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnProizvoidi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnKosarica = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRacuni = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.colPreostalo,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(54, 205);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1161, 283);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime i Prezime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mob";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // colPreostalo
            // 
            this.colPreostalo.Text = "Preostalo Dana";
            this.colPreostalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPreostalo.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "cjena";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(71, 551);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(164, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Vrste Clanarina";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.AutoSize = true;
            this.btnNovi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovi.Depth = 0;
            this.btnNovi.Location = new System.Drawing.Point(1020, 107);
            this.btnNovi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Primary = false;
            this.btnNovi.Size = new System.Drawing.Size(134, 36);
            this.btnNovi.TabIndex = 2;
            this.btnNovi.Text = "Novi Korisnik";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // txtPretraziId
            // 
            this.txtPretraziId.Depth = 0;
            this.txtPretraziId.Hint = "";
            this.txtPretraziId.Location = new System.Drawing.Point(234, 112);
            this.txtPretraziId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPretraziId.Name = "txtPretraziId";
            this.txtPretraziId.PasswordChar = '\0';
            this.txtPretraziId.SelectedText = "";
            this.txtPretraziId.SelectionLength = 0;
            this.txtPretraziId.SelectionStart = 0;
            this.txtPretraziId.Size = new System.Drawing.Size(336, 28);
            this.txtPretraziId.TabIndex = 1;
            this.txtPretraziId.UseSystemPasswordChar = false;
            this.txtPretraziId.TextChanged += new System.EventHandler(this.txtPretraziId_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(50, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Pronađi Korisnika";
            // 
            // btnProizvoidi
            // 
            this.btnProizvoidi.AutoSize = true;
            this.btnProizvoidi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProizvoidi.Depth = 0;
            this.btnProizvoidi.Location = new System.Drawing.Point(315, 551);
            this.btnProizvoidi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProizvoidi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProizvoidi.Name = "btnProizvoidi";
            this.btnProizvoidi.Primary = false;
            this.btnProizvoidi.Size = new System.Drawing.Size(101, 36);
            this.btnProizvoidi.TabIndex = 4;
            this.btnProizvoidi.Text = "Proizvodi";
            this.btnProizvoidi.UseVisualStyleBackColor = true;
            this.btnProizvoidi.Click += new System.EventHandler(this.btnProizvoidi_Click);
            // 
            // btnKosarica
            // 
            this.btnKosarica.AutoSize = true;
            this.btnKosarica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKosarica.Depth = 0;
            this.btnKosarica.Location = new System.Drawing.Point(519, 551);
            this.btnKosarica.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKosarica.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Primary = false;
            this.btnKosarica.Size = new System.Drawing.Size(96, 36);
            this.btnKosarica.TabIndex = 5;
            this.btnKosarica.Text = "Košarica";
            this.btnKosarica.UseVisualStyleBackColor = true;
            this.btnKosarica.Click += new System.EventHandler(this.btnKosarica_Click);
            // 
            // btnRacuni
            // 
            this.btnRacuni.AutoSize = true;
            this.btnRacuni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRacuni.Depth = 0;
            this.btnRacuni.Location = new System.Drawing.Point(1058, 541);
            this.btnRacuni.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRacuni.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Primary = false;
            this.btnRacuni.Size = new System.Drawing.Size(105, 36);
            this.btnRacuni.TabIndex = 6;
            this.btnRacuni.Text = "Svi Računi";
            this.btnRacuni.UseVisualStyleBackColor = true;
            this.btnRacuni.Click += new System.EventHandler(this.btnRacuni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 638);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnKosarica);
            this.Controls.Add(this.btnProizvoidi);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPretraziId);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader colPreostalo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btnNovi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPretraziId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnProizvoidi;
        private MaterialSkin.Controls.MaterialFlatButton btnKosarica;
        private MaterialSkin.Controls.MaterialFlatButton btnRacuni;
    }
}

