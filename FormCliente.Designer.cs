namespace Back
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmsenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "";
            this.txtNome.AccessibleName = "";
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(115, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.AccessibleDescription = "";
            this.txtTelefone.AccessibleName = "";
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(143, 111);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(184, 23);
            this.txtTelefone.TabIndex = 0;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "";
            this.txtEmail.AccessibleName = "";
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(115, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 23);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleDescription = "";
            this.txtSenha.AccessibleName = "";
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(115, 190);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(212, 23);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtConfirmsenha
            // 
            this.txtConfirmsenha.AccessibleDescription = "";
            this.txtConfirmsenha.AccessibleName = "";
            this.txtConfirmsenha.BackColor = System.Drawing.Color.White;
            this.txtConfirmsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmsenha.Location = new System.Drawing.Point(223, 228);
            this.txtConfirmsenha.Name = "txtConfirmsenha";
            this.txtConfirmsenha.PasswordChar = '*';
            this.txtConfirmsenha.Size = new System.Drawing.Size(104, 23);
            this.txtConfirmsenha.TabIndex = 0;
            this.txtConfirmsenha.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(26, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 31);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConfirmsenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmsenha;
        private System.Windows.Forms.Button button1;
    }
}