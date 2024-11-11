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
            button1 = new Button();
            SinopseDoFilme = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // DuracaoDoFilme
            // 
            DuracaoDoFilme.AutoSize = true;
            DuracaoDoFilme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DuracaoDoFilme.Location = new Point(304, 440);
            DuracaoDoFilme.Name = "DuracaoDoFilme";
            DuracaoDoFilme.Size = new Size(63, 20);
            DuracaoDoFilme.TabIndex = 3;
            DuracaoDoFilme.Text = "duracao";
            // 
            // PaisDeOrigem
            // 
            PaisDeOrigem.AutoSize = true;
            PaisDeOrigem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PaisDeOrigem.Location = new Point(304, 380);
            PaisDeOrigem.Name = "PaisDeOrigem";
            PaisDeOrigem.Size = new Size(109, 20);
            PaisDeOrigem.TabIndex = 5;
            PaisDeOrigem.Text = "país de origem";
            // 
            // NomeDoFilme
            // 
            NomeDoFilme.AutoSize = true;
            NomeDoFilme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NomeDoFilme.Location = new Point(304, 360);
            NomeDoFilme.Name = "NomeDoFilme";
            NomeDoFilme.Size = new Size(99, 20);
            NomeDoFilme.TabIndex = 6;
            NomeDoFilme.Text = "titulo original";
            // 
            // NomeDoDiretor
            // 
            NomeDoDiretor.AutoSize = true;
            NomeDoDiretor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NomeDoDiretor.Location = new Point(304, 420);
            NomeDoDiretor.Name = "NomeDoDiretor";
            NomeDoDiretor.Size = new Size(54, 20);
            NomeDoDiretor.TabIndex = 7;
            NomeDoDiretor.Text = "diretor";
            // 
            // AtoresPrincipais
            // 
            AtoresPrincipais.AutoSize = true;
            AtoresPrincipais.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AtoresPrincipais.Location = new Point(304, 400);
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
            SinopseDoFilme.Location = new Point(385, 127);
            SinopseDoFilme.Multiline = true;
            SinopseDoFilme.Name = "SinopseDoFilme";
            SinopseDoFilme.ScrollBars = ScrollBars.Vertical;
            SinopseDoFilme.Size = new Size(420, 181);
            SinopseDoFilme.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(61, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 234);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(304, 330);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 12;
            label1.Text = "nomeoriginal";
            // 
            // DetalhesFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(925, 529);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(SinopseDoFilme);
            Controls.Add(button1);
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
    }
}