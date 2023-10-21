namespace subnetting
{
    partial class SM_box
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.host_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sottoreti_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calcolo_btn = new System.Windows.Forms.Button();
            this.classe_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CDIR_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci numero di host";
            // 
            // host_box
            // 
            this.host_box.Location = new System.Drawing.Point(48, 67);
            this.host_box.Name = "host_box";
            this.host_box.Size = new System.Drawing.Size(100, 20);
            this.host_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserisci il numero di sottoreti";
            // 
            // sottoreti_box
            // 
            this.sottoreti_box.Location = new System.Drawing.Point(48, 122);
            this.sottoreti_box.Name = "sottoreti_box";
            this.sottoreti_box.Size = new System.Drawing.Size(100, 20);
            this.sottoreti_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // calcolo_btn
            // 
            this.calcolo_btn.Location = new System.Drawing.Point(230, 96);
            this.calcolo_btn.Name = "calcolo_btn";
            this.calcolo_btn.Size = new System.Drawing.Size(75, 23);
            this.calcolo_btn.TabIndex = 5;
            this.calcolo_btn.Text = "calcola";
            this.calcolo_btn.UseVisualStyleBackColor = true;
            this.calcolo_btn.Click += new System.EventHandler(this.calcolo_btn_Click);
            // 
            // classe_box
            // 
            this.classe_box.Location = new System.Drawing.Point(369, 67);
            this.classe_box.Name = "classe_box";
            this.classe_box.Size = new System.Drawing.Size(100, 20);
            this.classe_box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Classe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CDIR";
            // 
            // CDIR_box
            // 
            this.CDIR_box.Location = new System.Drawing.Point(369, 122);
            this.CDIR_box.Name = "CDIR_box";
            this.CDIR_box.Size = new System.Drawing.Size(100, 20);
            this.CDIR_box.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subnet Mask";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // SM_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CDIR_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.classe_box);
            this.Controls.Add(this.calcolo_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sottoreti_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.host_box);
            this.Controls.Add(this.label1);
            this.Name = "SM_box";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox host_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sottoreti_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcolo_btn;
        private System.Windows.Forms.TextBox classe_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CDIR_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

