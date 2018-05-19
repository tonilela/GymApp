namespace WindowsFormsApp2
{
    partial class Form4
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
            this.txtCjena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIme = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.spremi = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtCjena
            // 
            this.txtCjena.Depth = 0;
            this.txtCjena.Hint = "";
            this.txtCjena.Location = new System.Drawing.Point(239, 213);
            this.txtCjena.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCjena.Name = "txtCjena";
            this.txtCjena.PasswordChar = '\0';
            this.txtCjena.SelectedText = "";
            this.txtCjena.SelectionLength = 0;
            this.txtCjena.SelectionStart = 0;
            this.txtCjena.Size = new System.Drawing.Size(293, 28);
            this.txtCjena.TabIndex = 3;
            this.txtCjena.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(39, 213);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Cjena";
            // 
            // txtIme
            // 
            this.txtIme.Depth = 0;
            this.txtIme.Hint = "";
            this.txtIme.Location = new System.Drawing.Point(239, 125);
            this.txtIme.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIme.Name = "txtIme";
            this.txtIme.PasswordChar = '\0';
            this.txtIme.SelectedText = "";
            this.txtIme.SelectionLength = 0;
            this.txtIme.SelectionStart = 0;
            this.txtIme.Size = new System.Drawing.Size(293, 28);
            this.txtIme.TabIndex = 2;
            this.txtIme.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(39, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Ime";
            // 
            // spremi
            // 
            this.spremi.AutoSize = true;
            this.spremi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.spremi.Depth = 0;
            this.spremi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.spremi.Location = new System.Drawing.Point(496, 352);
            this.spremi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.spremi.MouseState = MaterialSkin.MouseState.HOVER;
            this.spremi.Name = "spremi";
            this.spremi.Primary = false;
            this.spremi.Size = new System.Drawing.Size(36, 36);
            this.spremi.TabIndex = 4;
            this.spremi.Text = "Ok";
            this.spremi.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 455);
            this.Controls.Add(this.txtCjena);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.spremi);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Članarina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtCjena;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIme;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton spremi;
    }
}