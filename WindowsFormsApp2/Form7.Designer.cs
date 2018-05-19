namespace WindowsFormsApp2
{
    partial class Form7
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
            this.txtCjenaProizvoda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtImeProizvoda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnIzbrisiProivod = new MaterialSkin.Controls.MaterialFlatButton();
            this.spremi = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtbOpisProizvoda = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtCjenaProizvoda
            // 
            this.txtCjenaProizvoda.Depth = 0;
            this.txtCjenaProizvoda.Hint = "";
            this.txtCjenaProizvoda.Location = new System.Drawing.Point(236, 209);
            this.txtCjenaProizvoda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCjenaProizvoda.Name = "txtCjenaProizvoda";
            this.txtCjenaProizvoda.PasswordChar = '\0';
            this.txtCjenaProizvoda.SelectedText = "";
            this.txtCjenaProizvoda.SelectionLength = 0;
            this.txtCjenaProizvoda.SelectionStart = 0;
            this.txtCjenaProizvoda.Size = new System.Drawing.Size(293, 28);
            this.txtCjenaProizvoda.TabIndex = 4;
            this.txtCjenaProizvoda.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(36, 209);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Cjena";
            // 
            // txtImeProizvoda
            // 
            this.txtImeProizvoda.Depth = 0;
            this.txtImeProizvoda.Hint = "";
            this.txtImeProizvoda.Location = new System.Drawing.Point(236, 138);
            this.txtImeProizvoda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImeProizvoda.Name = "txtImeProizvoda";
            this.txtImeProizvoda.PasswordChar = '\0';
            this.txtImeProizvoda.SelectedText = "";
            this.txtImeProizvoda.SelectionLength = 0;
            this.txtImeProizvoda.SelectionStart = 0;
            this.txtImeProizvoda.Size = new System.Drawing.Size(664, 28);
            this.txtImeProizvoda.TabIndex = 3;
            this.txtImeProizvoda.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 138);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Ime Proizvoda";
            // 
            // btnIzbrisiProivod
            // 
            this.btnIzbrisiProivod.AutoSize = true;
            this.btnIzbrisiProivod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIzbrisiProivod.Depth = 0;
            this.btnIzbrisiProivod.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnIzbrisiProivod.Location = new System.Drawing.Point(547, 541);
            this.btnIzbrisiProivod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIzbrisiProivod.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIzbrisiProivod.Name = "btnIzbrisiProivod";
            this.btnIzbrisiProivod.Primary = false;
            this.btnIzbrisiProivod.Size = new System.Drawing.Size(157, 36);
            this.btnIzbrisiProivod.TabIndex = 7;
            this.btnIzbrisiProivod.Text = "izbriši Proizvod";
            this.btnIzbrisiProivod.UseVisualStyleBackColor = true;
            // 
            // spremi
            // 
            this.spremi.AutoSize = true;
            this.spremi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.spremi.Depth = 0;
            this.spremi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.spremi.Location = new System.Drawing.Point(825, 541);
            this.spremi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.spremi.MouseState = MaterialSkin.MouseState.HOVER;
            this.spremi.Name = "spremi";
            this.spremi.Primary = false;
            this.spremi.Size = new System.Drawing.Size(75, 36);
            this.spremi.TabIndex = 6;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            // 
            // txtbOpisProizvoda
            // 
            this.txtbOpisProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbOpisProizvoda.Location = new System.Drawing.Point(236, 277);
            this.txtbOpisProizvoda.Multiline = true;
            this.txtbOpisProizvoda.Name = "txtbOpisProizvoda";
            this.txtbOpisProizvoda.Size = new System.Drawing.Size(664, 235);
            this.txtbOpisProizvoda.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(36, 277);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(138, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Opis Proizvoda";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 647);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtbOpisProizvoda);
            this.Controls.Add(this.txtCjenaProizvoda);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtImeProizvoda);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnIzbrisiProivod);
            this.Controls.Add(this.spremi);
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Proizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtCjenaProizvoda;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImeProizvoda;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnIzbrisiProivod;
        private MaterialSkin.Controls.MaterialFlatButton spremi;
        private System.Windows.Forms.TextBox txtbOpisProizvoda;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}