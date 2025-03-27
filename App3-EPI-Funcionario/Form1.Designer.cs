namespace App3_EPI_Funcionario
{
    partial class appForm3
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
            this.groupBox = new System.Windows.Forms.Panel();
            this.calcularBnt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salarioFinalTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salarioTxt = new System.Windows.Forms.TextBox();
            this.faltasTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.checkEPI = new System.Windows.Forms.CheckBox();
            this.Otavio = new System.Windows.Forms.Label();
            this.Davi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.Davi);
            this.groupBox.Controls.Add(this.Otavio);
            this.groupBox.Controls.Add(this.calcularBnt);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.salarioFinalTxt);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.salarioTxt);
            this.groupBox.Controls.Add(this.faltasTxt);
            this.groupBox.Controls.Add(this.nomeTxt);
            this.groupBox.Controls.Add(this.checkEPI);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(776, 426);
            this.groupBox.TabIndex = 0;
            // 
            // calcularBnt
            // 
            this.calcularBnt.Location = new System.Drawing.Point(46, 315);
            this.calcularBnt.Name = "calcularBnt";
            this.calcularBnt.Size = new System.Drawing.Size(225, 36);
            this.calcularBnt.TabIndex = 9;
            this.calcularBnt.Text = "Calcular Salário";
            this.calcularBnt.UseVisualStyleBackColor = true;
            this.calcularBnt.Click += new System.EventHandler(this.CalcularBnt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(621, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salário Final";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salarioFinalTxt
            // 
            this.salarioFinalTxt.Location = new System.Drawing.Point(533, 378);
            this.salarioFinalTxt.Name = "salarioFinalTxt";
            this.salarioFinalTxt.ReadOnly = true;
            this.salarioFinalTxt.Size = new System.Drawing.Size(225, 20);
            this.salarioFinalTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(42, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qual o seu salário?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(42, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantas faltas?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Funcionário";
            // 
            // salarioTxt
            // 
            this.salarioTxt.Location = new System.Drawing.Point(46, 206);
            this.salarioTxt.Name = "salarioTxt";
            this.salarioTxt.Size = new System.Drawing.Size(225, 20);
            this.salarioTxt.TabIndex = 3;
            // 
            // faltasTxt
            // 
            this.faltasTxt.Location = new System.Drawing.Point(46, 140);
            this.faltasTxt.Name = "faltasTxt";
            this.faltasTxt.Size = new System.Drawing.Size(225, 20);
            this.faltasTxt.TabIndex = 2;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(46, 79);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(225, 20);
            this.nomeTxt.TabIndex = 1;
            // 
            // checkEPI
            // 
            this.checkEPI.AutoSize = true;
            this.checkEPI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEPI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkEPI.Location = new System.Drawing.Point(46, 258);
            this.checkEPI.Name = "checkEPI";
            this.checkEPI.Size = new System.Drawing.Size(168, 36);
            this.checkEPI.TabIndex = 0;
            this.checkEPI.Text = "Usou EPI?";
            this.checkEPI.UseVisualStyleBackColor = true;
            // 
            // Otavio
            // 
            this.Otavio.AutoSize = true;
            this.Otavio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Otavio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Otavio.Location = new System.Drawing.Point(567, 62);
            this.Otavio.Name = "Otavio";
            this.Otavio.Size = new System.Drawing.Size(109, 37);
            this.Otavio.TabIndex = 10;
            this.Otavio.Text = "Otavio";
            // 
            // Davi
            // 
            this.Davi.AutoSize = true;
            this.Davi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Davi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Davi.Location = new System.Drawing.Point(596, 104);
            this.Davi.Name = "Davi";
            this.Davi.Size = new System.Drawing.Size(80, 37);
            this.Davi.TabIndex = 11;
            this.Davi.Text = "Davi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(551, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Samuel";
            // 
            // appForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "appForm3";
            this.Text = "Verificar EPI";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel groupBox;
        private System.Windows.Forms.TextBox faltasTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.CheckBox checkEPI;
        private System.Windows.Forms.TextBox salarioTxt;
        private System.Windows.Forms.Button calcularBnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salarioFinalTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Davi;
        private System.Windows.Forms.Label Otavio;
    }
}

