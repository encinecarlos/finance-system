
namespace Gama_SistemaFinanceiro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_userName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_access = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledVerde = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lb_userName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_access);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledVerde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 29);
            this.panel1.TabIndex = 0;
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Location = new System.Drawing.Point(142, 7);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(16, 13);
            this.lb_userName.TabIndex = 4;
            this.lb_userName.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User: ";
            // 
            // lb_access
            // 
            this.lb_access.AutoSize = true;
            this.lb_access.Location = new System.Drawing.Point(71, 7);
            this.lb_access.Name = "lb_access";
            this.lb_access.Size = new System.Drawing.Size(13, 13);
            this.lb_access.TabIndex = 2;
            this.lb_access.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_ledVerde
            // 
            this.pb_ledVerde.Image = global::Gama_SistemaFinanceiro.Properties.Resources.led_red;
            this.pb_ledVerde.Location = new System.Drawing.Point(0, 3);
            this.pb_ledVerde.Name = "pb_ledVerde";
            this.pb_ledVerde.Size = new System.Drawing.Size(20, 20);
            this.pb_ledVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledVerde.TabIndex = 0;
            this.pb_ledVerde.TabStop = false;
            this.pb_ledVerde.Click += new System.EventHandler(this.pb_ledVerde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 320);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gama_SistemaFinanceiro - v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledVerde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pb_ledVerde;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_userName;
        public System.Windows.Forms.Label lb_access;
    }
}

