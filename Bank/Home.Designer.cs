namespace Bank
{
    partial class Home
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
            this.lb_titular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_saldo = new System.Windows.Forms.Label();
            this.lb_limite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tl_extrato = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.PictureBox();
            this.btn_sacar = new System.Windows.Forms.PictureBox();
            this.btn_depositar = new System.Windows.Forms.PictureBox();
            this.btn_pix = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_transferir = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sacar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_depositar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_transferir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titular
            // 
            this.lb_titular.AutoSize = true;
            this.lb_titular.BackColor = System.Drawing.Color.Black;
            this.lb_titular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titular.ForeColor = System.Drawing.Color.White;
            this.lb_titular.Location = new System.Drawing.Point(12, 24);
            this.lb_titular.Name = "lb_titular";
            this.lb_titular.Size = new System.Drawing.Size(79, 20);
            this.lb_titular.TabIndex = 22;
            this.lb_titular.Text = "Olá User";
            this.lb_titular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_titular.Click += new System.EventHandler(this.lb_titular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Saldo:";
            // 
            // lb_saldo
            // 
            this.lb_saldo.AutoSize = true;
            this.lb_saldo.BackColor = System.Drawing.Color.White;
            this.lb_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lb_saldo.Location = new System.Drawing.Point(35, 100);
            this.lb_saldo.Name = "lb_saldo";
            this.lb_saldo.Size = new System.Drawing.Size(65, 17);
            this.lb_saldo.TabIndex = 27;
            this.lb_saldo.Text = "R$ 0,00";
            // 
            // lb_limite
            // 
            this.lb_limite.AutoSize = true;
            this.lb_limite.BackColor = System.Drawing.Color.Black;
            this.lb_limite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lb_limite.ForeColor = System.Drawing.Color.White;
            this.lb_limite.Location = new System.Drawing.Point(35, 151);
            this.lb_limite.Name = "lb_limite";
            this.lb_limite.Size = new System.Drawing.Size(65, 17);
            this.lb_limite.TabIndex = 30;
            this.lb_limite.Text = "R$ 0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Limite mensal:";
            // 
            // tl_extrato
            // 
            this.tl_extrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tl_extrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl_extrato.FormattingEnabled = true;
            this.tl_extrato.Items.AddRange(new object[] {
            "I"});
            this.tl_extrato.Location = new System.Drawing.Point(26, 308);
            this.tl_extrato.Name = "tl_extrato";
            this.tl_extrato.Size = new System.Drawing.Size(274, 260);
            this.tl_extrato.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(134, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Extrato";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(26, 263);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 1);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.White;
            this.btn_sair.BackgroundImage = global::Bank.Properties.Resources.Logout_Button;
            this.btn_sair.Location = new System.Drawing.Point(12, 577);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(300, 32);
            this.btn_sair.TabIndex = 35;
            this.btn_sair.TabStop = false;
            // 
            // btn_sacar
            // 
            this.btn_sacar.BackColor = System.Drawing.Color.White;
            this.btn_sacar.BackgroundImage = global::Bank.Properties.Resources.Sacar_Button;
            this.btn_sacar.Location = new System.Drawing.Point(166, 182);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(64, 64);
            this.btn_sacar.TabIndex = 33;
            this.btn_sacar.TabStop = false;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // btn_depositar
            // 
            this.btn_depositar.BackColor = System.Drawing.Color.White;
            this.btn_depositar.BackgroundImage = global::Bank.Properties.Resources.Depositar_Button;
            this.btn_depositar.Location = new System.Drawing.Point(96, 182);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(64, 64);
            this.btn_depositar.TabIndex = 32;
            this.btn_depositar.TabStop = false;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // btn_pix
            // 
            this.btn_pix.BackColor = System.Drawing.Color.White;
            this.btn_pix.BackgroundImage = global::Bank.Properties.Resources.Pix_Button;
            this.btn_pix.Location = new System.Drawing.Point(236, 182);
            this.btn_pix.Name = "btn_pix";
            this.btn_pix.Size = new System.Drawing.Size(64, 64);
            this.btn_pix.TabIndex = 31;
            this.btn_pix.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(26, 131);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(274, 45);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // btn_transferir
            // 
            this.btn_transferir.BackColor = System.Drawing.Color.White;
            this.btn_transferir.BackgroundImage = global::Bank.Properties.Resources.Transferir_Button1;
            this.btn_transferir.Location = new System.Drawing.Point(26, 182);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(64, 64);
            this.btn_transferir.TabIndex = 25;
            this.btn_transferir.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(26, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(274, 45);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Bank.Properties.Resources.Logo_SmallSize_White;
            this.pictureBox1.Location = new System.Drawing.Point(269, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 23);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(12, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 506);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tl_extrato);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_sacar);
            this.Controls.Add(this.btn_depositar);
            this.Controls.Add(this.btn_pix);
            this.Controls.Add(this.lb_limite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lb_saldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_transferir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_titular);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(340, 660);
            this.MinimumSize = new System.Drawing.Size(340, 660);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sacar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_depositar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_transferir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_titular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btn_transferir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_saldo;
        private System.Windows.Forms.Label lb_limite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox btn_pix;
        private System.Windows.Forms.PictureBox btn_depositar;
        private System.Windows.Forms.PictureBox btn_sacar;
        private System.Windows.Forms.PictureBox btn_sair;
        private System.Windows.Forms.ListBox tl_extrato;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
    }
}