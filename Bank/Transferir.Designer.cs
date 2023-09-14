namespace Bank
{
    partial class Transferir
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
            this.txt_valorTranferencia = new System.Windows.Forms.TextBox();
            this.txt_contaDestinatario = new System.Windows.Forms.TextBox();
            this.btn_transferir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_transferir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titular
            // 
            this.lb_titular.AutoSize = true;
            this.lb_titular.BackColor = System.Drawing.Color.Black;
            this.lb_titular.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titular.ForeColor = System.Drawing.Color.White;
            this.lb_titular.Location = new System.Drawing.Point(12, 24);
            this.lb_titular.Name = "lb_titular";
            this.lb_titular.Size = new System.Drawing.Size(87, 18);
            this.lb_titular.TabIndex = 24;
            this.lb_titular.Text = "Transferir";
            this.lb_titular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valorTranferencia
            // 
            this.txt_valorTranferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorTranferencia.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_valorTranferencia.Location = new System.Drawing.Point(27, 132);
            this.txt_valorTranferencia.Name = "txt_valorTranferencia";
            this.txt_valorTranferencia.Size = new System.Drawing.Size(270, 15);
            this.txt_valorTranferencia.TabIndex = 42;
            this.txt_valorTranferencia.Text = "Valor à transferir";
            this.txt_valorTranferencia.TextChanged += new System.EventHandler(this.txt_valorTranferencia_TextChanged);
            // 
            // txt_contaDestinatario
            // 
            this.txt_contaDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contaDestinatario.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_contaDestinatario.Location = new System.Drawing.Point(27, 86);
            this.txt_contaDestinatario.Name = "txt_contaDestinatario";
            this.txt_contaDestinatario.Size = new System.Drawing.Size(270, 15);
            this.txt_contaDestinatario.TabIndex = 43;
            this.txt_contaDestinatario.Text = "Conta do destinatário";
            // 
            // btn_transferir
            // 
            this.btn_transferir.BackColor = System.Drawing.Color.White;
            this.btn_transferir.BackgroundImage = global::Bank.Properties.Resources.Transferir_Tela_Btn;
            this.btn_transferir.Location = new System.Drawing.Point(12, 577);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(300, 32);
            this.btn_transferir.TabIndex = 40;
            this.btn_transferir.TabStop = false;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 1);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(27, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 1);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::Bank.Properties.Resources.Fechar_Btn;
            this.pictureBox2.Location = new System.Drawing.Point(12, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 121);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Black;
            this.btn_fechar.BackgroundImage = global::Bank.Properties.Resources.Fechar_Btn;
            this.btn_fechar.Location = new System.Drawing.Point(302, 28);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(10, 10);
            this.btn_fechar.TabIndex = 44;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Transferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 621);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txt_contaDestinatario);
            this.Controls.Add(this.txt_valorTranferencia);
            this.Controls.Add(this.btn_transferir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lb_titular);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(340, 660);
            this.MinimumSize = new System.Drawing.Size(340, 660);
            this.Name = "Transferir";
            this.Text = "Transferir";
            ((System.ComponentModel.ISupportInitialize)(this.btn_transferir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titular;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_transferir;
        private System.Windows.Forms.TextBox txt_valorTranferencia;
        private System.Windows.Forms.TextBox txt_contaDestinatario;
        private System.Windows.Forms.PictureBox btn_fechar;
    }
}