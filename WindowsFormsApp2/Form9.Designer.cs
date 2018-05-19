namespace WindowsFormsApp2
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.listViewProizvodi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewKorisnici = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRacuniProizvodi = new MaterialSkin.Controls.MaterialLabel();
            this.txtRacuniKorisnici = new MaterialSkin.Controls.MaterialLabel();
            this.ProizvodiPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.ProizvodiPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.KorisniciPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.KorisniciPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // listViewProizvodi
            // 
            this.listViewProizvodi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProizvodi.Location = new System.Drawing.Point(66, 152);
            this.listViewProizvodi.Name = "listViewProizvodi";
            this.listViewProizvodi.Size = new System.Drawing.Size(468, 451);
            this.listViewProizvodi.TabIndex = 0;
            this.listViewProizvodi.UseCompatibleStateImageBehavior = false;
            this.listViewProizvodi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProizvodi_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Datum ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cijena";
            this.columnHeader3.Width = 80;
            // 
            // listViewKorisnici
            // 
            this.listViewKorisnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewKorisnici.Location = new System.Drawing.Point(663, 152);
            this.listViewKorisnici.Name = "listViewKorisnici";
            this.listViewKorisnici.Size = new System.Drawing.Size(468, 451);
            this.listViewKorisnici.TabIndex = 1;
            this.listViewKorisnici.UseCompatibleStateImageBehavior = false;
            this.listViewKorisnici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewKorisnici_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ime i Prezime";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cijena";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(62, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(151, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Računi Proizvodi";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(659, 89);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Računi Korisnici";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(62, 666);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(274, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Ukupni Iznos Računa Proizvoda";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(659, 666);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(201, 24);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Ukupni Iznos Članarina";
            // 
            // txtRacuniProizvodi
            // 
            this.txtRacuniProizvodi.AutoSize = true;
            this.txtRacuniProizvodi.Depth = 0;
            this.txtRacuniProizvodi.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtRacuniProizvodi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRacuniProizvodi.Location = new System.Drawing.Point(398, 666);
            this.txtRacuniProizvodi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRacuniProizvodi.Name = "txtRacuniProizvodi";
            this.txtRacuniProizvodi.Size = new System.Drawing.Size(0, 24);
            this.txtRacuniProizvodi.TabIndex = 6;
            // 
            // txtRacuniKorisnici
            // 
            this.txtRacuniKorisnici.AutoSize = true;
            this.txtRacuniKorisnici.Depth = 0;
            this.txtRacuniKorisnici.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtRacuniKorisnici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRacuniKorisnici.Location = new System.Drawing.Point(995, 666);
            this.txtRacuniKorisnici.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRacuniKorisnici.Name = "txtRacuniKorisnici";
            this.txtRacuniKorisnici.Size = new System.Drawing.Size(0, 24);
            this.txtRacuniKorisnici.TabIndex = 7;
            // 
            // ProizvodiPrintPreviewDialog
            // 
            this.ProizvodiPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ProizvodiPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ProizvodiPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ProizvodiPrintPreviewDialog.Enabled = true;
            this.ProizvodiPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ProizvodiPrintPreviewDialog.Icon")));
            this.ProizvodiPrintPreviewDialog.Name = "ProizvodiPrintPreviewDialog";
            this.ProizvodiPrintPreviewDialog.Visible = false;
            // 
            // KorisniciPrintPreviewDialog
            // 
            this.KorisniciPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.KorisniciPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.KorisniciPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.KorisniciPrintPreviewDialog.Enabled = true;
            this.KorisniciPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("KorisniciPrintPreviewDialog.Icon")));
            this.KorisniciPrintPreviewDialog.Name = "KorisniciPrintPreviewDialog";
            this.KorisniciPrintPreviewDialog.Visible = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 761);
            this.Controls.Add(this.txtRacuniKorisnici);
            this.Controls.Add(this.txtRacuniProizvodi);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listViewKorisnici);
            this.Controls.Add(this.listViewProizvodi);
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProizvodi;
        private System.Windows.Forms.ListView listViewKorisnici;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel txtRacuniProizvodi;
        private MaterialSkin.Controls.MaterialLabel txtRacuniKorisnici;
        private System.Windows.Forms.PrintPreviewDialog ProizvodiPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument ProizvodiPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog KorisniciPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument KorisniciPrintDocument;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}