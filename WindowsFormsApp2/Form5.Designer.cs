namespace WindowsFormsApp2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbClanarine = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Ok = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtAdresa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMobitel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtImePrezime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.KorisnikNoviPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.KorisnikNoviPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(213, 454);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Vrsta Članarine";
            // 
            // cmbClanarine
            // 
            this.cmbClanarine.FormattingEnabled = true;
            this.cmbClanarine.Location = new System.Drawing.Point(409, 454);
            this.cmbClanarine.Name = "cmbClanarine";
            this.cmbClanarine.Size = new System.Drawing.Size(248, 24);
            this.cmbClanarine.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(213, 342);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Mobitel";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(213, 234);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Adresa";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(213, 136);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Ime I prezime";
            // 
            // Ok
            // 
            this.Ok.AutoSize = true;
            this.Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ok.Depth = 0;
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(960, 529);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ok.Name = "Ok";
            this.Ok.Primary = false;
            this.Ok.Size = new System.Drawing.Size(75, 36);
            this.Ok.TabIndex = 8;
            this.Ok.Text = "Spremi";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Depth = 0;
            this.txtAdresa.Hint = "";
            this.txtAdresa.Location = new System.Drawing.Point(409, 234);
            this.txtAdresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PasswordChar = '\0';
            this.txtAdresa.SelectedText = "";
            this.txtAdresa.SelectionLength = 0;
            this.txtAdresa.SelectionStart = 0;
            this.txtAdresa.Size = new System.Drawing.Size(523, 28);
            this.txtAdresa.TabIndex = 5;
            this.txtAdresa.UseSystemPasswordChar = false;
            // 
            // txtMobitel
            // 
            this.txtMobitel.Depth = 0;
            this.txtMobitel.Hint = "";
            this.txtMobitel.Location = new System.Drawing.Point(409, 338);
            this.txtMobitel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMobitel.Name = "txtMobitel";
            this.txtMobitel.PasswordChar = '\0';
            this.txtMobitel.SelectedText = "";
            this.txtMobitel.SelectionLength = 0;
            this.txtMobitel.SelectionStart = 0;
            this.txtMobitel.Size = new System.Drawing.Size(318, 28);
            this.txtMobitel.TabIndex = 6;
            this.txtMobitel.UseSystemPasswordChar = false;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Depth = 0;
            this.txtImePrezime.Hint = "";
            this.txtImePrezime.Location = new System.Drawing.Point(409, 136);
            this.txtImePrezime.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.PasswordChar = '\0';
            this.txtImePrezime.SelectedText = "";
            this.txtImePrezime.SelectionLength = 0;
            this.txtImePrezime.SelectionStart = 0;
            this.txtImePrezime.Size = new System.Drawing.Size(401, 28);
            this.txtImePrezime.TabIndex = 4;
            this.txtImePrezime.UseSystemPasswordChar = false;
            // 
            // KorisnikNoviPrintPreviewDialog
            // 
            this.KorisnikNoviPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.KorisnikNoviPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.KorisnikNoviPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.KorisnikNoviPrintPreviewDialog.Enabled = true;
            this.KorisnikNoviPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("KorisnikNoviPrintPreviewDialog.Icon")));
            this.KorisnikNoviPrintPreviewDialog.Name = "KosaricaPrintPreviewDialog";
            this.KorisnikNoviPrintPreviewDialog.Visible = false;
            // 
            // KorisnikNoviPrintDocument
            // 
            this.KorisnikNoviPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.KorisnikNoviPrintDocument_PrintPage);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 638);
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
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cmbClanarine;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton Ok;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdresa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMobitel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImePrezime;
        private System.Windows.Forms.PrintPreviewDialog KorisnikNoviPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument KorisnikNoviPrintDocument;
    }
}