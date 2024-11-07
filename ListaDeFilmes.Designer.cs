namespace AplicativoMyCineList
{
    partial class ListaDeFilmes
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
            btnVoltarCatalogo = new Button();
            SuspendLayout();
            // 
            // btnVoltarCatalogo
            // 
            btnVoltarCatalogo.Location = new Point(771, 12);
            btnVoltarCatalogo.Name = "btnVoltarCatalogo";
            btnVoltarCatalogo.Size = new Size(142, 49);
            btnVoltarCatalogo.TabIndex = 2;
            btnVoltarCatalogo.Text = "VOLTAR";
            btnVoltarCatalogo.UseVisualStyleBackColor = true;
            btnVoltarCatalogo.Click += btnVoltarCatalogo_Click;
            // 
            // ListaDeFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundoUrsoSemCurso;
            ClientSize = new Size(925, 529);
            Controls.Add(btnVoltarCatalogo);
            Name = "ListaDeFilmes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeFilmes";
            ResumeLayout(false);
        }

        #endregion
        private Button btnVoltarCatalogo;
    }
}