namespace Calc2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.txValue1 = new System.Windows.Forms.TextBox();
            this.txValue2 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCalculate.Location = new System.Drawing.Point(79, 260);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(237, 39);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calcular";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // txValue1
            // 
            this.txValue1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txValue1.BackColor = System.Drawing.SystemColors.MenuText;
            this.txValue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txValue1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValue1.ForeColor = System.Drawing.SystemColors.Info;
            this.txValue1.Location = new System.Drawing.Point(79, 111);
            this.txValue1.Name = "txValue1";
            this.txValue1.Size = new System.Drawing.Size(237, 27);
            this.txValue1.TabIndex = 1;
            this.txValue1.TextChanged += new System.EventHandler(this.txValue1_TextChanged);
            // 
            // txValue2
            // 
            this.txValue2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txValue2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txValue2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txValue2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValue2.ForeColor = System.Drawing.SystemColors.Info;
            this.txValue2.Location = new System.Drawing.Point(79, 216);
            this.txValue2.Name = "txValue2";
            this.txValue2.Size = new System.Drawing.Size(237, 27);
            this.txValue2.TabIndex = 2;
            this.txValue2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lbResult.Location = new System.Drawing.Point(145, 334);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 20);
            this.lbResult.TabIndex = 4;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbOperation
            // 
            this.cbOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOperation.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbOperation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbOperation.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "Adição",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.cbOperation.Location = new System.Drawing.Point(79, 165);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(237, 28);
            this.cbOperation.TabIndex = 5;
            this.cbOperation.TabStop = false;
            this.cbOperation.Text = "Operação";
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(106, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insira o N1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(106, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insira o N2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(109, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resposta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(108, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operação";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(383, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txValue2);
            this.Controls.Add(this.txValue1);
            this.Controls.Add(this.buttonCalculate);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox comboOperation;
        private System.Windows.Forms.TextBox textValue1;
        private System.Windows.Forms.TextBox textValue2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txValue1;
        private System.Windows.Forms.TextBox txValue2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

