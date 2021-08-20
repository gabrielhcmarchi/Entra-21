
namespace Forms_01
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
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(80, 33);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(29, 13);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "login";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(80, 147);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(36, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "senha";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(217, 33);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 20);
            this.txtLog.TabIndex = 2;
           
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(217, 144);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(198, 228);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(630, 414);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLog);
            this.Name = "Form1";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLog;
    }
}

