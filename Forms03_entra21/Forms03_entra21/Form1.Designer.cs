
namespace Forms03_entra21
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExec2 = new System.Windows.Forms.Button();
            this.btnExec01 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExec03 = new System.Windows.Forms.Button();
            this.btnExec04 = new System.Windows.Forms.Button();
            this.btnFm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExec2
            // 
            this.btnExec2.Location = new System.Drawing.Point(178, 40);
            this.btnExec2.Name = "btnExec2";
            this.btnExec2.Size = new System.Drawing.Size(75, 23);
            this.btnExec2.TabIndex = 2;
            this.btnExec2.Text = "Exec02";
            this.btnExec2.UseVisualStyleBackColor = true;
            this.btnExec2.Click += new System.EventHandler(this.btnExec2_Click);
            // 
            // btnExec01
            // 
            this.btnExec01.Location = new System.Drawing.Point(65, 40);
            this.btnExec01.Name = "btnExec01";
            this.btnExec01.Size = new System.Drawing.Size(75, 23);
            this.btnExec01.TabIndex = 3;
            this.btnExec01.Text = "Exec01";
            this.btnExec01.UseVisualStyleBackColor = true;
            this.btnExec01.Click += new System.EventHandler(this.btnExec01_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(553, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExec03
            // 
            this.btnExec03.Location = new System.Drawing.Point(299, 40);
            this.btnExec03.Name = "btnExec03";
            this.btnExec03.Size = new System.Drawing.Size(75, 23);
            this.btnExec03.TabIndex = 5;
            this.btnExec03.Text = "Exec03";
            this.btnExec03.UseVisualStyleBackColor = true;
            this.btnExec03.Click += new System.EventHandler(this.btnExec03_Click);
            // 
            // btnExec04
            // 
            this.btnExec04.Location = new System.Drawing.Point(432, 40);
            this.btnExec04.Name = "btnExec04";
            this.btnExec04.Size = new System.Drawing.Size(75, 23);
            this.btnExec04.TabIndex = 6;
            this.btnExec04.Text = "exec04";
            this.btnExec04.UseVisualStyleBackColor = true;
            this.btnExec04.Click += new System.EventHandler(this.btnExec04_Click);
            // 
            // btnFm
            // 
            this.btnFm.Location = new System.Drawing.Point(553, 40);
            this.btnFm.Name = "btnFm";
            this.btnFm.Size = new System.Drawing.Size(75, 23);
            this.btnFm.TabIndex = 7;
            this.btnFm.Text = "F.M";
            this.btnFm.UseVisualStyleBackColor = true;
            this.btnFm.Click += new System.EventHandler(this.btnFm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 435);
            this.Controls.Add(this.btnFm);
            this.Controls.Add(this.btnExec04);
            this.Controls.Add(this.btnExec03);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExec01);
            this.Controls.Add(this.btnExec2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExec2;
        private System.Windows.Forms.Button btnExec01;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExec03;
        private System.Windows.Forms.Button btnExec04;
        private System.Windows.Forms.Button btnFm;
    }
}

