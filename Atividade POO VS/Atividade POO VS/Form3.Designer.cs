namespace Atividade_POO_VS
{
    partial class Form3
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
            lblnum = new Label();
            txtnum = new TextBox();
            lblresult = new Label();
            btnvoltar = new Button();
            btnlimpar = new Button();
            btncalc = new Button();
            txtresult = new TextBox();
            SuspendLayout();
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblnum.Location = new Point(29, 69);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(426, 33);
            lblnum.TabIndex = 0;
            lblnum.Text = "Digite o número a ser multiplicado: ";
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtnum.Location = new Point(486, 69);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(227, 41);
            txtnum.TabIndex = 18;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblresult.Location = new Point(12, 141);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(146, 33);
            lblresult.TabIndex = 19;
            lblresult.Text = "Resultado: ";
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnvoltar.Location = new Point(574, 289);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(129, 41);
            btnvoltar.TabIndex = 26;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpar.Location = new Point(344, 289);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(129, 41);
            btnlimpar.TabIndex = 25;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btncalc
            // 
            btncalc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncalc.Location = new Point(86, 289);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(129, 41);
            btncalc.TabIndex = 24;
            btncalc.Text = "Caucular";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtresult.Location = new Point(142, 141);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(646, 32);
            txtresult.TabIndex = 27;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtresult);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalc);
            Controls.Add(lblresult);
            Controls.Add(txtnum);
            Controls.Add(lblnum);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnum;
        private TextBox txtnum;
        private Label lblresult;
        private Button btnvoltar;
        private Button btnlimpar;
        private Button btncalc;
        private TextBox txtresult;
    }
}