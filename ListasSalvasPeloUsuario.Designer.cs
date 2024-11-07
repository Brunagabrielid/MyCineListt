namespace AplicativoMyCineList
{
    partial class ListasSalvasPeloUsuario
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
            listaDeFilmesSalvos = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listaDeFilmesSalvos
            // 
            listaDeFilmesSalvos.FormattingEnabled = true;
            listaDeFilmesSalvos.ItemHeight = 20;
            listaDeFilmesSalvos.Location = new Point(12, 30);
            listaDeFilmesSalvos.Name = "listaDeFilmesSalvos";
            listaDeFilmesSalvos.Size = new Size(361, 384);
            listaDeFilmesSalvos.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(379, 30);
            button1.Name = "button1";
            button1.Size = new Size(214, 31);
            button1.TabIndex = 2;
            button1.Text = "VOLTAR PARA TELA INICIAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListasSalvasPeloUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundominhaslistas;
            ClientSize = new Size(751, 432);
            Controls.Add(button1);
            Controls.Add(listaDeFilmesSalvos);
            Name = "ListasSalvasPeloUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListasSalvasPeloUsuario";
            Load += ListasSalvasPeloUsuario_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listaDeFilmesSalvos;
        private Button button1;
    }
}