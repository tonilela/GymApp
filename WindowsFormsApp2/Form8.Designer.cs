namespace WindowsFormsApp2
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.listViewPonudaProizvoda = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewKosarica = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.labelUkupniRacun = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnIzbrisiKosaricu = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnIzdajRacun = new MaterialSkin.Controls.MaterialFlatButton();
            this.KosaricaPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.KosaricaPrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewPonudaProizvoda
            // 
            this.listViewPonudaProizvoda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPonudaProizvoda.Location = new System.Drawing.Point(36, 138);
            this.listViewPonudaProizvoda.Name = "listViewPonudaProizvoda";
            this.listViewPonudaProizvoda.Size = new System.Drawing.Size(542, 539);
            this.listViewPonudaProizvoda.TabIndex = 0;
            this.listViewPonudaProizvoda.UseCompatibleStateImageBehavior = false;
            this.listViewPonudaProizvoda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPonudaProizvoda_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime Proizvoda";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cijena";
            this.columnHeader3.Width = 100;
            // 
            // listViewKosarica
            // 
            this.listViewKosarica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewKosarica.Location = new System.Drawing.Point(795, 138);
            this.listViewKosarica.Name = "listViewKosarica";
            this.listViewKosarica.Size = new System.Drawing.Size(542, 330);
            this.listViewKosarica.TabIndex = 1;
            this.listViewKosarica.UseCompatibleStateImageBehavior = false;
            this.listViewKosarica.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewKosarica_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ime Proizvoda";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cijena";
            this.columnHeader5.Width = 62;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Količina";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(791, 543);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Ukupni račun";
            // 
            // labelUkupniRacun
            // 
            this.labelUkupniRacun.AutoSize = true;
            this.labelUkupniRacun.Depth = 0;
            this.labelUkupniRacun.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelUkupniRacun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUkupniRacun.Location = new System.Drawing.Point(1035, 543);
            this.labelUkupniRacun.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUkupniRacun.Name = "labelUkupniRacun";
            this.labelUkupniRacun.Size = new System.Drawing.Size(0, 24);
            this.labelUkupniRacun.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(644, 301);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 28);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIzbrisiKosaricu
            // 
            this.btnIzbrisiKosaricu.AutoSize = true;
            this.btnIzbrisiKosaricu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIzbrisiKosaricu.Depth = 0;
            this.btnIzbrisiKosaricu.Location = new System.Drawing.Point(795, 658);
            this.btnIzbrisiKosaricu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIzbrisiKosaricu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIzbrisiKosaricu.Name = "btnIzbrisiKosaricu";
            this.btnIzbrisiKosaricu.Primary = false;
            this.btnIzbrisiKosaricu.Size = new System.Drawing.Size(156, 36);
            this.btnIzbrisiKosaricu.TabIndex = 6;
            this.btnIzbrisiKosaricu.Text = "Izbriši košaricu";
            this.btnIzbrisiKosaricu.UseVisualStyleBackColor = true;
            this.btnIzbrisiKosaricu.Click += new System.EventHandler(this.btnIzbrisiKosaricu_Click);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.AutoSize = true;
            this.btnIzdajRacun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIzdajRacun.Depth = 0;
            this.btnIzdajRacun.Location = new System.Drawing.Point(1039, 658);
            this.btnIzdajRacun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIzdajRacun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Primary = false;
            this.btnIzdajRacun.Size = new System.Drawing.Size(121, 36);
            this.btnIzdajRacun.TabIndex = 7;
            this.btnIzdajRacun.Text = "Izdaj Račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // KosaricaPrintPreviewDialog
            // 
            this.KosaricaPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.KosaricaPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.KosaricaPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.KosaricaPrintPreviewDialog.Enabled = true;
            this.KosaricaPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("KosaricaPrintPreviewDialog.Icon")));
            this.KosaricaPrintPreviewDialog.Name = "KosaricaPrintPreviewDialog";
            this.KosaricaPrintPreviewDialog.Visible = false;
            // 
            // KosaricaPrintDocument
            // 
            this.KosaricaPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.KosaricaPrintDocument_PrintPage);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 753);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.btnIzbrisiKosaricu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelUkupniRacun);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listViewKosarica);
            this.Controls.Add(this.listViewPonudaProizvoda);
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Košarica";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPonudaProizvoda;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewKosarica;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel labelUkupniRacun;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialFlatButton btnIzbrisiKosaricu;
        private MaterialSkin.Controls.MaterialFlatButton btnIzdajRacun;
        private System.Windows.Forms.PrintPreviewDialog KosaricaPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument KosaricaPrintDocument;
    }
}