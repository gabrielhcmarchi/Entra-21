
namespace Forms03_entra21
{
    partial class Deposito
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
            this.lblConta = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSairDeposito = new System.Windows.Forms.Button();
            this.lblQuantidadeDeposito = new System.Windows.Forms.Label();
            this.txtQtdDeposito = new System.Windows.Forms.TextBox();
            this.txtContaDeposito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(68, 24);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(82, 29);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Conta:";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(73, 182);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(143, 59);
            this.btnDeposito.TabIndex = 1;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnSairDeposito
            // 
            this.btnSairDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairDeposito.Location = new System.Drawing.Point(73, 263);
            this.btnSairDeposito.Name = "btnSairDeposito";
            this.btnSairDeposito.Size = new System.Drawing.Size(143, 59);
            this.btnSairDeposito.TabIndex = 2;
            this.btnSairDeposito.Text = "Sair";
            this.btnSairDeposito.UseVisualStyleBackColor = true;
            this.btnSairDeposito.Click += new System.EventHandler(this.btnSairDeposito_Click);
            // 
            // lblQuantidadeDeposito
            // 
            this.lblQuantidadeDeposito.AutoSize = true;
            this.lblQuantidadeDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDeposito.Location = new System.Drawing.Point(68, 67);
            this.lblQuantidadeDeposito.Name = "lblQuantidadeDeposito";
            this.lblQuantidadeDeposito.Size = new System.Drawing.Size(180, 29);
            this.lblQuantidadeDeposito.TabIndex = 3;
            this.lblQuantidadeDeposito.Text = "Quantidade R$:";
            // 
            // txtQtdDeposito
            // 
            this.txtQtdDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdDeposito.Location = new System.Drawing.Point(302, 67);
            this.txtQtdDeposito.Name = "txtQtdDeposito";
            this.txtQtdDeposito.Size = new System.Drawing.Size(207, 35);
            this.txtQtdDeposito.TabIndex = 4;
            // 
            // txtContaDeposito
            // 
            this.txtContaDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaDeposito.Location = new System.Drawing.Point(302, 24);
            this.txtContaDeposito.Name = "txtContaDeposito";
            this.txtContaDeposito.Size = new System.Drawing.Size(207, 35);
            this.txtContaDeposito.TabIndex = 5;
       
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContaDeposito);
            this.Controls.Add(this.txtQtdDeposito);
            this.Controls.Add(this.lblQuantidadeDeposito);
            this.Controls.Add(this.btnSairDeposito);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.lblConta);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSairDeposito;
        private System.Windows.Forms.Label lblQuantidadeDeposito;
        private System.Windows.Forms.TextBox txtQtdDeposito;
        private System.Windows.Forms.TextBox txtContaDeposito;
    }
}