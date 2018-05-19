namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtImePrezime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMobitel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAdresa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Ok = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbClanarine = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.labelDatumUpisa = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.labelPreostalodana = new MaterialSkin.Controls.MaterialLabel();
            this.btnProduzi = new MaterialSkin.Controls.MaterialFlatButton();
            this.KorisnikProduziPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.KorisnikProduziPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.btnIzbrisi = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Depth = 0;
            this.txtImePrezime.Hint = "";
            this.txtImePrezime.Location = new System.Drawing.Point(216, 131);
            this.txtImePrezime.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.PasswordChar = '\0';
            this.txtImePrezime.SelectedText = "";
            this.txtImePrezime.SelectionLength = 0;
            this.txtImePrezime.SelectionStart = 0;
            this.txtImePrezime.Size = new System.Drawing.Size(440, 28);
            this.txtImePrezime.TabIndex = 6;
            this.txtImePrezime.UseSystemPasswordChar = false;
            // 
            // txtMobitel
            // 
            this.txtMobitel.Depth = 0;
            this.txtMobitel.Hint = "";
            this.txtMobitel.Location = new System.Drawing.Point(216, 284);
            this.txtMobitel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMobitel.Name = "txtMobitel";
            this.txtMobitel.PasswordChar = '\0';
            this.txtMobitel.SelectedText = "";
            this.txtMobitel.SelectionLength = 0;
            this.txtMobitel.SelectionStart = 0;
            this.txtMobitel.Size = new System.Drawing.Size(440, 28);
            this.txtMobitel.TabIndex = 8;
            this.txtMobitel.UseSystemPasswordChar = false;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Depth = 0;
            this.txtAdresa.Hint = "";
            this.txtAdresa.Location = new System.Drawing.Point(216, 209);
            this.txtAdresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PasswordChar = '\0';
            this.txtAdresa.SelectedText = "";
            this.txtAdresa.SelectionLength = 0;
            this.txtAdresa.SelectionStart = 0;
            this.txtAdresa.Size = new System.Drawing.Size(440, 28);
            this.txtAdresa.TabIndex = 7;
            this.txtAdresa.UseSystemPasswordChar = false;
            // 
            // Ok
            // 
            this.Ok.AutoSize = true;
            this.Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ok.Depth = 0;
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(990, 563);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ok.Name = "Ok";
            this.Ok.Primary = false;
            this.Ok.Size = new System.Drawing.Size(36, 36);
            this.Ok.TabIndex = 10;
            this.Ok.Text = "ok";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Ime I prezime";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(20, 209);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Adresa";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 288);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Mobitel";
            // 
            // cmbClanarine
            // 
            this.cmbClanarine.FormattingEnabled = true;
            this.cmbClanarine.Location = new System.Drawing.Point(270, 374);
            this.cmbClanarine.Name = "cmbClanarine";
            this.cmbClanarine.Size = new System.Drawing.Size(332, 24);
            this.cmbClanarine.TabIndex = 9;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(20, 374);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Vrsta Članarine";
            // 
            // labelDatumUpisa
            // 
            this.labelDatumUpisa.AutoSize = true;
            this.labelDatumUpisa.Depth = 0;
            this.labelDatumUpisa.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDatumUpisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDatumUpisa.Location = new System.Drawing.Point(1012, 190);
            this.labelDatumUpisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDatumUpisa.Name = "labelDatumUpisa";
            this.labelDatumUpisa.Size = new System.Drawing.Size(0, 24);
            this.labelDatumUpisa.TabIndex = 9;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(795, 190);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Datum Upisa";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(795, 284);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(137, 24);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Preostalo dana";
            // 
            // labelPreostalodana
            // 
            this.labelPreostalodana.AutoSize = true;
            this.labelPreostalodana.Depth = 0;
            this.labelPreostalodana.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPreostalodana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPreostalodana.Location = new System.Drawing.Point(1012, 284);
            this.labelPreostalodana.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPreostalodana.Name = "labelPreostalodana";
            this.labelPreostalodana.Size = new System.Drawing.Size(0, 24);
            this.labelPreostalodana.TabIndex = 12;
            // 
            // btnProduzi
            // 
            this.btnProduzi.AutoSize = true;
            this.btnProduzi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProduzi.BackColor = System.Drawing.SystemColors.Control;
            this.btnProduzi.Depth = 0;
            this.btnProduzi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnProduzi.Location = new System.Drawing.Point(718, 563);
            this.btnProduzi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProduzi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProduzi.Name = "btnProduzi";
            this.btnProduzi.Primary = false;
            this.btnProduzi.Size = new System.Drawing.Size(183, 36);
            this.btnProduzi.TabIndex = 11;
            this.btnProduzi.Text = "Produži Članarinu";
            this.btnProduzi.UseVisualStyleBackColor = false;
            // 
            // KorisnikProduziPrintPreviewDialog
            // 
            this.KorisnikProduziPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.KorisnikProduziPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.KorisnikProduziPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.KorisnikProduziPrintPreviewDialog.Enabled = true;
            this.KorisnikProduziPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("KorisnikProduziPrintPreviewDialog.Icon")));
            this.KorisnikProduziPrintPreviewDialog.Name = "KosaricaPrintPreviewDialog";
            this.KorisnikProduziPrintPreviewDialog.Visible = false;
            // 
            // KorisnikProduziPrintDocument
            // 
            this.KorisnikProduziPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.KorisnikProduziPrintDocument_PrintPage);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.AutoSize = true;
            this.btnIzbrisi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIzbrisi.BackColor = System.Drawing.Color.Red;
            this.btnIzbrisi.Depth = 0;
            this.btnIzbrisi.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnIzbrisi.Location = new System.Drawing.Point(171, 563);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIzbrisi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Primary = false;
            this.btnIzbrisi.Size = new System.Drawing.Size(162, 36);
            this.btnIzbrisi.TabIndex = 12;
            this.btnIzbrisi.Text = "Izbriši Korisnika";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 638);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnProduzi);
            this.Controls.Add(this.labelPreostalodana);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.labelDatumUpisa);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.cmbClanarine);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtMobitel);
            this.Controls.Add(this.txtImePrezime);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtImePrezime;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMobitel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdresa;
        private MaterialSkin.Controls.MaterialFlatButton Ok;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cmbClanarine;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel labelDatumUpisa;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel labelPreostalodana;
        private MaterialSkin.Controls.MaterialFlatButton btnProduzi;
        private System.Windows.Forms.PrintPreviewDialog KorisnikProduziPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument KorisnikProduziPrintDocument;
        private MaterialSkin.Controls.MaterialFlatButton btnIzbrisi;
    }
}