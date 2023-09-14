namespace Bank
{
    partial class Depositar
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
            this.txt_valorDeposito = new System.Windows.Forms.TextBox();
            this.lb_titular = new System.Windows.Forms.Label();
            this.btn_deposito = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_valorDeposito
            // 
            this.txt_valorDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorDeposito.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_valorDeposito.Location = new System.Drawing.Point(27, 86);
            this.txt_valorDeposito.Name = "txt_valorDeposito";
            this.txt_valorDeposito.Size = new System.Drawing.Size(270, 15);
            this.txt_valorDeposito.TabIndex = 55;
            this.txt_valorDeposito.Text = "Valor do depósito";
            // 
            // lb_titular
            // 
            this.lb_titular.AutoSize = true;
            this.lb_titular.BackColor = System.Drawing.Color.Black;
            this.lb_titular.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titular.ForeColor = System.Drawing.Color.White;
            this.lb_titular.Location = new System.Drawing.Point(12, 24);
            this.lb_titular.Name = "lb_titular";
            this.lb_titular.Size = new System.Drawing.Size(89, 18);
            this.lb_titular.TabIndex = 53;
            this.lb_titular.Text = "Depositar";
            this.lb_titular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_deposito
            // 
            this.btn_deposito.BackColor = System.Drawing.Color.White;
            this.btn_deposito.BackgroundImage = global::Bank.Properties.Resources.FazerDeposito_Btn;
            this.btn_deposito.Location = new System.Drawing.Point(12, 577);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(300, 32);
            this.btn_deposito.TabIndex = 57;
            this.btn_deposito.TabStop = false;
            this.btn_deposito.Click += new System.EventHandler(this.btn_deposito_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Black;
            this.btn_fechar.BackgroundImage = global::Bank.Properties.Resources.Fechar_Btn;
            this.btn_fechar.Location = new System.Drawing.Point(302, 28);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(10, 10);
            this.btn_fechar.TabIndex = 56;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(27, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 1);
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(12, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 73);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 621);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txt_valorDeposito);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lb_titular);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(340, 660);
            this.MinimumSize = new System.Drawing.Size(340, 660);
            this.Name = "Depositar";
            this.Text = "Depositar";
            ((System.ComponentModel.ISupportInitialize)(this.btn_deposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_deposito;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.TextBox txt_valorDeposito;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_titular;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}