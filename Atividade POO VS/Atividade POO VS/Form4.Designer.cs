namespace Atividade_POO_VS
{
    partial class Form4
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
            txtresult = new TextBox();
            btnvoltar = new Button();
            btnlimpar = new Button();
            btncalc = new Button();
            lblresult = new Label();
            txtnum = new TextBox();
            lblnum = new Label();
            SuspendLayout();
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtresult.Location = new Point(180, 167);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(608, 32);
            txtresult.TabIndex = 34;
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnvoltar.Location = new Point(612, 315);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(129, 41);
            btnvoltar.TabIndex = 33;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpar.Location = new Point(382, 315);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(129, 41);
            btnlimpar.TabIndex = 32;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btncalc
            // 
            btncalc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncalc.Location = new Point(130, 315);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(129, 41);
            btncalc.TabIndex = 31;
            btncalc.Text = "Caucular";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblresult.Location = new Point(50, 167);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(146, 33);
            lblresult.TabIndex = 30;
            lblresult.Text = "Resultado: ";
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtnum.Location = new Point(524, 95);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(227, 41);
            txtnum.TabIndex = 29;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblnum.Location = new Point(67, 95);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(426, 33);
            lblnum.TabIndex = 28;
            lblnum.Text = "Digite o número a ser multiplicado: ";
            // 
            // Form4
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
            Name = "Form4";
            Text = "Tabuada DO   While";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresult;
        private Button btnvoltar;
        private Button btnlimpar;
        private Button btncalc;
        private Label lblresult;
        private TextBox txtnum;
        private Label lblnum;
    }
}