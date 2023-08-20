namespace Bank
{
    partial class form_recuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_recuperarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_novaSenha = new System.Windows.Forms.TextBox();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nomeCompleto = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.btn_alterar = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_alterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Alterar senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_novaSenha
            // 
            this.txt_novaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_novaSenha.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_novaSenha.Location = new System.Drawing.Point(27, 512);
            this.txt_novaSenha.Multiline = true;
            this.txt_novaSenha.Name = "txt_novaSenha";
            this.txt_novaSenha.Size = new System.Drawing.Size(270, 20);
            this.txt_novaSenha.TabIndex = 24;
            this.txt_novaSenha.Text = "Nova senha";
            // 
            // txt_conta
            // 
            this.txt_conta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_conta.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conta.Location = new System.Drawing.Point(27, 454);
            this.txt_conta.Multiline = true;
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(270, 20);
            this.txt_conta.TabIndex = 22;
            this.txt_conta.Text = "Conta";
            // 
            // txt_cpf
            // 
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpf.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(27, 399);
            this.txt_cpf.Multiline = true;
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(270, 20);
            this.txt_cpf.TabIndex = 26;
            this.txt_cpf.Text = "CPF";
            // 
            // txt_nomeCompleto
            // 
            this.txt_nomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeCompleto.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeCompleto.Location = new System.Drawing.Point(27, 346);
            this.txt_nomeCompleto.Multiline = true;
            this.txt_nomeCompleto.Name = "txt_nomeCompleto";
            this.txt_nomeCompleto.Size = new System.Drawing.Size(270, 20);
            this.txt_nomeCompleto.TabIndex = 28;
            this.txt_nomeCompleto.Text = "Nome completo";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.BackgroundImage = global::Bank.Properties.Resources.Cancelar_Button;
            this.btn_cancelar.Location = new System.Drawing.Point(27, 560);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 36);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackgroundImage = global::Bank.Properties.Resources.Alterar_Button;
            this.btn_alterar.Location = new System.Drawing.Point(168, 560);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(129, 36);
            this.btn_alterar.TabIndex = 30;
            this.btn_alterar.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(27, 373);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(270, 1);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(27, 426);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 1);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(27, 539);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(270, 1);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(27, 481);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 1);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(12, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 318);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bank.Properties.Resources.Background_Wallpaper_Toggle_Password;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // form_recuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 621);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txt_nomeCompleto);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txt_novaSenha);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_conta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(340, 660);
            this.MinimumSize = new System.Drawing.Size(340, 660);
            this.Name = "form_recuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank - Recuperar Senha";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_alterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txt_novaSenha;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txt_nomeCompleto;
        private System.Windows.Forms.PictureBox btn_alterar;
        private System.Windows.Forms.PictureBox btn_cancelar;
    }
}