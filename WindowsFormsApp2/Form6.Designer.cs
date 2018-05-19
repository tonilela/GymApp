namespace WindowsFormsApp2
{
    partial class Form6
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
            this.listViewPrizvodi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNoviProizvod = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // listViewPrizvodi
            // 
            this.listViewPrizvodi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewPrizvodi.Location = new System.Drawing.Point(25, 114);
            this.listViewPrizvodi.Name = "listViewPrizvodi";
            this.listViewPrizvodi.Size = new System.Drawing.Size(955, 373);
            this.listViewPrizvodi.TabIndex = 0;
            this.listViewPrizvodi.UseCompatibleStateImageBehavior = false;
            this.listViewPrizvodi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPrizvodi_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime Proizvoda";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opis";
            this.columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cijena";
            // 
            // btnNoviProizvod
            // 
            this.btnNoviProizvod.AutoSize = true;
            this.btnNoviProizvod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoviProizvod.Depth = 0;
            this.btnNoviProizvod.Location = new System.Drawing.Point(739, 537);
            this.btnNoviProizvod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNoviProizvod.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNoviProizvod.Name = "btnNoviProizvod";
            this.btnNoviProizvod.Primary = false;
            this.btnNoviProizvod.Size = new System.Drawing.Size(200, 36);
            this.btnNoviProizvod.TabIndex = 17;
            this.btnNoviProizvod.Text = "Dodaj Novi proizvod";
            this.btnNoviProizvod.UseVisualStyleBackColor = true;
            this.btnNoviProizvod.Click += new System.EventHandler(this.btnNoviProizvod_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 605);
            this.Controls.Add(this.btnNoviProizvod);
            this.Controls.Add(this.listViewPrizvodi);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPrizvodi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialFlatButton btnNoviProizvod;
    }
}