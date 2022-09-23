namespace Actividad_2___DivPropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Dividir dividir = new Dividir();
            dividir.Num1 = double.Parse(Valor1.Text);
            dividir.Num2 = double.Parse(Valor2.Text);

            Resultado.Text = dividir.division().ToString();
        }
    }
}