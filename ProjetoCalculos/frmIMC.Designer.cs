namespace ProjetoCalculos
{
    partial class frmIMC
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
            this.btnResult = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(85, 100);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(28, 24);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(85, 33);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPeso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(85, 62);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(119, 101);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(66, 23);
            this.txtResult.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(157, 176);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(57, 24);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.txtVoltar_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(157, 130);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(28, 24);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(85, 135);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 15);
            this.lblSituacao.TabIndex = 8;
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 225);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIMC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.frmIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnResult;
        private TextBox txtPeso;
        private Label label1;
        private Label label2;
        private TextBox txtAltura;
        private TextBox txtResult;
        private Button btnVoltar;
        private Button btnC;
        private Label lblSituacao;
    }
}