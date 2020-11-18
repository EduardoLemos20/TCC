namespace Back
{
    partial class cadastroC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroC));
            this.button1 = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.principal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(73, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 21);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.AccessibleDescription = "";
            this.txtTelefone.AccessibleName = "";
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(147, 78);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(202, 23);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleDescription = "";
            this.txtSenha.AccessibleName = "";
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(126, 117);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(223, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.Color.Transparent;
            this.principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.principal.FlatAppearance.BorderSize = 0;
            this.principal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.principal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.principal.Location = new System.Drawing.Point(35, 246);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(328, 26);
            this.principal.TabIndex = 7;
            this.principal.UseVisualStyleBackColor = false;
            this.principal.Click += new System.EventHandler(this.principal_Click);
            // 
            // cadastroC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 455);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.button1);
            this.Name = "cadastroC";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button principal;
    }
}