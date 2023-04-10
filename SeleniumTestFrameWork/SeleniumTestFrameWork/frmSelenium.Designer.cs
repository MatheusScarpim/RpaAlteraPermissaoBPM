namespace SeleniumTestFrameWork
{
    partial class frmSelenium
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
            this.btnLigarRPA = new System.Windows.Forms.Button();
            this.lblApresentação = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radCredicaf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.btnHom = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLigarRPA
            // 
            this.btnLigarRPA.ForeColor = System.Drawing.Color.Black;
            this.btnLigarRPA.Location = new System.Drawing.Point(50, 352);
            this.btnLigarRPA.Name = "btnLigarRPA";
            this.btnLigarRPA.Size = new System.Drawing.Size(340, 81);
            this.btnLigarRPA.TabIndex = 0;
            this.btnLigarRPA.Text = "Ligar RPA";
            this.btnLigarRPA.UseVisualStyleBackColor = true;
            this.btnLigarRPA.Click += new System.EventHandler(this.btnLigarRPA_Click);
            // 
            // lblApresentação
            // 
            this.lblApresentação.AutoSize = true;
            this.lblApresentação.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentação.Location = new System.Drawing.Point(143, 26);
            this.lblApresentação.Name = "lblApresentação";
            this.lblApresentação.Size = new System.Drawing.Size(96, 25);
            this.lblApresentação.TabIndex = 1;
            this.lblApresentação.Text = "Credifor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radCredicaf);
            this.groupBox1.Location = new System.Drawing.Point(50, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 145);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresas";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(102, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radCredicaf
            // 
            this.radCredicaf.AutoSize = true;
            this.radCredicaf.Location = new System.Drawing.Point(3, 16);
            this.radCredicaf.Name = "radCredicaf";
            this.radCredicaf.Size = new System.Drawing.Size(64, 17);
            this.radCredicaf.TabIndex = 0;
            this.radCredicaf.TabStop = true;
            this.radCredicaf.Text = "Credicaf";
            this.radCredicaf.UseVisualStyleBackColor = true;
            this.radCredicaf.CheckedChanged += new System.EventHandler(this.radCredicaf_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo de Identificação";
            // 
            // lblMostrar
            // 
            this.lblMostrar.Location = new System.Drawing.Point(33, 313);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(357, 23);
            this.lblMostrar.TabIndex = 20;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHom
            // 
            this.btnHom.Location = new System.Drawing.Point(50, 269);
            this.btnHom.Name = "btnHom";
            this.btnHom.Size = new System.Drawing.Size(155, 29);
            this.btnHom.TabIndex = 21;
            this.btnHom.Text = "Homologação";
            this.btnHom.UseVisualStyleBackColor = true;
            this.btnHom.Click += new System.EventHandler(this.btnHom_Click);
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(235, 269);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(148, 29);
            this.btnPro.TabIndex = 22;
            this.btnPro.Text = "Produção";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // frmSelenium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 455);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.btnHom);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblApresentação);
            this.Controls.Add(this.btnLigarRPA);
            this.Name = "frmSelenium";
            this.Text = "RPA - NEXUM";
            this.Load += new System.EventHandler(this.frmSelenium_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLigarRPA;
        private System.Windows.Forms.Label lblApresentação;
        private System.Windows.Forms.RadioButton radCoo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Button btnHom;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radCredicaf;
    }
}

