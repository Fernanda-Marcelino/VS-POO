namespace Atividade_POO_VS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblano = new Label();
            lblnomes = new Label();
            lbltitulo = new Label();
            menuStrip1 = new MenuStrip();
            atividadesToolStripMenuItem = new ToolStripMenuItem();
            postoDeCombustívelToolStripMenuItem = new ToolStripMenuItem();
            tabuada1ToolStripMenuItem = new ToolStripMenuItem();
            tabuada2ToolStripMenuItem = new ToolStripMenuItem();
            tabuada3ToolStripMenuItem = new ToolStripMenuItem();
            eleiçãoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblano
            // 
            lblano.AutoSize = true;
            lblano.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblano.Location = new Point(283, 246);
            lblano.Name = "lblano";
            lblano.Size = new Size(236, 32);
            lblano.TabIndex = 6;
            lblano.Text = "2º Jogos Digitais";
            // 
            // lblnomes
            // 
            lblnomes.AutoSize = true;
            lblnomes.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblnomes.Location = new Point(199, 214);
            lblnomes.Name = "lblnomes";
            lblnomes.Size = new Size(403, 32);
            lblnomes.TabIndex = 5;
            lblnomes.Text = "Denis Rocha e Fernanda Viana";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.Location = new Point(283, 172);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(220, 42);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Atividade POO";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { atividadesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            atividadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { postoDeCombustívelToolStripMenuItem, tabuada1ToolStripMenuItem, tabuada2ToolStripMenuItem, tabuada3ToolStripMenuItem, eleiçãoToolStripMenuItem });
            atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            atividadesToolStripMenuItem.Size = new Size(74, 20);
            atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // postoDeCombustívelToolStripMenuItem
            // 
            postoDeCombustívelToolStripMenuItem.Name = "postoDeCombustívelToolStripMenuItem";
            postoDeCombustívelToolStripMenuItem.Size = new Size(190, 22);
            postoDeCombustívelToolStripMenuItem.Text = "Posto de Combustível";
            postoDeCombustívelToolStripMenuItem.Click += postoDeCombustívelToolStripMenuItem_Click_1;
            // 
            // tabuada1ToolStripMenuItem
            // 
            tabuada1ToolStripMenuItem.Name = "tabuada1ToolStripMenuItem";
            tabuada1ToolStripMenuItem.Size = new Size(190, 22);
            tabuada1ToolStripMenuItem.Text = "Tabuada 1";
            tabuada1ToolStripMenuItem.Click += tabuada1ToolStripMenuItem_Click_1;
            // 
            // tabuada2ToolStripMenuItem
            // 
            tabuada2ToolStripMenuItem.Name = "tabuada2ToolStripMenuItem";
            tabuada2ToolStripMenuItem.Size = new Size(190, 22);
            tabuada2ToolStripMenuItem.Text = "Tabuada 2";
            tabuada2ToolStripMenuItem.Click += tabuada2ToolStripMenuItem_Click_1;
            // 
            // tabuada3ToolStripMenuItem
            // 
            tabuada3ToolStripMenuItem.Name = "tabuada3ToolStripMenuItem";
            tabuada3ToolStripMenuItem.Size = new Size(190, 22);
            tabuada3ToolStripMenuItem.Text = "Tabuada 3";
            // 
            // eleiçãoToolStripMenuItem
            // 
            eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
            eleiçãoToolStripMenuItem.Size = new Size(190, 22);
            eleiçãoToolStripMenuItem.Text = "Eleição";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(lblano);
            Controls.Add(lblnomes);
            Controls.Add(lbltitulo);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblano;
        private Label lblnomes;
        private Label lbltitulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atividadesToolStripMenuItem;
        private ToolStripMenuItem postoDeCombustívelToolStripMenuItem;
        private ToolStripMenuItem tabuada1ToolStripMenuItem;
        private ToolStripMenuItem tabuada2ToolStripMenuItem;
        private ToolStripMenuItem tabuada3ToolStripMenuItem;
        private ToolStripMenuItem eleiçãoToolStripMenuItem;
    }
}