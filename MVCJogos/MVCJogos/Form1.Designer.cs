namespace MVCJogos
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
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxDesc = new System.Windows.Forms.TextBox();
            this.boxData = new System.Windows.Forms.TextBox();
            this.boxValor = new System.Windows.Forms.TextBox();
            this.boxCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAd = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(12, 57);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(37, 20);
            this.boxId.TabIndex = 0;
            // 
            // boxDesc
            // 
            this.boxDesc.Location = new System.Drawing.Point(85, 57);
            this.boxDesc.Name = "boxDesc";
            this.boxDesc.Size = new System.Drawing.Size(249, 20);
            this.boxDesc.TabIndex = 1;
            // 
            // boxData
            // 
            this.boxData.Location = new System.Drawing.Point(151, 119);
            this.boxData.Name = "boxData";
            this.boxData.Size = new System.Drawing.Size(100, 20);
            this.boxData.TabIndex = 2;
            // 
            // boxValor
            // 
            this.boxValor.Location = new System.Drawing.Point(12, 119);
            this.boxValor.Name = "boxValor";
            this.boxValor.Size = new System.Drawing.Size(100, 20);
            this.boxValor.TabIndex = 3;
            // 
            // boxCat
            // 
            this.boxCat.Location = new System.Drawing.Point(12, 180);
            this.boxCat.Name = "boxCat";
            this.boxCat.Size = new System.Drawing.Size(37, 20);
            this.boxCat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ValorLocação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de Aquisição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id de Categoria";
            // 
            // btnAd
            // 
            this.btnAd.Location = new System.Drawing.Point(379, 54);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(75, 23);
            this.btnAd.TabIndex = 10;
            this.btnAd.Text = "Adicionar";
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(379, 112);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 11;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(379, 83);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(75, 23);
            this.btnEx.TabIndex = 13;
            this.btnEx.Text = "Excluir";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(379, 141);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 229);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCat);
            this.Controls.Add(this.boxValor);
            this.Controls.Add(this.boxData);
            this.Controls.Add(this.boxDesc);
            this.Controls.Add(this.boxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxDesc;
        private System.Windows.Forms.TextBox boxData;
        private System.Windows.Forms.TextBox boxValor;
        private System.Windows.Forms.TextBox boxCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

