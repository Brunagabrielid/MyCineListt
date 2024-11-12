namespace AplicativoMyCineList
{
    partial class DetalhesFilmes
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
            cmb_nomesFilmes = new ComboBox();
            DuracaoDoFilme = new Label();
            PaisDeOrigem = new Label();
            NomeDoFilme = new Label();
            NomeDoDiretor = new Label();
            AtoresPrincipais = new Label();
            VerDetalhes = new Button();
            SinopseDoFilme = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmb_nomesFilmes
            // 
            cmb_nomesFilmes.FormattingEnabled = true;
            cmb_nomesFilmes.Location = new Point(537, 12);
            cmb_nomesFilmes.Name = "cmb_nomesFilmes";
            cmb_nomesFilmes.Size = new Size(238, 28);
            cmb_nomesFilmes.TabIndex = 0;
            cmb_nomesFilmes.SelectedIndexChanged += cmb_nomesFilmes_SelectedIndexChanged;
            // 
            // DuracaoDoFilme
            // 
            DuracaoDoFilme.AutoSize = true;
            DuracaoDoFilme.BackColor = Color.LightGoldenrodYellow;
            DuracaoDoFilme.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DuracaoDoFilme.ForeColor = SystemColors.ActiveCaptionText;
            DuracaoDoFilme.Location = new Point(28, 259);
            DuracaoDoFilme.Name = "DuracaoDoFilme";
            DuracaoDoFilme.Size = new Size(72, 23);
            DuracaoDoFilme.TabIndex = 3;
            DuracaoDoFilme.Text = "duracao";
            // 
            // PaisDeOrigem
            // 
            PaisDeOrigem.AutoSize = true;
            PaisDeOrigem.BackColor = Color.LightGoldenrodYellow;
            PaisDeOrigem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PaisDeOrigem.ForeColor = SystemColors.ActiveCaptionText;
            PaisDeOrigem.Location = new Point(28, 199);
            PaisDeOrigem.Name = "PaisDeOrigem";
            PaisDeOrigem.Size = new Size(123, 23);
            PaisDeOrigem.TabIndex = 5;
            PaisDeOrigem.Text = "país de origem";
            // 
            // NomeDoFilme
            // 
            NomeDoFilme.AutoSize = true;
            NomeDoFilme.BackColor = Color.LightGoldenrodYellow;
            NomeDoFilme.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            NomeDoFilme.ForeColor = SystemColors.ActiveCaptionText;
            NomeDoFilme.Location = new Point(28, 179);
            NomeDoFilme.Name = "NomeDoFilme";
            NomeDoFilme.Size = new Size(112, 23);
            NomeDoFilme.TabIndex = 6;
            NomeDoFilme.Text = "titulo original";
            // 
            // NomeDoDiretor
            // 
            NomeDoDiretor.AutoSize = true;
            NomeDoDiretor.BackColor = Color.LightGoldenrodYellow;
            NomeDoDiretor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            NomeDoDiretor.ForeColor = SystemColors.ActiveCaptionText;
            NomeDoDiretor.Location = new Point(28, 239);
            NomeDoDiretor.Name = "NomeDoDiretor";
            NomeDoDiretor.Size = new Size(61, 23);
            NomeDoDiretor.TabIndex = 7;
            NomeDoDiretor.Text = "diretor";
            // 
            // AtoresPrincipais
            // 
            AtoresPrincipais.AutoSize = true;
            AtoresPrincipais.BackColor = Color.LightGoldenrodYellow;
            AtoresPrincipais.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AtoresPrincipais.ForeColor = SystemColors.ActiveCaptionText;
            AtoresPrincipais.Location = new Point(28, 219);
            AtoresPrincipais.Name = "AtoresPrincipais";
            AtoresPrincipais.Size = new Size(182, 23);
            AtoresPrincipais.TabIndex = 8;
            AtoresPrincipais.Text = "trio principal de atores";
            // 
            // VerDetalhes
            // 
            VerDetalhes.ForeColor = SystemColors.ActiveCaptionText;
            VerDetalhes.Location = new Point(781, 12);
            VerDetalhes.Name = "VerDetalhes";
            VerDetalhes.Size = new Size(130, 38);
            VerDetalhes.TabIndex = 9;
            VerDetalhes.Text = "Ver Detalhes";
            VerDetalhes.UseVisualStyleBackColor = true;
            VerDetalhes.Click += button1_Click;
            // 
            // SinopseDoFilme
            // 
            SinopseDoFilme.BackColor = Color.LightGoldenrodYellow;
            SinopseDoFilme.ForeColor = Color.Black;
            SinopseDoFilme.Location = new Point(126, 12);
            SinopseDoFilme.Multiline = true;
            SinopseDoFilme.Name = "SinopseDoFilme";
            SinopseDoFilme.ScrollBars = ScrollBars.Vertical;
            SinopseDoFilme.Size = new Size(389, 130);
            SinopseDoFilme.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 130);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGoldenrodYellow;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(28, 159);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 12;
            label1.Text = "nomeoriginal";
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(9, 525);
            button2.Name = "button2";
            button2.Size = new Size(130, 38);
            button2.TabIndex = 13;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DetalhesFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources.KB1Detalhessssss;
            ClientSize = new Size(923, 575);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(SinopseDoFilme);
            Controls.Add(VerDetalhes);
            Controls.Add(AtoresPrincipais);
            Controls.Add(NomeDoDiretor);
            Controls.Add(NomeDoFilme);
            Controls.Add(PaisDeOrigem);
            Controls.Add(DuracaoDoFilme);
            Controls.Add(cmb_nomesFilmes);
            ForeColor = Color.Coral;
            Name = "DetalhesFilmes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalhesFilmes";
            Load += DetalhesFilmes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_nomesFilmes;
        private Label DuracaoDoFilme;
        private Label PaisDeOrigem;
        private Label NomeDoFilme;
        private Label NomeDoDiretor;
        private Label AtoresPrincipais;
        private Button button1;
        private TextBox SinopseDoFilme;
        private PictureBox pictureBox1;
        private Label label1;
        private Button VerDetalhes;
        private Button button2;
    }
}