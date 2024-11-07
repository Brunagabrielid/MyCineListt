namespace AplicativoMyCineList
{
    public partial class TeladeAbertura : Form
    {
        
        public TeladeAbertura()
        {
            InitializeComponent();
        }

        public static class DadosGlobais
        {
            public static List<string> filmesSalvos = new List<string>();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio = new TelaDeInicio();
            telaDeInicio.Show();
            this.Hide();
        }
    }
}
