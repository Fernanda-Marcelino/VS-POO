namespace Atividade_POO_VS
{
    partial class Form6
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
            txtvotos = new TextBox();
            lbltipo2 = new Label();
            lblvotos = new Label();
            btnjose = new Button();
            btnmaria = new Button();
            btnjoao = new Button();
            btnfim = new Button();
            txtganhador = new TextBox();
            lblganhador = new Label();
            btnvoltar = new Button();
            btnreiniciar = new Button();
            lblnome = new Label();
            SuspendLayout();
            // 
            // txtvotos
            // 
            txtvotos.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtvotos.Location = new Point(466, 111);
            txtvotos.Name = "txtvotos";
            txtvotos.Size = new Size(227, 41);
            txtvotos.TabIndex = 20;
            // 
            // lbltipo2
            // 
            lbltipo2.AutoSize = true;
            lbltipo2.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltipo2.ForeColor = Color.Brown;
            lbltipo2.Location = new Point(12, 19);
            lbltipo2.Name = "lbltipo2";
            lbltipo2.Size = new Size(326, 33);
            lbltipo2.TabIndex = 19;
            lbltipo2.Text = "Clique no nome pata votar:";
            // 
            // lblvotos
            // 
            lblvotos.AutoSize = true;
            lblvotos.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblvotos.Location = new Point(452, 75);
            lblvotos.Name = "lblvotos";
            lblvotos.Size = new Size(280, 33);
            lblvotos.TabIndex = 18;
            lblvotos.Text = "Porcentagem de votos:";
            lblvotos.Click += lbltipo_Click;
            // 
            // btnjose
            // 
            btnjose.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnjose.Location = new Point(28, 60);
            btnjose.Name = "btnjose";
            btnjose.Size = new Size(239, 48);
            btnjose.TabIndex = 25;
            btnjose.Text = "José Nascimento";
            btnjose.UseVisualStyleBackColor = true;
            btnjose.Click += btnjose_Click;
            // 
            // btnmaria
            // 
            btnmaria.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmaria.Location = new Point(28, 135);
            btnmaria.Name = "btnmaria";
            btnmaria.Size = new Size(239, 48);
            btnmaria.TabIndex = 26;
            btnmaria.Text = "Maria Juruma";
            btnmaria.UseVisualStyleBackColor = true;
            btnmaria.Click += btnmaria_Click;
            // 
            // btnjoao
            // 
            btnjoao.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnjoao.Location = new Point(28, 216);
            btnjoao.Name = "btnjoao";
            btnjoao.Size = new Size(239, 48);
            btnjoao.TabIndex = 27;
            btnjoao.Text = "João da Tapioca";
            btnjoao.UseVisualStyleBackColor = true;
            btnjoao.Click += btnjoao_Click;
            // 
            // btnfim
            // 
            btnfim.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnfim.Location = new Point(28, 390);
            btnfim.Name = "btnfim";
            btnfim.Size = new Size(239, 48);
            btnfim.TabIndex = 28;
            btnfim.Text = "Finalizar Votação";
            btnfim.UseVisualStyleBackColor = true;
            btnfim.Click += btnfim_Click;
            // 
            // txtganhador
            // 
            txtganhador.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtganhador.Location = new Point(466, 245);
            txtganhador.Name = "txtganhador";
            txtganhador.Size = new Size(227, 41);
            txtganhador.TabIndex = 29;
            // 
            // lblganhador
            // 
            lblganhador.AutoSize = true;
            lblganhador.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblganhador.Location = new Point(506, 209);
            lblganhador.Name = "lblganhador";
            lblganhador.Size = new Size(137, 33);
            lblganhador.TabIndex = 30;
            lblganhador.Text = "Ganhador:";
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnvoltar.Location = new Point(649, 325);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(129, 41);
            btnvoltar.TabIndex = 35;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnreiniciar
            // 
            btnreiniciar.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnreiniciar.Location = new Point(434, 325);
            btnreiniciar.Name = "btnreiniciar";
            btnreiniciar.Size = new Size(129, 41);
            btnreiniciar.TabIndex = 34;
            btnreiniciar.Text = "Reiniciar";
            btnreiniciar.UseVisualStyleBackColor = true;
            btnreiniciar.Click += btnreiniciar_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblnome.Location = new Point(64, 303);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(0, 33);
            lblnome.TabIndex = 36;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblnome);
            Controls.Add(btnvoltar);
            Controls.Add(btnreiniciar);
            Controls.Add(lblganhador);
            Controls.Add(txtganhador);
            Controls.Add(btnfim);
            Controls.Add(btnjoao);
            Controls.Add(btnmaria);
            Controls.Add(btnjose);
            Controls.Add(txtvotos);
            Controls.Add(lbltipo2);
            Controls.Add(lblvotos);
            Name = "Form6";
            Text = "Eleição";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtvotos;
        private Label lbltipo2;
        private Label lblvotos;
        private Button btnjose;
        private Button btnmaria;
        private Button btnjoao;
        private Button btnfim;
        private TextBox txtganhador;
        private Label lblganhador;
        private Button btnvoltar;
        private Button btnreiniciar;
        private Label lblnome;
    }
}