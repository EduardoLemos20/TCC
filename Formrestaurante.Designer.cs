namespace Back
{
    partial class FormRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestaurante));
            this.txtEmailrestaurante = new System.Windows.Forms.TextBox();
            this.txtSenharestaurante = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.principal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailrestaurante
            // 
            this.txtEmailrestaurante.AccessibleDescription = "";
            this.txtEmailrestaurante.AccessibleName = "";
            this.txtEmailrestaurante.BackColor = System.Drawing.Color.White;
            this.txtEmailrestaurante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailrestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailrestaurante.Location = new System.Drawing.Point(119, 82);
            this.txtEmailrestaurante.Name = "txtEmailrestaurante";
            this.txtEmailrestaurante.Size = new System.Drawing.Size(237, 23);
            this.txtEmailrestaurante.TabIndex = 1;
            // 
            // txtSenharestaurante
            // 
            this.txtSenharestaurante.AccessibleDescription = "";
            this.txtSenharestaurante.AccessibleName = "";
            this.txtSenharestaurante.BackColor = System.Drawing.Color.White;
            this.txtSenharestaurante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenharestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenharestaurante.Location = new System.Drawing.Point(119, 122);
            this.txtSenharestaurante.Name = "txtSenharestaurante";
            this.txtSenharestaurante.PasswordChar = '*';
            this.txtSenharestaurante.Size = new System.Drawing.Size(237, 23);
            this.txtSenharestaurante.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(73, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 21);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.Color.Transparent;
            this.principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.principal.FlatAppearance.BorderSize = 0;
            this.principal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.principal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.principal.Location = new System.Drawing.Point(32, 255);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(333, 26);
            this.principal.TabIndex = 8;
            this.principal.UseVisualStyleBackColor = false;
            this.principal.Click += new System.EventHandler(this.principal_Click);
            // 
            // FormRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 470);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenharestaurante);
            this.Controls.Add(this.txtEmailrestaurante);
            this.Name = "FormRestaurante";
            this.Text = "Formrestaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailrestaurante;
        private System.Windows.Forms.TextBox txtSenharestaurante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button principal;
    }
}