namespace Atividade_POO_VS
{
    partial class Form2
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
            btnvoltar = new Button();
            btnlimpar = new Button();
            btncalc = new Button();
            txtvalor = new TextBox();
            txtdesc = new TextBox();
            txttipo2 = new TextBox();
            txttipo = new TextBox();
            lblvalor = new Label();
            lbldesc = new Label();
            lbllitro = new Label();
            lbltipo2 = new Label();
            lbltipo = new Label();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnvoltar.Location = new Point(560, 361);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(129, 41);
            btnvoltar.TabIndex = 23;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpar.Location = new Point(330, 361);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(129, 41);
            btnlimpar.TabIndex = 22;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btncalc
            // 
            btncalc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncalc.Location = new Point(72, 361);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(129, 41);
            btncalc.TabIndex = 21;
            btncalc.Text = "Caucular";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // txtvalor
            // 
            txtvalor.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtvalor.Location = new Point(502, 294);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(227, 41);
            txtvalor.TabIndex = 20;
            // 
            // txtdesc
            // 
            txtdesc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtdesc.Location = new Point(502, 222);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(227, 41);
            txtdesc.TabIndex = 19;
            // 
            // txttipo2
            // 
            txttipo2.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txttipo2.Location = new Point(502, 153);
            txttipo2.Name = "txttipo2";
            txttipo2.Size = new Size(227, 41);
            txttipo2.TabIndex = 18;
            // 
            // txttipo
            // 
            txttipo.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txttipo.Location = new Point(502, 73);
            txttipo.Name = "txttipo";
            txttipo.Size = new Size(227, 41);
            txttipo.TabIndex = 17;
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblvalor.Location = new Point(277, 294);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(210, 33);
            lblvalor.TabIndex = 16;
            lblvalor.Text = "Valor a ser pago:";
            // 
            // lbldesc
            // 
            lbldesc.AutoSize = true;
            lbldesc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbldesc.Location = new Point(253, 222);
            lbldesc.Name = "lbldesc";
            lbldesc.Size = new Size(234, 33);
            lbldesc.TabIndex = 15;
            lbldesc.Text = "Valor do desconto:";
            // 
            // lbllitro
            // 
            lbllitro.AutoSize = true;
            lbllitro.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbllitro.Location = new Point(133, 153);
            lbllitro.Name = "lbllitro";
            lbllitro.Size = new Size(354, 33);
            lbllitro.TabIndex = 14;
            lbllitro.Text = "Digite a quantidade de litros: ";
            // 
            // lbltipo2
            // 
            lbltipo2.AutoSize = true;
            lbltipo2.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltipo2.ForeColor = Color.Brown;
            lbltipo2.Location = new Point(93, 81);
            lbltipo2.Name = "lbltipo2";
            lbltipo2.Size = new Size(394, 33);
            lbltipo2.TabIndex = 13;
            lbltipo2.Text = "(Digite A = Álcool / G = Gasolina)";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltipo.Location = new Point(141, 48);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(346, 33);
            lbltipo.TabIndex = 12;
            lbltipo.Text = "Digite o tipo de combustível:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalc);
            Controls.Add(txtvalor);
            Controls.Add(txtdesc);
            Controls.Add(txttipo2);
            Controls.Add(txttipo);
            Controls.Add(lblvalor);
            Controls.Add(lbldesc);
            Controls.Add(lbllitro);
            Controls.Add(lbltipo2);
            Controls.Add(lbltipo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvoltar;
        private Button btnlimpar;
        private Button btncalc;
        private TextBox txtvalor;
        private TextBox txtdesc;
        private TextBox txttipo2;
        private TextBox txttipo;
        private Label lblvalor;
        private Label lbldesc;
        private Label lbllitro;
        private Label lbltipo2;
        private Label lbltipo;
    }
}