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
            AddPoster = new PictureBox();
            DuracaoDoFilme = new Label();
            PaisDeOrigem = new Label();
            NomeDoFilme = new Label();
            NomeDoDiretor = new Label();
            AtoresPrincipais = new Label();
            button1 = new Button();
            SinopseDoFilme = new TextBox();
            NomePTBR = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AddPoster).BeginInit();
            SuspendLayout();
            // 
            // cmb_nomesFilmes
            // 
            cmb_nomesFilmes.FormattingEnabled = true;
            cmb_nomesFilmes.Location = new Point(675, 12);
            cmb_nomesFilmes.Name = "cmb_nomesFilmes";
            cmb_nomesFilmes.Size = new Size(238, 28);
            cmb_nomesFilmes.TabIndex = 0;
            cmb_nomesFilmes.SelectedIndexChanged += cmb_nomesFilmes_SelectedIndexChanged;
            // 
            // AddPoster
            // 
            AddPoster.Location = new Point(12, 66);
            AddPoster.Name = "AddPoster";
            AddPoster.Size = new Size(147, 197);
            AddPoster.TabIndex = 1;
            AddPoster.TabStop = false;
            // 
            // DuracaoDoFilme
            // 
            DuracaoDoFilme.AutoSize = true;
            DuracaoDoFilme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DuracaoDoFilme.Location = new Point(165, 243);
            DuracaoDoFilme.Name = "DuracaoDoFilme";
            DuracaoDoFilme.Size = new Size(63, 20);
            DuracaoDoFilme.TabIndex = 3;
            DuracaoDoFilme.Text = "duracao";
            // 
            // PaisDeOrigem
            // 
            PaisDeOrigem.AutoSize = true;
            PaisDeOrigem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PaisDeOrigem.Location = new Point(165, 183);
            PaisDeOrigem.Name = "PaisDeOrigem";
            PaisDeOrigem.Size = new Size(109, 20);
            PaisDeOrigem.TabIndex = 5;
            PaisDeOrigem.Text = "país de origem";
            // 
            // NomeDoFilme
            // 
            NomeDoFilme.AutoSize = true;
            NomeDoFilme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NomeDoFilme.Location = new Point(165, 163);
            NomeDoFilme.Name = "NomeDoFilme";
            NomeDoFilme.Size = new Size(99, 20);
            NomeDoFilme.TabIndex = 6;
            NomeDoFilme.Text = "titulo original";
            // 
            // NomeDoDiretor
            // 
            NomeDoDiretor.AutoSize = true;
            NomeDoDiretor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NomeDoDiretor.Location = new Point(165, 223);
            NomeDoDiretor.Name = "NomeDoDiretor";
            NomeDoDiretor.Size = new Size(54, 20);
            NomeDoDiretor.TabIndex = 7;
            NomeDoDiretor.Text = "diretor";
            // 
            // AtoresPrincipais
            // 
            AtoresPrincipais.AutoSize = true;
            AtoresPrincipais.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AtoresPrincipais.Location = new Point(165, 203);
            AtoresPrincipais.Name = "AtoresPrincipais";
            AtoresPrincipais.Size = new Size(160, 20);
            AtoresPrincipais.TabIndex = 8;
            AtoresPrincipais.Text = "trio principal de atores";
            // 
            // button1
            // 
            button1.Location = new Point(783, 46);
            button1.Name = "button1";
            button1.Size = new Size(130, 38);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SinopseDoFilme
            // 
            SinopseDoFilme.BackColor = Color.CornflowerBlue;
            SinopseDoFilme.ForeColor = Color.Black;
            SinopseDoFilme.Location = new Point(165, 66);
            SinopseDoFilme.Multiline = true;
            SinopseDoFilme.Name = "SinopseDoFilme";
            SinopseDoFilme.ScrollBars = ScrollBars.Vertical;
            SinopseDoFilme.Size = new Size(429, 90);
            SinopseDoFilme.TabIndex = 10;
            // 
            // NomePTBR
            // 
            NomePTBR.BackColor = Color.WhiteSmoke;
            NomePTBR.Location = new Point(12, 33);
            NomePTBR.Name = "NomePTBR";
            NomePTBR.Size = new Size(582, 27);
            NomePTBR.TabIndex = 11;
            NomePTBR.TextAlign = HorizontalAlignment.Center;
            NomePTBR.TextChanged += NomePTBR_TextChanged;
            // 
            // DetalhesFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundodetalhes;
            ClientSize = new Size(925, 529);
            Controls.Add(NomePTBR);
            Controls.Add(SinopseDoFilme);
            Controls.Add(button1);
            Controls.Add(AtoresPrincipais);
            Controls.Add(NomeDoDiretor);
            Controls.Add(NomeDoFilme);
            Controls.Add(PaisDeOrigem);
            Controls.Add(DuracaoDoFilme);
            Controls.Add(AddPoster);
            Controls.Add(cmb_nomesFilmes);
            Name = "DetalhesFilmes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalhesFilmes";
            Load += DetalhesFilmes_Load;
            ((System.ComponentModel.ISupportInitialize)AddPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_nomesFilmes;
        private PictureBox AddPoster;
        private Label DuracaoDoFilme;
        private Label PaisDeOrigem;
        private Label NomeDoFilme;
        private Label NomeDoDiretor;
        private Label AtoresPrincipais;
        private Button button1;
        private TextBox SinopseDoFilme;
        private TextBox NomePTBR;
    }
}