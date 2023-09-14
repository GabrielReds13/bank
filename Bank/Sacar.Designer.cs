namespace Bank
{
    partial class Sacar
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
            this.txt_valorSaque = new System.Windows.Forms.TextBox();
            this.lb_titular = new System.Windows.Forms.Label();
            this.btn_saque = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_saque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_valorSaque
            // 
            this.txt_valorSaque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorSaque.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_valorSaque.Location = new System.Drawing.Point(27, 86);
            this.txt_valorSaque.Name = "txt_valorSaque";
            this.txt_valorSaque.Size = new System.Drawing.Size(270, 15);
            this.txt_valorSaque.TabIndex = 49;
            this.txt_valorSaque.Text = "Valor do saque";
            // 
            // lb_titular
            // 
            this.lb_titular.AutoSize = true;
            this.lb_titular.BackColor = System.Drawing.Color.Black;
            this.lb_titular.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titular.ForeColor = System.Drawing.Color.White;
            this.lb_titular.Location = new System.Drawing.Point(12, 24);
            this.lb_titular.Name = "lb_titular";
            this.lb_titular.Size = new System.Drawing.Size(52, 18);
            this.lb_titular.TabIndex = 45;
            this.lb_titular.Text = "Sacar";
            this.lb_titular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_saque
            // 
            this.btn_saque.BackColor = System.Drawing.Color.White;
            this.btn_saque.BackgroundImage = global::Bank.Properties.Resources.FazerSaque_Btn;
            this.btn_saque.Location = new System.Drawing.Point(12, 577);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(300, 32);
            this.btn_saque.TabIndex = 51;
            this.btn_saque.TabStop = false;
            this.btn_saque.Click += new System.EventHandler(this.btn_saque_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Black;
            this.btn_fechar.BackgroundImage = global::Bank.Properties.Resources.Fechar_Btn;
            this.btn_fechar.Location = new System.Drawing.Point(302, 28);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(10, 10);
            this.btn_fechar.TabIndex = 50;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(27, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 1);
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(12, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 73);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 621);
            this.Controls.Add(this.btn_saque);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txt_valorSaque);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lb_titular);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(340, 660);
            this.MinimumSize = new System.Drawing.Size(340, 660);
            this.Name = "Sacar";
            this.Text = "Sacar";
            ((System.ComponentModel.ISupportInitialize)(this.btn_saque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valorSaque;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_titular;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.PictureBox btn_saque;
    }
}