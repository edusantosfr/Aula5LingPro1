namespace aula5
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
            this.listBoxV1 = new System.Windows.Forms.ListBox();
            this.listBoxV2 = new System.Windows.Forms.ListBox();
            this.listBoxRES = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxV1
            // 
            this.listBoxV1.FormattingEnabled = true;
            this.listBoxV1.Location = new System.Drawing.Point(36, 171);
            this.listBoxV1.Name = "listBoxV1";
            this.listBoxV1.Size = new System.Drawing.Size(120, 95);
            this.listBoxV1.TabIndex = 0;
            // 
            // listBoxV2
            // 
            this.listBoxV2.FormattingEnabled = true;
            this.listBoxV2.Location = new System.Drawing.Point(162, 171);
            this.listBoxV2.Name = "listBoxV2";
            this.listBoxV2.Size = new System.Drawing.Size(120, 95);
            this.listBoxV2.TabIndex = 1;
            // 
            // listBoxRES
            // 
            this.listBoxRES.FormattingEnabled = true;
            this.listBoxRES.Location = new System.Drawing.Point(97, 272);
            this.listBoxRES.Name = "listBoxRES";
            this.listBoxRES.Size = new System.Drawing.Size(120, 95);
            this.listBoxRES.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clique em resultado para \r\nver a resposta da multiplicação \r\ndos dois vetores:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRES);
            this.Controls.Add(this.listBoxV2);
            this.Controls.Add(this.listBoxV1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxV1;
        private System.Windows.Forms.ListBox listBoxV2;
        private System.Windows.Forms.ListBox listBoxRES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

