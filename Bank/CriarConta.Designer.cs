﻿namespace Bank
{
    partial class form_criarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_criarConta));
            this.txt_nomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select_cidade_agencia = new System.Windows.Forms.ComboBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_criar = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_agencia = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.txt_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_criar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nomeCompleto
            // 
            this.txt_nomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeCompleto.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeCompleto.Location = new System.Drawing.Point(27, 254);
            this.txt_nomeCompleto.Multiline = true;
            this.txt_nomeCompleto.Name = "txt_nomeCompleto";
            this.txt_nomeCompleto.Size = new System.Drawing.Size(270, 20);
            this.txt_nomeCompleto.TabIndex = 34;
            this.txt_nomeCompleto.Text = "Nome completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Criar conta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_cidade_agencia
            // 
            this.select_cidade_agencia.BackColor = System.Drawing.Color.White;
            this.select_cidade_agencia.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.select_cidade_agencia.FormattingEnabled = true;
            this.select_cidade_agencia.Location = new System.Drawing.Point(27, 458);
            this.select_cidade_agencia.Name = "select_cidade_agencia";
            this.select_cidade_agencia.Size = new System.Drawing.Size(188, 24);
            this.select_cidade_agencia.TabIndex = 41;
            this.select_cidade_agencia.Text = "Cidade";
            this.select_cidade_agencia.TextUpdate += new System.EventHandler(this.select_cidade_agencia_TextUpdate);
            this.select_cidade_agencia.DropDownClosed += new System.EventHandler(this.select_cidade_agencia_DropDownClosed);
            this.select_cidade_agencia.Leave += new System.EventHandler(this.select_cidade_agencia_Leave);
            // 
            // txt_idade
            // 
            this.txt_idade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idade.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idade.Location = new System.Drawing.Point(27, 358);
            this.txt_idade.Multiline = true;
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(130, 20);
            this.txt_idade.TabIndex = 43;
            this.txt_idade.Text = "Idade";
            // 
            // btn_criar
            // 
            this.btn_criar.BackColor = System.Drawing.Color.White;
            this.btn_criar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_criar.BackgroundImage")));
            this.btn_criar.Location = new System.Drawing.Point(168, 561);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(129, 36);
            this.btn_criar.TabIndex = 44;
            this.btn_criar.TabStop = false;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(27, 489);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(188, 1);
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(27, 386);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 1);
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(27, 333);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 1);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.Location = new System.Drawing.Point(27, 561);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 36);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(27, 281);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 1);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(12, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 415);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 342);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(168, 333);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 1);
            this.pictureBox7.TabIndex = 46;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(27, 437);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(270, 1);
            this.pictureBox9.TabIndex = 50;
            this.pictureBox9.TabStop = false;
            // 
            // txt_endereco
            // 
            this.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_endereco.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(27, 410);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(270, 20);
            this.txt_endereco.TabIndex = 49;
            this.txt_endereco.Text = "Endereço";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(27, 541);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(270, 1);
            this.pictureBox10.TabIndex = 52;
            this.pictureBox10.TabStop = false;
            // 
            // txt_senha
            // 
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(27, 514);
            this.txt_senha.Multiline = true;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(270, 20);
            this.txt_senha.TabIndex = 51;
            this.txt_senha.Text = "Senha";
            // 
            // txt_agencia
            // 
            this.txt_agencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_agencia.Enabled = false;
            this.txt_agencia.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agencia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_agencia.Location = new System.Drawing.Point(228, 461);
            this.txt_agencia.Multiline = true;
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(70, 20);
            this.txt_agencia.TabIndex = 54;
            this.txt_agencia.Text = "Agência";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(227, 489);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(70, 1);
            this.pictureBox8.TabIndex = 53;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(168, 385);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(130, 1);
            this.pictureBox11.TabIndex = 56;
            this.pictureBox11.TabStop = false;
            // 
            // txt_dataNasc
            // 
            this.txt_dataNasc.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_dataNasc.Location = new System.Drawing.Point(168, 356);
            this.txt_dataNasc.Mask = "00/00/0000";
            this.txt_dataNasc.Name = "txt_dataNasc";
            this.txt_dataNasc.Size = new System.Drawing.Size(130, 22);
            this.txt_dataNasc.TabIndex = 58;
            this.txt_dataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_telefone.Location = new System.Drawing.Point(168, 303);
            this.txt_telefone.Mask = "(00) 0 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(130, 22);
            this.txt_telefone.TabIndex = 59;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cpf.Location = new System.Drawing.Point(27, 303);
            this.txt_cpf.Mask = "000,000,000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(130, 22);
            this.txt_cpf.TabIndex = 60;
            // 
            // form_criarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 621);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_dataNasc);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.txt_agencia);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.select_cidade_agencia);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(340, 660);
            this.MinimumSize = new System.Drawing.Size(340, 660);
            this.Name = "form_criarConta";
            this.Text = "Bank - Criar Conta";
            ((System.ComponentModel.ISupportInitialize)(this.btn_criar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_nomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox select_cidade_agencia;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.PictureBox btn_criar;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_agencia;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.MaskedTextBox txt_dataNasc;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
    }
}